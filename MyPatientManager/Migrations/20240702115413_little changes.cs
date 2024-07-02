using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatientManager.Migrations
{
    /// <inheritdoc />
    public partial class littlechanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Medications_MedicationId",
                table: "Prescription");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Treatments_TreatmentId",
                table: "Prescription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prescription",
                table: "Prescription");

            migrationBuilder.RenameTable(
                name: "Prescription",
                newName: "Prescriptions");

            migrationBuilder.RenameIndex(
                name: "IX_Prescription_TreatmentId",
                table: "Prescriptions",
                newName: "IX_Prescriptions_TreatmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Prescription_MedicationId",
                table: "Prescriptions",
                newName: "IX_Prescriptions_MedicationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prescriptions",
                table: "Prescriptions",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Medications_MedicationId",
                table: "Prescriptions",
                column: "MedicationId",
                principalTable: "Medications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Treatments_TreatmentId",
                table: "Prescriptions",
                column: "TreatmentId",
                principalTable: "Treatments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Medications_MedicationId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Treatments_TreatmentId",
                table: "Prescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prescriptions",
                table: "Prescriptions");

            migrationBuilder.RenameTable(
                name: "Prescriptions",
                newName: "Prescription");

            migrationBuilder.RenameIndex(
                name: "IX_Prescriptions_TreatmentId",
                table: "Prescription",
                newName: "IX_Prescription_TreatmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Prescriptions_MedicationId",
                table: "Prescription",
                newName: "IX_Prescription_MedicationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prescription",
                table: "Prescription",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 13, 51, 55, 32, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Pw",
                value: "$2a$11$UAY4OhBMy08BNfxj7ZQEi.Kq.TAsn3x/QoR/78hPidX.XZprK9PIW");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Medications_MedicationId",
                table: "Prescription",
                column: "MedicationId",
                principalTable: "Medications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Treatments_TreatmentId",
                table: "Prescription",
                column: "TreatmentId",
                principalTable: "Treatments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
