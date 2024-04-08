using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Model
{
    public partial class Muontra
    {
        public string MaMuonTra { get; set; }
        public string MaDocGia { get; set; }
        public string Msnv { get; set; }

        public virtual Docgium MaDocGiaNavigation { get; set; }
        public virtual Nhanvien MsnvNavigation { get; set; }
    }
}
