using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Loaisach
    {
        public Loaisach()
        {
            Quyensaches = new HashSet<Quyensach>();
        }

        public string Id { get; set; }
        public string LoaiSach1 { get; set; }

        public virtual ICollection<Quyensach> Quyensaches { get; set; }
    }
}
