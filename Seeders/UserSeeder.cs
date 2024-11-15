using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicAppointmentsApi.Data;
using ClinicAppointmentsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicAppointmentsApi.Seeders
{
    public static class UserSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "admin", Password = "admin123", Role = Role.Admin, Email = "admin@example.com", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new User { Id = 2, Username = "john_doe", Password = "password123", Role = Role.Patient, Email = "john_doe@example.com", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new User { Id = 3, Username = "jane_doe", Password = "password123", Role = Role.Patient, Email = "jane_doe@example.com", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new User { Id = 4, Username = "dr_smith", Password = "doctor123", Role = Role.Doctor, Email = "dr_smith@example.com", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new User { Id = 5, Username = "dr_jones", Password = "doctor123", Role = Role.Doctor, Email = "dr_jones@example.com", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
        }
    }
}