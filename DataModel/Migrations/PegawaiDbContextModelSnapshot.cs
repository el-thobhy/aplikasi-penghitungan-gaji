﻿// <auto-generated />
using System;
using DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataModel.Migrations
{
    [DbContext(typeof(PegawaiDbContext))]
    partial class PegawaiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataModel.TableLembur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("DokumenLembur")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("IdPegawai")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("JumlahLembur")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomerPegawai")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)");

                    b.Property<string>("Tanggal")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("IdPegawai");

                    b.ToTable("Table_Lembur", (string)null);
                });

            modelBuilder.Entity("DataModel.TablePegawai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("GajiPokok")
                        .HasPrecision(10)
                        .HasColumnType("float(10)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("JenisKelamin")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NamaPegawai")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("NilaiTunjangan")
                        .HasPrecision(10)
                        .HasColumnType("float(10)");

                    b.Property<string>("NomerPegawai")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("TanggalMasuk")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<double?>("UangLembur")
                        .HasPrecision(10)
                        .HasColumnType("float(10)");

                    b.Property<double>("UangMakan")
                        .HasPrecision(10)
                        .HasColumnType("float(10)");

                    b.Property<double>("UangTransport")
                        .HasPrecision(10)
                        .HasColumnType("float(10)");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.ToTable("Table_Pegawai", (string)null);
                });

            modelBuilder.Entity("DataModel.TableStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Deskripsi")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("JenisStatus")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("NilaiTunjangan")
                        .HasPrecision(10)
                        .HasColumnType("float(10)");

                    b.HasKey("Id");

                    b.ToTable("Table_Status", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 6, 12, 1, 32, 12, 610, DateTimeKind.Local).AddTicks(6349),
                            Deskripsi = "Tidak kawin tanggungan 0",
                            IsDeleted = false,
                            JenisStatus = "T0",
                            NilaiTunjangan = 300000.0
                        },
                        new
                        {
                            Id = 2,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 6, 12, 1, 32, 12, 610, DateTimeKind.Local).AddTicks(6361),
                            Deskripsi = "Tidak kawin tanggungan 1",
                            IsDeleted = false,
                            JenisStatus = "T1",
                            NilaiTunjangan = 400000.0
                        },
                        new
                        {
                            Id = 3,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 6, 12, 1, 32, 12, 610, DateTimeKind.Local).AddTicks(6363),
                            Deskripsi = "Tidak kawin tanggungan 2",
                            IsDeleted = false,
                            JenisStatus = "T2",
                            NilaiTunjangan = 500000.0
                        },
                        new
                        {
                            Id = 4,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 6, 12, 1, 32, 12, 610, DateTimeKind.Local).AddTicks(6364),
                            Deskripsi = "Tidak kawin tanggungan 3",
                            IsDeleted = false,
                            JenisStatus = "T3",
                            NilaiTunjangan = 600000.0
                        },
                        new
                        {
                            Id = 5,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 6, 12, 1, 32, 12, 610, DateTimeKind.Local).AddTicks(6412),
                            Deskripsi = "Kawin tanggungan 0",
                            IsDeleted = false,
                            JenisStatus = "K0",
                            NilaiTunjangan = 400000.0
                        },
                        new
                        {
                            Id = 6,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 6, 12, 1, 32, 12, 610, DateTimeKind.Local).AddTicks(6414),
                            Deskripsi = "Kawin tanggungan 1",
                            IsDeleted = false,
                            JenisStatus = "K1",
                            NilaiTunjangan = 500000.0
                        },
                        new
                        {
                            Id = 7,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 6, 12, 1, 32, 12, 610, DateTimeKind.Local).AddTicks(6415),
                            Deskripsi = "Kawin tanggungan 2",
                            IsDeleted = false,
                            JenisStatus = "K2",
                            NilaiTunjangan = 600000.0
                        },
                        new
                        {
                            Id = 8,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 6, 12, 1, 32, 12, 610, DateTimeKind.Local).AddTicks(6417),
                            Deskripsi = "Kawin tanggungan 2",
                            IsDeleted = false,
                            JenisStatus = "K2",
                            NilaiTunjangan = 700000.0
                        });
                });

            modelBuilder.Entity("DataModel.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("DataModel.TableLembur", b =>
                {
                    b.HasOne("DataModel.TablePegawai", "DataPegawai")
                        .WithMany()
                        .HasForeignKey("IdPegawai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DataPegawai");
                });

            modelBuilder.Entity("DataModel.TablePegawai", b =>
                {
                    b.HasOne("DataModel.TableStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");
                });
#pragma warning restore 612, 618
        }
    }
}
