using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicAppointmentsApi.Data;
using ClinicAppointmentsApi.Interfaces;
using ClinicAppointmentsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicAppointmentsApi.Services
{
    // Service to handle doctor availability logic
    public class DoctorAvailabilityService : IDoctorAvailabilityService
    {
        private readonly AppDbContext _context;

        public DoctorAvailabilityService(AppDbContext context)
        {
            _context = context;
        }

        // Method to set a doctor's availability for a specific date and time range
        public async Task<string> SetDoctorAvailabilityAsync(int doctorId, DateTime availableDate, TimeSpan startTime, TimeSpan endTime)
        {
            // Check if the doctor already has availability for that date
            var existingAvailability = await _context.Availabilities
                .Where(a => a.DoctorId == doctorId && a.AvailableDate == availableDate)
                .AnyAsync();

            if (existingAvailability)
            {
                return "The doctor is already available on this date. Please choose another date.";
            }

            // Create new availability entry
            var availability = new Availability
            {
                DoctorId = doctorId,
                AvailableDate = availableDate,
                StartTime = startTime,
                EndTime = endTime,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            // Add the new availability to the database
            _context.Availabilities.Add(availability);
            await _context.SaveChangesAsync();

            return "Doctor's availability successfully set.";  // Return success message
        }

        // Method to update an existing doctor's availability
        public async Task<string> UpdateDoctorAvailabilityAsync(int availabilityId, DateTime availableDate, TimeSpan startTime, TimeSpan endTime)
        {
            // Find the availability record by its ID
            var availability = await _context.Availabilities.FindAsync(availabilityId);

            if (availability == null)
            {
                return "Availability not found."; // Return an error message if the availability is not found
            }

            // Update the availability details
            availability.AvailableDate = availableDate;
            availability.StartTime = startTime;
            availability.EndTime = endTime;
            availability.UpdatedAt = DateTime.UtcNow;

            // Save the changes
            await _context.SaveChangesAsync();

            return "Doctor's availability successfully updated.";  // Return success message
        }
    }
}