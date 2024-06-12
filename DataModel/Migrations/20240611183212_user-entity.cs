using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations
{
    /// <inheritdoc />
    public partial class userentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 1, 32, 12, 610, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 1, 32, 12, 610, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 1, 32, 12, 610, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 1, 32, 12, 610, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 1, 32, 12, 610, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 1, 32, 12, 610, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 1, 32, 12, 610, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Table_Status",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 1, 32, 12, 610, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

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
    }
}
