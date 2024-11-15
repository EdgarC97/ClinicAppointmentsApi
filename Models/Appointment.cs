using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAppointmentsApi.Models
{

    public enum AppointmentStatus
    {
        Scheduled,
        Completed,
        Canceled,
        Rescheduled
    }
    public class Appointment
    {
        // Primary Key (auto-incremental by default)
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Foreign Key to Patient table (Each Appointment is for a specific patient)
        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        // Foreign Key to Doctor table (Each Appointment is with a specific doctor)
        [Required]
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }

        // The date and time when the appointment is scheduled
        [Required]
        public DateTime AppointmentDate { get; set; }

        // Status of the appointment (Scheduled, Completed, Canceled, Rescheduled)
        [Required]
        public AppointmentStatus Status { get; set; }

        // Timestamps
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}