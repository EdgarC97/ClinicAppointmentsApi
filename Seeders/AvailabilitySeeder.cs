using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicAppointmentsApi.Data;
using ClinicAppointmentsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicAppointmentsApi.Seeders
{
    public static class AvailabilitySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Availability>().HasData(
                new Availability { Id = 1, DoctorId = 1, AvailableDate = new DateTime(2024, 5, 10).Date, StartTime = TimeSpan.Parse("09:00"), EndTime = TimeSpan.Parse("12:00"), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Availability { Id = 2, DoctorId = 2, AvailableDate = new DateTime(2024, 5, 12).Date, StartTime = TimeSpan.Parse("14:00"), EndTime = TimeSpan.Parse("18:00"), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Availability { Id = 3, DoctorId = 3, AvailableDate = new DateTime(2024, 5, 13).Date, StartTime = TimeSpan.Parse("08:00"), EndTime = TimeSpan.Parse("12:00"), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Availability { Id = 4, DoctorId = 4, AvailableDate = new DateTime(2024, 5, 15).Date, StartTime = TimeSpan.Parse("09:00"), EndTime = TimeSpan.Parse("12:00"), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Availability { Id = 5, DoctorId = 5, AvailableDate = new DateTime(2024, 5, 18).Date, StartTime = TimeSpan.Parse("13:00"), EndTime = TimeSpan.Parse("17:00"), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
        }
    }
}