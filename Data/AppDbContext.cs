using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicAppointmentsApi.Models;
using ClinicAppointmentsApi.Seeders;
using Microsoft.EntityFrameworkCore;

namespace ClinicAppointmentsApi.Data
{
    // DbContext class representing the database context for the Hotel API.
    public class AppDbContext : DbContext
    {
        // Constructor that accepts DbContextOptions for configuring the context.
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSet properties for each entity in the database.
        public DbSet<User> Users { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Availability> Avaliabilities { get; set; }

        // Method called when the model for a derived context is being created.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed the database with initial data for RoomTypes, Rooms, Guests, Employees, and Bookings.
            UserSeeder.Seed(modelBuilder);
            DoctorSeeder.Seed(modelBuilder);
            PatientSeeder.Seed(modelBuilder);
            AppointmentSeeder.Seed(modelBuilder);
            AvailabilitySeeder.Seed(modelBuilder);

            // Call the base class implementation.
            base.OnModelCreating(modelBuilder);
        }
    }
}