using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Model
{
    public partial class Quyensach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public int? SoLuong { get; set; }
        public string TenTacGia { get; set; }
        public string Msnxb { get; set; }
        public string MaLoaiSach { get; set; }

        public virtual Loaisach MaLoaiSachNavigation { get; set; }
        public virtual Nhaxuatban MsnxbNavigation { get; set; }
    }
}
