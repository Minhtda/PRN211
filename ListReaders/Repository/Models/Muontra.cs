using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Muontra
    {
        public string Docgiaid { get; set; }
        public DateTime? NgayMuon { get; set; }
        public DateTime? NgayTra { get; set; }
        public DateTime? HanTra { get; set; }
        public bool? TinhTrangMuon { get; set; }
        public bool? TinhTrangTra { get; set; }
        public string Quyensachid { get; set; }
        public string Nhanvienid { get; set; }
        public string Phatid { get; set; }

        public virtual Docgium Docgia { get; set; }
        public virtual Nhanvien Nhanvien { get; set; }
        public virtual Phat Phat { get; set; }
        public virtual Quyensach Quyensach { get; set; }
    }
}
