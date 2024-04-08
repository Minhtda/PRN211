using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Model
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Muontras = new HashSet<Muontra>();
        }

        public string Msnv { get; set; }
        public string HoTenNv { get; set; }
        public DateTime? NgaySinhNv { get; set; }
        public string DienThoaiNv { get; set; }
        public DateTime? NgayVaoLam { get; set; }

        public virtual ICollection<Muontra> Muontras { get; set; }
    }
}
