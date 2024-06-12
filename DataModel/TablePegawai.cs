using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class TablePegawai: BaseProperties
    {
        public int Id { get; set; }
        public string NomerPegawai { get; set; }
        public string NamaPegawai { get; set; }
        public string TanggalMasuk { get; set; }
        public Gender JenisKelamin { get; set; }
        public int StatusId { get; set; }
        public double GajiPokok { get; set; }
        public double UangMakan { get; set; }
        public double UangTransport { get; set; }
        public double? UangLembur { get; set; }
        public double? NilaiTunjangan { get; set; }

        [ForeignKey("StatusId")]
        public virtual TableStatus Status { get; set; }
    }
    public class TablePegawaiConfiguration : IEntityTypeConfiguration<TablePegawai>
    {
        public void Configure(EntityTypeBuilder<TablePegawai> builder)
        {
            builder.ToTable("Table_Pegawai");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.NomerPegawai).IsRequired();
            builder.Property(x => x.NomerPegawai).HasMaxLength(18);

            builder.Property(x => x.NamaPegawai).IsRequired();
            builder.Property(x => x.NamaPegawai).HasMaxLength(50);

            builder.Property(x => x.TanggalMasuk).IsRequired();
            builder.Property(x => x.TanggalMasuk).HasMaxLength(10);
            
            builder.Property(x => x.JenisKelamin).IsRequired();

            builder.Property(x => x.StatusId).IsRequired();

            builder.Property(x => x.GajiPokok).IsRequired();
            builder.Property(x => x.GajiPokok).HasPrecision(10, 0);

            builder.Property(x => x.UangMakan).IsRequired();
            builder.Property(x => x.UangMakan).HasPrecision(10, 0);

            builder.Property(x => x.UangTransport).IsRequired();
            builder.Property(x => x.UangTransport).HasPrecision(10, 0);

            builder.Property(x => x.UangLembur).IsRequired(false);
            builder.Property(x => x.UangLembur).HasPrecision(10, 0);

            builder.Property(x => x.NilaiTunjangan).IsRequired(false);
            builder.Property(x => x.NilaiTunjangan).HasPrecision(10, 0);
        }
    }
}
