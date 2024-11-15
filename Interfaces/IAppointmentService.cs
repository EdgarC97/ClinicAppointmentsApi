using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicAppointmentsApi.DTOS;
using ClinicAppointmentsApi.Models;

namespace ClinicAppointmentsApi.Interfaces
{
    // Interface to define the contract for appointment-related services
    public interface IAppointmentService
    {
        // Schedules a new appointment for the patient with the doctor
        Task<string> ScheduleAppointmentAsync(Appointment appointment);

        // Checks if there is any conflict with an existing appointment for the doctor at the given time
        Task<bool> CheckAppointmentConflictAsync(int doctorId, DateTime appointmentDate);

        // Checks if the patient already has a scheduled appointment with the same doctor for the same medical problem
        Task<bool> CheckDuplicateAppointmentAsync(int patientId, int doctorId, string medicalProblem);

        // Checks if the doctor is available at the given date and time
        Task<bool> CheckDoctorAvailabilityAsync(int doctorId, DateTime appointmentDate);

        // Retrieves a list of appointments scheduled for a particular doctor
        Task<IEnumerable<Appointment>> GetAppointmentsByDoctorAsync(int doctorId);

        // Method to get the appointment history for a specific patient.
        Task<IEnumerable<AppointmentHistoryDTO>> GetAppointmentHistoryByPatientAsync(int patientId);
        // Method to cancel an appointment
        Task<string> CancelAppointmentAsync(int appointmentId);

        // Method to filter appointments based on date, specialty, and medical problem
        Task<IEnumerable<Appointment>> GetFilteredAppointmentsAsync(AppointmentFilterDTO filter);

        // Updates the doctor's availability once an appointment is scheduled
        Task UpdateDoctorAvailabilityAsync(int doctorId, DateTime appointmentDate);

        // Method to delete an appointment
        Task<(bool IsSuccess, string Message)> DeleteAppointmentAsync(int id);
    }
}