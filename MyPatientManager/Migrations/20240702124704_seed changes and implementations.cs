using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatientManager.Migrations
{
    /// <inheritdoc />
    public partial class seedchangesandimplementations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Adresses",
                columns: new[] { "Id", "Country", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { 3, "Austria", "457", "6800", "hard bodensee" });

            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "Id", "Name", "Producer" },
                values: new object[] { 3, "Hustensaft", "Pfizer Inc." });

            migrationBuilder.UpdateData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 14, 47, 3, 659, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 14, 47, 3, 659, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Pw",
                value: "$2a$11$eI6pQ90TUtrNVmaf4z0GVOSPceWAIEglQ81VFJA8tAqOReIwfu.lW");

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressId", "BirthDate", "Email", "FName", "IsUser", "LName", "Phone", "SVN", "TreatmentId" },
                values: new object[] { 3, 3, new DateTime(2003, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "musti.oe@hotmail.com", "Mustafa", false, "Öztürk", "0668494979", "1231314134", 0 });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "Id", "Amount", "MedicationId", "TreatmentId" },
                values: new object[] { 3, 500, 3, 1 });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "CreatedAt", "Notes", "PersonId" },
                values: new object[] { 3, new DateTime(2024, 7, 2, 14, 47, 3, 659, DateTimeKind.Local).AddTicks(8747), "Erkältung", 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Adresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 14, 11, 1, 724, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 14, 11, 1, 724, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Pw",
                value: "$2a$11$LDT.Y..iKXDEHrfFFwx8rOFk3LGfKGxgcQGxDu2JwwhEYUTnc/2aO");
        }
    }
}
