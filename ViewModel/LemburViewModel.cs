using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class LemburViewModel
    {
        public int Id { get; set; }
        public byte[]? DokumenLembur { get; set; }
        public string Tanggal { get; set; }
        public int IdPegawai { get; set; }
        public int JumlahLembur { get; set; }
    }
}
