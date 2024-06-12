using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class StatusViewModel: BaseProperties
    {
        public int Id { get; set; }
        public string JenisStatus { get; set; }
        public string Deskripsi { get; set; }
        public double NilaiTunjangan { get; set; }
    }
}
