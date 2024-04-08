using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Taikhoan
    {
        public string TenTk { get; set; }
        public string MatKhau { get; set; }
        public string Ten { get; set; }
        public string Idnhanvien { get; set; }

        public virtual Nhanvien IdnhanvienNavigation { get; set; }
    }
}
