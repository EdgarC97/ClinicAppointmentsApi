using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicAppointmentsApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Avaliabilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    AvailableDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time(6)", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time(6)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliabilities", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Specialty = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentDate", "CreatedAt", "DoctorId", "PatientId", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7144), 1, 1, 0, new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7145) },
                    { 2, new DateTime(2024, 5, 12, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7146), 2, 2, 0, new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7147) },
                    { 3, new DateTime(2024, 5, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7148), 3, 3, 1, new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7148) },
                    { 4, new DateTime(2024, 5, 15, 11, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7149), 4, 4, 2, new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7150) },
                    { 5, new DateTime(2024, 5, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7151), 5, 5, 3, new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7152) }
                });

            migrationBuilder.InsertData(
                table: "Avaliabilities",
                columns: new[] { "Id", "AvailableDate", "CreatedAt", "DoctorId", "EndTime", "StartTime", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7210), 1, new TimeSpan(0, 12, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7211) },
                    { 2, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7215), 2, new TimeSpan(0, 18, 0, 0, 0), new TimeSpan(0, 14, 0, 0, 0), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7215) },
                    { 3, new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7219), 3, new TimeSpan(0, 12, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7219) },
                    { 4, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7223), 4, new TimeSpan(0, 12, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7223) },
                    { 5, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7227), 5, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 13, 0, 0, 0), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7227) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Password", "Role", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6949), "admin@example.com", "admin123", 0, new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6950), "admin" },
                    { 2, new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6952), "john_doe@example.com", "password123", 2, new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6952), "john_doe" },
                    { 3, new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6953), "jane_doe@example.com", "password123", 2, new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6954), "jane_doe" },
                    { 4, new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6955), "dr_smith@example.com", "doctor123", 1, new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6955), "dr_smith" },
                    { 5, new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6956), "dr_jones@example.com", "doctor123", 1, new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6956), "dr_jones" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "CreatedAt", "Name", "Specialty", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7053), "Dr. Smith", "Cardiology", new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7085), 1 },
                    { 2, new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7087), "Dr. Johnson", "Orthopedics", new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7088), 2 },
                    { 3, new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7090), "Dr. Brown", "Neurology", new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7090), 3 },
                    { 4, new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7092), "Dr. Taylor", "Dermatology", new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7093), 4 },
                    { 5, new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7094), "Dr. Lee", "Pediatrics", new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7095), 5 }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7117), "john_doe@example.com", "John Doe", new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7117), 2 },
                    { 2, new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7118), "jane_doe@example.com", "Jane Doe", new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7119), 3 },
                    { 3, new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7120), "mark_smith@example.com", "Mark Smith", new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7120), 4 },
                    { 4, new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7122), "emily_brown@example.com", "Emily Brown", new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7122), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_UserId",
                table: "Patients",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Avaliabilities");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
