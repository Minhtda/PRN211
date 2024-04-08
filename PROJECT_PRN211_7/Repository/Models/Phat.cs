using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Phat
    {
        public Phat()
        {
            Muontras = new HashSet<Muontra>();
        }

        public int Id { get; set; }
        public string NguyenNhan { get; set; }

        public virtual ICollection<Muontra> Muontras { get; set; }
    }
}
