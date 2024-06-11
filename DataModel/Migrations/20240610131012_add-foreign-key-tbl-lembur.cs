using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations
{
    /// <inheritdoc />
    public partial class addforeignkeytbllembur : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPegawai",
                table: "Table_Lembur",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 20, 10, 12, 93, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 20, 10, 12, 93, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 20, 10, 12, 93, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 20, 10, 12, 93, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 20, 10, 12, 93, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 20, 10, 12, 93, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 20, 10, 12, 93, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 20, 10, 12, 93, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.CreateIndex(
                name: "IX_Table_Lembur_IdPegawai",
                table: "Table_Lembur",
                column: "IdPegawai");

            migrationBuilder.AddForeignKey(
                name: "FK_Table_Lembur_Table_Pegawai_IdPegawai",
                table: "Table_Lembur",
                column: "IdPegawai",
                principalTable: "Table_Pegawai",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Table_Lembur_Table_Pegawai_IdPegawai",
                table: "Table_Lembur");

            migrationBuilder.DropIndex(
                name: "IX_Table_Lembur_IdPegawai",
                table: "Table_Lembur");

            migrationBuilder.DropColumn(
                name: "IdPegawai",
                table: "Table_Lembur");

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 19, 47, 0, 328, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 19, 47, 0, 328, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 19, 47, 0, 328, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 19, 47, 0, 328, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 19, 47, 0, 328, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 19, 47, 0, 328, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 19, 47, 0, 328, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 19, 47, 0, 328, DateTimeKind.Local).AddTicks(125));
        }
    }
}
