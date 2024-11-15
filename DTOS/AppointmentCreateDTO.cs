using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAppointmentsApi.DTOS
{
    public class AppointmentCreateDTO
    {
        // Doctor ID for the appointment
        [Required]
        public int DoctorId { get; set; }

        // Patient ID for the appointment
        [Required]
        public int PatientId { get; set; }

        // The scheduled date and time of the appointment
        [Required]
        public DateTime AppointmentDate { get; set; }
        
        // The medical problem or reason for the appointment
        [Required]
        public string MedicalProblem { get; set; }
    }
}