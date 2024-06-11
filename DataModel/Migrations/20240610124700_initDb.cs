using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataModel.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Table_Lembur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DokumenLembur = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Tanggal = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NomerPegawai = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    JumlahLembur = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Table_Lembur", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table_Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JenisStatus = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Deskripsi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NilaiTunjangan = table.Column<double>(type: "float(10)", precision: 10, scale: 0, nullable: false),
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
                    table.PrimaryKey("PK_Table_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table_Pegawai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomerPegawai = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    NamaPegawai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TanggalMasuk = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    JenisKelamin = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    GajiPokok = table.Column<double>(type: "float(10)", precision: 10, scale: 0, nullable: false),
                    UangMakan = table.Column<double>(type: "float(10)", precision: 10, scale: 0, nullable: false),
                    UangTransport = table.Column<double>(type: "float(10)", precision: 10, scale: 0, nullable: false),
                    UangLembur = table.Column<double>(type: "float(10)", precision: 10, scale: 0, nullable: true),
                    NilaiTunjangan = table.Column<double>(type: "float(10)", precision: 10, scale: 0, nullable: true),
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
                    table.PrimaryKey("PK_Table_Pegawai", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Table_Pegawai_Table_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Table_Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Table_Status",
                columns: new[] { "Id", "CreateBy", "CreateDate", "DeletedBy", "DeletedDate", "Deskripsi", "IsDeleted", "JenisStatus", "ModifiedBy", "ModifiedDate", "NilaiTunjangan" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2024, 6, 10, 19, 47, 0, 328, DateTimeKind.Local).AddTicks(100), null, null, "Tidak kawin tanggungan 0", false, "T0", null, null, 300000.0 },
                    { 2, "admin", new DateTime(2024, 6, 10, 19, 47, 0, 328, DateTimeKind.Local).AddTicks(116), null, null, "Tidak kawin tanggungan 1", false, "T1", null, null, 400000.0 },
                    { 3, "admin", new DateTime(2024, 6, 10, 19, 47, 0, 328, DateTimeKind.Local).AddTicks(117), null, null, "Tidak kawin tanggungan 2", false, "T2", null, null, 500000.0 },
                    { 4, "admin", new DateTime(2024, 6, 10, 19, 47, 0, 328, DateTimeKind.Local).AddTicks(119), null, null, "Tidak kawin tanggungan 3", false, "T3", null, null, 600000.0 },
                    { 5, "admin", new DateTime(2024, 6, 10, 19, 47, 0, 328, DateTimeKind.Local).AddTicks(121), null, null, "Kawin tanggungan 0", false, "K0", null, null, 400000.0 },
                    { 6, "admin", new DateTime(2024, 6, 10, 19, 47, 0, 328, DateTimeKind.Local).AddTicks(122), null, null, "Kawin tanggungan 1", false, "K1", null, null, 500000.0 },
                    { 7, "admin", new DateTime(2024, 6, 10, 19, 47, 0, 328, DateTimeKind.Local).AddTicks(124), null, null, "Kawin tanggungan 2", false, "K2", null, null, 600000.0 },
                    { 8, "admin", new DateTime(2024, 6, 10, 19, 47, 0, 328, DateTimeKind.Local).AddTicks(125), null, null, "Kawin tanggungan 2", false, "K2", null, null, 700000.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Table_Pegawai_StatusId",
                table: "Table_Pegawai",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Table_Lembur");

            migrationBuilder.DropTable(
                name: "Table_Pegawai");

            migrationBuilder.DropTable(
                name: "Table_Status");
        }
    }
}
