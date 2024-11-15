using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAppointmentsApi.Migrations
{
    /// <inheritdoc />
    public partial class AddMedicalProblemToAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MedicalProblem",
                table: "Appointments",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "MedicalProblem", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6511), "Flu", new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "MedicalProblem", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6513), "Dental Pain", new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "MedicalProblem", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6515), "Checkup", new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6515) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "MedicalProblem", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6516), "Back Pain", new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "MedicalProblem", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6518), "Migraine", new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "Avaliabilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6580), new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "Avaliabilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6585), new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6586) });

            migrationBuilder.UpdateData(
                table: "Avaliabilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6590), new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Avaliabilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6594), new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "Avaliabilities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6598), new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 8, 31, 45, DateTimeKind.Local).AddTicks(6426), new DateTime(2024, 11, 15, 11, 8, 31, 45, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 8, 31, 45, DateTimeKind.Local).AddTicks(6459), new DateTime(2024, 11, 15, 11, 8, 31, 45, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 8, 31, 45, DateTimeKind.Local).AddTicks(6462), new DateTime(2024, 11, 15, 11, 8, 31, 45, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 8, 31, 45, DateTimeKind.Local).AddTicks(6464), new DateTime(2024, 11, 15, 11, 8, 31, 45, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 8, 31, 45, DateTimeKind.Local).AddTicks(6465), new DateTime(2024, 11, 15, 11, 8, 31, 45, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6487), new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6489), new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6490), new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6491), new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6318), new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6319), new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6321), new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6322), new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6324), new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6324) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MedicalProblem",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7144), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7146), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7148), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7149), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7151), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Avaliabilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7210), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "Avaliabilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7215), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "Avaliabilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7219), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Avaliabilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7223), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "Avaliabilities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7227), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7053), new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7087), new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7090), new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7092), new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7094), new DateTime(2024, 11, 15, 9, 15, 36, 763, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7117), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7118), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7120), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7122), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6949), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6952), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6953), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6955), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6955) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6956), new DateTime(2024, 11, 15, 14, 15, 36, 763, DateTimeKind.Utc).AddTicks(6956) });
        }
    }
}
