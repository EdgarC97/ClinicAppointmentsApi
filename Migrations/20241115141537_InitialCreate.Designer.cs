﻿// <auto-generated />
using System;
using ClinicAppointmentsApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClinicAppointmentsApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241115141537_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ClinicAppointmentsApi.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppointmentDate = new DateTime(2024, 5, 10, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7144),
                            DoctorId = 1,
                            PatientId = 1,
                            Status = 0,
                            UpdatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7145)
                        },
                        new
                        {
                            Id = 2,
                            AppointmentDate = new DateTime(2024, 5, 12, 14, 30, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7146),
                            DoctorId = 2,
                            PatientId = 2,
                            Status = 0,
                            UpdatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7147)
                        },
                        new
                        {
                            Id = 3,
                            AppointmentDate = new DateTime(2024, 5, 13, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7148),
                            DoctorId = 3,
                            PatientId = 3,
                            Status = 1,
                            UpdatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7148)
                        },
                        new
                        {
                            Id = 4,
                            AppointmentDate = new DateTime(2024, 5, 15, 11, 15, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7149),
                            DoctorId = 4,
                            PatientId = 4,
                            Status = 2,
                            UpdatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7150)
                        },
                        new
                        {
                            Id = 5,
                            AppointmentDate = new DateTime(2024, 5, 18, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7151),
                            DoctorId = 5,
                            PatientId = 5,
                            Status = 3,
                            UpdatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7152)
                        });
                });

            modelBuilder.Entity("ClinicAppointmentsApi.Models.Availability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AvailableDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time(6)");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time(6)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Avaliabilities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvailableDate = new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7210),
                            DoctorId = 1,
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            StartTime = new TimeSpan(0, 9, 0, 0, 0),
                            UpdatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7211)
                        },
                        new
                        {
                            Id = 2,
                            AvailableDate = new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7215),
                            DoctorId = 2,
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            StartTime = new TimeSpan(0, 14, 0, 0, 0),
                            UpdatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7215)
                        },
                        new
                        {
                            Id = 3,
                            AvailableDate = new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7219),
                            DoctorId = 3,
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            StartTime = new TimeSpan(0, 8, 0, 0, 0),
                            UpdatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7219)
                        },
                        new
                        {
                            Id = 4,
                            AvailableDate = new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7223),
                            DoctorId = 4,
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            StartTime = new TimeSpan(0, 9, 0, 0, 0),
                            UpdatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7223)
                        },
                        new
                        {
                            Id = 5,
                            AvailableDate = new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7227),
                            DoctorId = 5,
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            StartTime = new TimeSpan(0, 13, 0, 0, 0),
                            UpdatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7227)
                        });
                });

            modelBuilder.Entity("ClinicAppointmentsApi.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7053),
                            Name = "Dr. Smith",
                            Specialty = "Cardiology",
                            UpdatedAt = new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7085),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7087),
                            Name = "Dr. Johnson",
                            Specialty = "Orthopedics",
                            UpdatedAt = new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7088),
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7090),
                            Name = "Dr. Brown",
                            Specialty = "Neurology",
                            UpdatedAt = new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7090),
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7092),
                            Name = "Dr. Taylor",
                            Specialty = "Dermatology",
                            UpdatedAt = new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7093),
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7094),
                            Name = "Dr. Lee",
                            Specialty = "Pediatrics",
                            UpdatedAt = new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7095),
                            UserId = 5
                        });
                });

            modelBuilder.Entity("ClinicAppointmentsApi.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7117),
                            Email = "john_doe@example.com",
                            Name = "John Doe",
                            UpdatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7117),
                            UserId = 2
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7118),
                            Email = "jane_doe@example.com",
                            Name = "Jane Doe",
                            UpdatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7119),
                            UserId = 3
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7120),
                            Email = "mark_smith@example.com",
                            Name = "Mark Smith",
                            UpdatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7120),
                            UserId = 4
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7122),
                            Email = "emily_brown@example.com",
                            Name = "Emily Brown",
                            UpdatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7122),
                            UserId = 5
                        });
                });

            modelBuilder.Entity("ClinicAppointmentsApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6949),
                            Email = "admin@example.com",
                            Password = "admin123",
                            Role = 0,
                            UpdatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6950),
                            Username = "admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6952),
                            Email = "john_doe@example.com",
                            Password = "password123",
                            Role = 2,
                            UpdatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6952),
                            Username = "john_doe"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6953),
                            Email = "jane_doe@example.com",
                            Password = "password123",
                            Role = 2,
                            UpdatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6954),
                            Username = "jane_doe"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6955),
                            Email = "dr_smith@example.com",
                            Password = "doctor123",
                            Role = 1,
                            UpdatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6955),
                            Username = "dr_smith"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6956),
                            Email = "dr_jones@example.com",
                            Password = "doctor123",
                            Role = 1,
                            UpdatedAt = new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6956),
                            Username = "dr_jones"
                        });
                });

            modelBuilder.Entity("ClinicAppointmentsApi.Models.Doctor", b =>
                {
                    b.HasOne("ClinicAppointmentsApi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ClinicAppointmentsApi.Models.Patient", b =>
                {
                    b.HasOne("ClinicAppointmentsApi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
