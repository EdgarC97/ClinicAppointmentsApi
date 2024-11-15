using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAppointmentsApi.Interfaces
{
    // Interface to manage doctor availability related operations
    public interface IDoctorAvailabilityService
    {
        // Method to set a doctor's availability for a specific date and time range
        Task<string> SetDoctorAvailabilityAsync(int doctorId, DateTime availableDate, TimeSpan startTime, TimeSpan endTime);

        // Method to update an existing doctor's availability
        Task<string> UpdateDoctorAvailabilityAsync(int availabilityId, DateTime availableDate, TimeSpan startTime, TimeSpan endTime);
    }
}