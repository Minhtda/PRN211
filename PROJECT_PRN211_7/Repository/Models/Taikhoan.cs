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
        public string Nhanvienid { get; set; }

        public virtual Nhanvien Nhanvien { get; set; }
    }
}
