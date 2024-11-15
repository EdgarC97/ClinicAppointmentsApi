using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAppointmentsApi.Models
{
    public class Patient
    {
        // Primary Key (auto-incremental by default)
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Foreign Key to User table (Each Patient is a User)
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

        // Navigation property to the associated User object (Patient is a User)
        public User User { get; set; }

        // Patient's name
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        // Patient's email address
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // Timestamps
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}