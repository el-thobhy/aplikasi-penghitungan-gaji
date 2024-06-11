using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations
{
    /// <inheritdoc />
    public partial class configidpegawai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 20, 13, 52, 224, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 20, 13, 52, 224, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 20, 13, 52, 224, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 20, 13, 52, 224, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 20, 13, 52, 224, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 20, 13, 52, 224, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 20, 13, 52, 224, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 6, 10, 20, 13, 52, 224, DateTimeKind.Local).AddTicks(5784));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
