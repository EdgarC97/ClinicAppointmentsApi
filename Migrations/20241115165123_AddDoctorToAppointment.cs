using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAppointmentsApi.Migrations
{
    /// <inheritdoc />
    public partial class AddDoctorToAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3058), new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3060), new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3061), new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3063), new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3064), new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "Avaliabilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3126), new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "Avaliabilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3131), new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "Avaliabilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3135), new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "Avaliabilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3139), new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "Avaliabilities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3143), new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 51, 23, 520, DateTimeKind.Local).AddTicks(2971), new DateTime(2024, 11, 15, 11, 51, 23, 520, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 51, 23, 520, DateTimeKind.Local).AddTicks(3000), new DateTime(2024, 11, 15, 11, 51, 23, 520, DateTimeKind.Local).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 51, 23, 520, DateTimeKind.Local).AddTicks(3003), new DateTime(2024, 11, 15, 11, 51, 23, 520, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 51, 23, 520, DateTimeKind.Local).AddTicks(3005), new DateTime(2024, 11, 15, 11, 51, 23, 520, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 51, 23, 520, DateTimeKind.Local).AddTicks(3007), new DateTime(2024, 11, 15, 11, 51, 23, 520, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3031), new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3033), new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3034), new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3036), new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(2870), new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(2872), new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(2874), new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(2875), new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(2877), new DateTime(2024, 11, 15, 16, 51, 23, 520, DateTimeKind.Utc).AddTicks(2877) });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Doctors_DoctorId",
                table: "Appointments",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Doctors_DoctorId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6511), new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6513), new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6515), new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6515) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6516), new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6518), new DateTime(2024, 11, 15, 16, 8, 31, 45, DateTimeKind.Utc).AddTicks(6518) });

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
    }
}
