using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicAppointmentsApi.Data;
using ClinicAppointmentsApi.DTOS;
using ClinicAppointmentsApi.Interfaces;
using ClinicAppointmentsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicAppointmentsApi.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly AppDbContext _context;

        public AppointmentService(AppDbContext context)
        {
            _context = context;
        }

        // Checks if there's a conflict with an existing appointment for the doctor at the specified time
        public async Task<bool> CheckAppointmentConflictAsync(int doctorId, DateTime appointmentDate)
        {
            var conflictingAppointments = await _context.Appointments
                .Where(a => a.DoctorId == doctorId && a.AppointmentDate == appointmentDate && a.Status == AppointmentStatus.Scheduled)
                .ToListAsync();

            return conflictingAppointments.Any();
        }

        // Checks if the patient already has a scheduled appointment with the same doctor for the same medical problem
        public async Task<bool> CheckDuplicateAppointmentAsync(int patientId, int doctorId, string medicalProblem)
        {
            var duplicateAppointments = await _context.Appointments
                .Where(a => a.PatientId == patientId && a.DoctorId == doctorId && a.MedicalProblem == medicalProblem && a.Status == AppointmentStatus.Scheduled)
                .ToListAsync();

            return duplicateAppointments.Any();
        }

        // Checks if a doctor is available at a specific date and time
        public async Task<bool> CheckDoctorAvailabilityAsync(int doctorId, DateTime appointmentDate)
        {
            // Check if the doctor has any scheduled appointment at the given time
            return !(await CheckAppointmentConflictAsync(doctorId, appointmentDate));
        }

        // Updates the doctor's availability after an appointment is scheduled
        public async Task UpdateDoctorAvailabilityAsync(int doctorId, DateTime appointmentDate)
        {
            var availability = await _context.Availabilities
                .FirstOrDefaultAsync(a => a.DoctorId == doctorId && a.AvailableDate.Date == appointmentDate.Date);

            if (availability != null)
            {
                // Mark the time slot as no longer available (assuming the whole time slot is taken by the appointment)
                availability.StartTime = DateTime.MaxValue.TimeOfDay; // or set it to a value indicating it's no longer available
                availability.EndTime = DateTime.MinValue.TimeOfDay;
                availability.UpdatedAt = DateTime.UtcNow;
                _context.Availabilities.Update(availability);
                await _context.SaveChangesAsync();
            }
        }

        // Schedules a new appointment after checking conflicts and duplicates
        public async Task<string> ScheduleAppointmentAsync(Appointment appointment)
        {
            // Step 1: Check for time conflicts (doctor has an appointment at the same time)
            bool conflict = await CheckAppointmentConflictAsync(appointment.DoctorId, appointment.AppointmentDate);

            if (conflict)
            {
                return "The doctor already has an appointment at this time. Please choose another time.";
            }

            // Step 2: Check for duplicate appointments (patient has the same problem with the same doctor)
            bool duplicate = await CheckDuplicateAppointmentAsync(appointment.PatientId, appointment.DoctorId, appointment.MedicalProblem);

            if (duplicate)
            {
                return "You already have an appointment for this problem with the same doctor.";
            }

            // Step 3: If no conflicts or duplicates, schedule the appointment
            appointment.Status = AppointmentStatus.Scheduled;
            appointment.CreatedAt = DateTime.UtcNow;
            appointment.UpdatedAt = DateTime.UtcNow;

            // Save the appointment to the database
            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();

            // Step 4: Update the doctor's availability after the appointment is scheduled
            await UpdateDoctorAvailabilityAsync(appointment.DoctorId, appointment.AppointmentDate);

            return "Appointment scheduled successfully.";
        }

        // Retrieves all appointments for a specific doctor
        public async Task<IEnumerable<Appointment>> GetAppointmentsByDoctorAsync(int doctorId)
        {
            return await _context.Appointments
                .Where(a => a.DoctorId == doctorId)
                .ToListAsync();
        }

        // Method to retrieve the appointment history for a specific patient
        public async Task<IEnumerable<AppointmentHistoryDTO>> GetAppointmentHistoryByPatientAsync(int patientId)
        {
            // Fetch appointments for the patient and join with Doctor to get the doctor's name
            var appointments = await _context.Appointments
                .Where(a => a.PatientId == patientId)
                .Include(a => a.Doctor)  // Include Doctor information
                .Select(a => new AppointmentHistoryDTO
                {
                    DoctorName = a.Doctor.Name, // Get doctor's name
                    AppointmentDate = a.AppointmentDate, // Get appointment date
                    MedicalProblem = a.MedicalProblem // Get medical problem
                })
                .ToListAsync();

            return appointments; // Return the list of appointment history
        }

        // Method to cancel an appointment
        public async Task<string> CancelAppointmentAsync(int appointmentId)
        {
            // Retrieve the appointment by ID
            var appointment = await _context.Appointments.FindAsync(appointmentId);

            if (appointment == null)
            {
                return "Appointment not found."; // Return a message if the appointment is not found
            }

            // Change the status of the appointment to 'Canceled'
            appointment.Status = AppointmentStatus.Canceled;
            appointment.UpdatedAt = DateTime.UtcNow;  // Update the timestamp

            // Save the changes to the database
            await _context.SaveChangesAsync();

            return "Appointment successfully canceled.";  // Return success message
        }

        // Retrieves appointments filtered by date, specialty, and medical problem
        public async Task<IEnumerable<Appointment>> GetFilteredAppointmentsAsync(AppointmentFilterDTO filter)
        {
            var query = _context.Appointments
                .Include(a => a.Doctor)  // Include the Doctor entity to access its properties like Specialty
                .AsQueryable();

            // Apply filter by appointment date (if provided)
            if (filter.AppointmentDate.HasValue)
            {
                query = query.Where(a => a.AppointmentDate.Date == filter.AppointmentDate.Value.Date);
            }

            // Apply filter by doctor's specialty (if provided)
            if (!string.IsNullOrEmpty(filter.Specialty))
            {
                query = query.Where(a => a.Doctor.Specialty.Contains(filter.Specialty, StringComparison.OrdinalIgnoreCase));
            }

            // Apply filter by medical problem (if provided)
            if (!string.IsNullOrEmpty(filter.MedicalProblem))
            {
                query = query.Where(a => a.MedicalProblem.Contains(filter.MedicalProblem, StringComparison.OrdinalIgnoreCase));
            }

            // Execute the query and return the filtered results
            return await query.ToListAsync();
        }

        // Asynchronously deletes a appointment by its ID.
        public async Task<(bool IsSuccess, string Message)> DeleteAppointmentAsync(int id)
        {
            var appointment = await _context.Appointments.FindAsync(id); // Find the appointment by ID.
            if (appointment == null)
            {
                return (false, "Appointment not found."); // Return failure if Appointment is not found.
            }

            // Remove the Appointment from the context and save changes to the database.
            _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();

            return (true, "Appointment deleted successfully."); // Return success result.
        }

    }
}