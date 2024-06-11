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
    public class TableLembur: BaseProperties
    {
        public int Id { get; set; }
        public byte[]? DokumenLembur { get; set; }
        public string Tanggal { get; set; }
        public string NomerPegawai { get; set; }
        public int IdPegawai { get; set; }
        public int JumlahLembur { get; set; }

        [ForeignKey("IdPegawai")]
        public virtual TablePegawai DataPegawai { get; set; }

    }
    public class TableLemburConfiguration : IEntityTypeConfiguration<TableLembur>
    {
        public void Configure(EntityTypeBuilder<TableLembur> builder)
        {
            builder.ToTable("Table_Lembur");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.DokumenLembur).IsRequired(false);
            builder.Property(x => x.DokumenLembur).HasColumnType("varbinary(max)");

            builder.Property(x => x.IdPegawai).IsRequired();

            builder.Property(x => x.Tanggal).IsRequired();
            builder.Property(x => x.Tanggal).HasMaxLength(10);

            builder.Property(x => x.NomerPegawai).IsRequired();
            builder.Property(x => x.NomerPegawai).HasMaxLength(18);

        }
    }
}
