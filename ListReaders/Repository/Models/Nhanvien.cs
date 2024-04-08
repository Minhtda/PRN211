using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Taikhoans = new HashSet<Taikhoan>();
        }

        public string Id { get; set; }
        public string HoTenNv { get; set; }
        public DateTime? NgaySinhNv { get; set; }
        public string DienThoaiNv { get; set; }
        public DateTime? NgayVaoLam { get; set; }

        public virtual ICollection<Taikhoan> Taikhoans { get; set; }
    }
}
