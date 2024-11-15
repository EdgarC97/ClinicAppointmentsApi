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
                new Appointment
                {
                    Id = 1,
                    PatientId = 1,
                    DoctorId = 1,
                    AppointmentDate = new DateTime(2024, 5, 10, 9, 0, 0),
                    Status = AppointmentStatus.Scheduled,
                    MedicalProblem = "Flu",
                    Notes = "Patient has had a fever for 3 days.",  
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Appointment
                {
                    Id = 2,
                    PatientId = 2,
                    DoctorId = 2,
                    AppointmentDate = new DateTime(2024, 5, 12, 14, 30, 0),
                    Status = AppointmentStatus.Scheduled,
                    MedicalProblem = "Dental Pain",
                    Notes = "Patient complains of sharp pain in the molars.",  
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Appointment
                {
                    Id = 3,
                    PatientId = 3,
                    DoctorId = 3,
                    AppointmentDate = new DateTime(2024, 5, 13, 10, 0, 0),
                    Status = AppointmentStatus.Completed,
                    MedicalProblem = "Checkup",
                    Notes = "Routine checkup, no major issues found.",  
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Appointment
                {
                    Id = 4,
                    PatientId = 4,
                    DoctorId = 4,
                    AppointmentDate = new DateTime(2024, 5, 15, 11, 15, 0),
                    Status = AppointmentStatus.Canceled,
                    MedicalProblem = "Back Pain",
                    Notes = "Patient canceled the appointment due to feeling better.",  
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Appointment
                {
                    Id = 5,
                    PatientId = 5,
                    DoctorId = 5,
                    AppointmentDate = new DateTime(2024, 5, 18, 16, 0, 0),
                    Status = AppointmentStatus.Rescheduled,
                    MedicalProblem = "Migraine",
                    Notes = "Appointment rescheduled due to patient availability issues.",  
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            );
        }
    }
}