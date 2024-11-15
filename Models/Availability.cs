using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAppointmentsApi.Models
{
    public class Availability
    {
        // Primary Key (auto-incremental by default)
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Foreign Key to Doctor table (Each Availability belongs to a specific doctor)
        [Required]
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }

        // Date when the doctor is available
        [Required]
        public DateTime AvailableDate { get; set; }

        // Start time of availability
        [Required]
        public TimeSpan StartTime { get; set; }

        // End time of availability
        [Required]
        public TimeSpan EndTime { get; set; }

        // Timestamps
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}