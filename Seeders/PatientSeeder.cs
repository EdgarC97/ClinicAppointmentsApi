using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicAppointmentsApi.Data;
using ClinicAppointmentsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicAppointmentsApi.Seeders
{
    public static class PatientSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasData(
                new Patient { Id = 1, UserId = 2, Name = "John Doe", Email = "john_doe@example.com", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Patient { Id = 2, UserId = 3, Name = "Jane Doe", Email = "jane_doe@example.com", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Patient { Id = 3, UserId = 4, Name = "Mark Smith", Email = "mark_smith@example.com", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Patient { Id = 4, UserId = 5, Name = "Emily Brown", Email = "emily_brown@example.com", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
        }
    }
}