using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Model
{
    public partial class Docgium
    {
        public Docgium()
        {
            Muontras = new HashSet<Muontra>();
        }

        public string MaDocGia { get; set; }
        public string TenDocGia { get; set; }
        public string DiaChi { get; set; }

        public virtual ICollection<Muontra> Muontras { get; set; }
    }
}
