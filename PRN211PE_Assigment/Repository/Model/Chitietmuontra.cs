using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Model
{
    public partial class Chitietmuontra
    {
        public string MaMuonTra { get; set; }
        public string MaSach { get; set; }
        public DateTime? NgayMuon { get; set; }
        public DateTime? HanTra { get; set; }

        public virtual Muontra MaMuonTraNavigation { get; set; }
        public virtual Quyensach MaSachNavigation { get; set; }
    }
}
