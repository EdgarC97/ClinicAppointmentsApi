using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicAppointmentsApi.DTOS;
using ClinicAppointmentsApi.Interfaces;
using ClinicAppointmentsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAppointmentsApi.Controllers.v1.AppointmentControllers
{
    /// <summary>
    /// Controller to manage appointment-related operations such as scheduling, checking conflicts, etc.
    /// </summary>
    [ApiController]
    [Route("api/v1/appointments")]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        /// <summary>
        /// Initializes a new instance of the AppointmentsController with the appointment service.
        /// </summary>
        /// <param name="appointmentService">The appointment service to handle business logic.</param>
        public AppointmentsController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        /// <summary>
        /// Schedules a new appointment for a patient with a specific doctor.
        /// </summary>
        /// <param name="appointmentDto">The DTO containing the appointment details.</param>
        /// <returns>An IActionResult indicating whether the appointment was successfully scheduled or if there was a conflict.</returns>
        [HttpPost("schedule")]
        public async Task<IActionResult> ScheduleAppointment([FromBody] AppointmentCreateDTO appointmentDto)
        {
            // Create the appointment object from the DTO
            var appointment = new Appointment
            {
                PatientId = appointmentDto.PatientId,
                DoctorId = appointmentDto.DoctorId,
                AppointmentDate = appointmentDto.AppointmentDate,
                MedicalProblem = appointmentDto.MedicalProblem,
                Status = AppointmentStatus.Scheduled,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            // Delegate the logic to the service to handle conflicts and scheduling
            var result = await _appointmentService.ScheduleAppointmentAsync(appointment);

            if (result.StartsWith("The doctor") || result.StartsWith("You already"))
            {
                return BadRequest(result);  // If there's a conflict, return a bad request with the message
            }

            return Ok(result);  // If scheduled successfully, return a success message
        }

        /// <summary>
        /// Gets a list of appointments for a specific doctor.
        /// </summary>
        /// <param name="doctorId">The doctor's ID to retrieve appointments for.</param>
        /// <returns>A list of appointments for the specified doctor.</returns>
        [HttpGet("doctor/{doctorId}")]
        public async Task<IActionResult> GetAppointmentsByDoctor(int doctorId)
        {
            var appointments = await _appointmentService.GetAppointmentsByDoctorAsync(doctorId);
            return Ok(appointments);
        }

        /// <summary>
        /// Checks if a doctor is available at a specific date and time.
        /// </summary>
        /// <param name="doctorId">The doctor's ID to check availability for.</param>
        /// <param name="appointmentDate">The date and time to check availability for.</param>
        /// <returns>A response indicating whether the doctor is available or not.</returns>
        [HttpGet("check-availability/{doctorId}")]
        public async Task<IActionResult> CheckDoctorAvailability(int doctorId, DateTime appointmentDate)
        {
            var isAvailable = await _appointmentService.CheckDoctorAvailabilityAsync(doctorId, appointmentDate);

            if (isAvailable)
            {
                return Ok("The doctor is available at this time.");
            }

            return BadRequest("The doctor is not available at this time.");
        }

        /// <summary>
        /// Retrieves the appointment history for a specific patient by their ID.
        /// </summary>
        /// <param name="patientId">The ID of the patient to retrieve appointment history for.</param>
        /// <returns>An IActionResult containing a list of appointments for the specified patient.</returns>
        [HttpGet("history/{patientId}")]
        public async Task<IActionResult> GetAppointmentHistoryByPatient(int patientId)
        {
            // Call the service to get the appointment history for the specified patient
            var appointments = await _appointmentService.GetAppointmentHistoryByPatientAsync(patientId);

            if (appointments == null || !appointments.Any())
            {
                // Return a 404 if no appointments were found for the patient
                return NotFound("No appointments found for this patient.");
            }

            // Return the list of appointments with a 200 OK response
            return Ok(appointments);
        }

        /// <summary>
        /// Cancels an existing appointment by changing its status to 'Canceled'.
        /// </summary>
        /// <param name="appointmentId">The ID of the appointment to cancel.</param>
        /// <returns>An IActionResult with the result of the cancellation.</returns>
        [HttpPost("cancel/{appointmentId}")]
        public async Task<IActionResult> CancelAppointment(int appointmentId)
        {
            // Call the service method to cancel the appointment
            var result = await _appointmentService.CancelAppointmentAsync(appointmentId);

            if (result == "Appointment not found.")
            {
                return NotFound(result);  // If the appointment is not found, return 404
            }

            return Ok(result);  // Return success message if the cancellation was successful
        }
    }
}