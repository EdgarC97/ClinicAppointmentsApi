using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAppointmentsApi.Models
{

    public enum Role
    {
        Admin,
        Doctor,
        Patient
    }
    public class User
    {
        // Primary Key (auto-incremental by default)
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Unique username for each user
        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        // Password (stored as a hash, length will depend on your hash algorithm)
        [Required]
        [StringLength(200)]  // Typically passwords will have a hash length around 200
        public string Password { get; set; }

        // User role (Admin, Doctor, or Patient)
        [Required]
        public Role Role { get; set; }

        // Unique email for each user
        [Required]
        [EmailAddress]
        [StringLength(150)]
        public string Email { get; set; }

        // Timestamps
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}