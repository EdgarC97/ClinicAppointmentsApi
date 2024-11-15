using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicAppointmentsApi.Data;
using ClinicAppointmentsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicAppointmentsApi.Seeders
{
    public static class DoctorSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { Id = 1, Name = "Dr. Smith", Specialty = "Cardiology", UserId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Doctor { Id = 2, Name = "Dr. Johnson", Specialty = "Orthopedics", UserId = 2, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Doctor { Id = 3, Name = "Dr. Brown", Specialty = "Neurology", UserId = 3, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Doctor { Id = 4, Name = "Dr. Taylor", Specialty = "Dermatology", UserId = 4, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Doctor { Id = 5, Name = "Dr. Lee", Specialty = "Pediatrics", UserId = 5, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );
        }
    }
}