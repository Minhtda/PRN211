using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Model
{
    public partial class Trasach
    {
        public string MaSach { get; set; }
        public string MaMuonTra { get; set; }
        public string Msnv { get; set; }
        public DateTime? NgayTra { get; set; }

        public virtual Muontra MaMuonTraNavigation { get; set; }
        public virtual Quyensach MaSachNavigation { get; set; }
        public virtual Nhanvien MsnvNavigation { get; set; }
    }
}
