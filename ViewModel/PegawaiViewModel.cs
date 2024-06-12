using DataModel;

namespace ViewModel
{
    public class PegawaiViewModel
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
    }

    public class ReturnPegawaiViewModel: PegawaiViewModel
    {
        public string? JenisStatus { get; set; }
        public double? NilaiTunjangan { get; set; }
        public StatusViewModel? Status { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}