using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class TableStatus: BaseProperties
    {
        public int Id { get; set; }
        public string JenisStatus { get; set; }
        public string Deskripsi { get; set; }
        public double NilaiTunjangan { get; set; }
    }
    public class TableStatusConfiguration : IEntityTypeConfiguration<TableStatus>
    {
        public void Configure(EntityTypeBuilder<TableStatus> builder)
        {
            builder.ToTable("Table_Status");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.JenisStatus).IsRequired();
            builder.Property(x => x.JenisStatus).HasMaxLength(2);

            builder.Property(x => x.Deskripsi).IsRequired();
            builder.Property(x => x.Deskripsi).HasMaxLength(255);

            builder.Property(e => e.NilaiTunjangan).IsRequired();
            builder.Property(e => e.NilaiTunjangan).HasPrecision(10, 0);

            builder.Seed();
        }
    }

    public static class TableStatusBuilderExtension
    {
        public static void Seed(this EntityTypeBuilder<TableStatus> builder) 
        {
            builder.HasData(
                new TableStatus
                {
                    Id = 1,
                    JenisStatus = "T0",
                    Deskripsi = "Tidak kawin tanggungan 0",
                    NilaiTunjangan = 300000,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now,
                },
                new TableStatus
                {
                    Id = 2,
                    JenisStatus = "T1",
                    Deskripsi = "Tidak kawin tanggungan 1",
                    NilaiTunjangan = 400000,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now,
                },
                new TableStatus
                {
                    Id = 3,
                    JenisStatus = "T2",
                    Deskripsi = "Tidak kawin tanggungan 2",
                    NilaiTunjangan = 500000,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now,
                },
                new TableStatus
                {
                    Id = 4,
                    JenisStatus = "T3",
                    Deskripsi = "Tidak kawin tanggungan 3",
                    NilaiTunjangan = 600000,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now,
                },
                new TableStatus
                {
                    Id = 5,
                    JenisStatus = "K0",
                    Deskripsi = "Kawin tanggungan 0",
                    NilaiTunjangan = 400000,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now,
                },
                new TableStatus
                {
                    Id = 6,
                    JenisStatus = "K1",
                    Deskripsi = "Kawin tanggungan 1",
                    NilaiTunjangan = 500000,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now,
                },
                new TableStatus
                {
                    Id = 7,
                    JenisStatus = "K2",
                    Deskripsi = "Kawin tanggungan 2",
                    NilaiTunjangan = 600000,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now,
                },
                new TableStatus
                {
                    Id = 8,
                    JenisStatus = "K2",
                    Deskripsi = "Kawin tanggungan 2",
                    NilaiTunjangan = 700000,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now,
                }
                );
        }
    }
}
