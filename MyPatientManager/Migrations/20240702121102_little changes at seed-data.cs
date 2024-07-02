using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatientManager.Migrations
{
    /// <inheritdoc />
    public partial class littlechangesatseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 14, 11, 1, 724, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "CreatedAt", "Notes", "PersonId" },
                values: new object[] { 2, new DateTime(2024, 7, 2, 14, 11, 1, 724, DateTimeKind.Local).AddTicks(4144), "Anschlag auf Kopf", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Pw",
                value: "$2a$11$LDT.Y..iKXDEHrfFFwx8rOFk3LGfKGxgcQGxDu2JwwhEYUTnc/2aO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 13, 54, 13, 263, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Pw",
                value: "$2a$11$d9Mbyf/si0k1TVZ1d71mD.wXd5j/RP2RAwxynJ8vEn1c3P3XlgWeq");
        }
    }
}
