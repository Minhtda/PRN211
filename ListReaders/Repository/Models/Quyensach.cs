using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Quyensach
    {
        public string Id { get; set; }
        public string TenSach { get; set; }
        public int? SoLuong { get; set; }
        public string TenTacGia { get; set; }
        public string Nhaxuatbanid { get; set; }
        public string Loaisachid { get; set; }

        public virtual Loaisach Loaisach { get; set; }
        public virtual Nhaxuatban Nhaxuatban { get; set; }
    }
}
