using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAppointmentsApi.Migrations
{
    /// <inheritdoc />
    public partial class AddNotesToAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Avaliabilities",
                table: "Avaliabilities");

            migrationBuilder.RenameTable(
                name: "Avaliabilities",
                newName: "Availabilities");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Appointments",
                type: "varchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Availabilities",
                table: "Availabilities",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Notes", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7554), "Patient has had a fever for 3 days.", new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Notes", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7557), "Patient complains of sharp pain in the molars.", new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Notes", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7559), "Routine checkup, no major issues found.", new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Notes", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7561), "Patient canceled the appointment due to feeling better.", new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Notes", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7603), "Appointment rescheduled due to patient availability issues.", new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7677), new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7681), new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7686), new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7690), new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7694), new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 13, 1, 40, 702, DateTimeKind.Local).AddTicks(7462), new DateTime(2024, 11, 15, 13, 1, 40, 702, DateTimeKind.Local).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 13, 1, 40, 702, DateTimeKind.Local).AddTicks(7496), new DateTime(2024, 11, 15, 13, 1, 40, 702, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 13, 1, 40, 702, DateTimeKind.Local).AddTicks(7498), new DateTime(2024, 11, 15, 13, 1, 40, 702, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 13, 1, 40, 702, DateTimeKind.Local).AddTicks(7500), new DateTime(2024, 11, 15, 13, 1, 40, 702, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 13, 1, 40, 702, DateTimeKind.Local).AddTicks(7502), new DateTime(2024, 11, 15, 13, 1, 40, 702, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7526), new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7527), new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7528), new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7530), new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7356), new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7358), new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7360), new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7361), new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7362), new DateTime(2024, 11, 15, 18, 1, 40, 702, DateTimeKind.Utc).AddTicks(7363) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Availabilities",
                table: "Availabilities");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Appointments");

            migrationBuilder.RenameTable(
                name: "Availabilities",
                newName: "Avaliabilities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Avaliabilities",
                table: "Avaliabilities",
                column: "Id");

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
        }
    }
}
