using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Model
{
    public partial class Phat
    {
        public string MaDocGia { get; set; }
        public string NguyenNhan { get; set; }

        public virtual Docgium MaDocGiaNavigation { get; set; }
    }
}
