using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicAppointmentsApi.Data;
using ClinicAppointmentsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicAppointmentsApi.Seeders
{
    public static class AppointmentSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment { Id = 1, PatientId = 1, DoctorId = 1, AppointmentDate = new DateTime(2024, 5, 10, 9, 0, 0), Status = AppointmentStatus.Scheduled, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Appointment { Id = 2, PatientId = 2, DoctorId = 2, AppointmentDate = new DateTime(2024, 5, 12, 14, 30, 0), Status = AppointmentStatus.Scheduled, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Appointment { Id = 3, PatientId = 3, DoctorId = 3, AppointmentDate = new DateTime(2024, 5, 13, 10, 0, 0), Status = AppointmentStatus.Completed, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Appointment { Id = 4, PatientId = 4, DoctorId = 4, AppointmentDate = new DateTime(2024, 5, 15, 11, 15, 0), Status = AppointmentStatus.Canceled, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Appointment { Id = 5, PatientId = 5, DoctorId = 5, AppointmentDate = new DateTime(2024, 5, 18, 16, 0, 0), Status = AppointmentStatus.Rescheduled, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
        }
    }
}