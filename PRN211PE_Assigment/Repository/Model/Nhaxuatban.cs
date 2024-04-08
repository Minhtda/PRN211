using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Model
{
    public partial class Nhaxuatban
    {
        public Nhaxuatban()
        {
            Quyensaches = new HashSet<Quyensach>();
        }

        public string Msnxb { get; set; }
        public string TenNxb { get; set; }
        public string DiaChiNxb { get; set; }
        public string EmailNxb { get; set; }

        public virtual ICollection<Quyensach> Quyensaches { get; set; }
    }
}
