using System;
using System.Collections.Generic;

namespace Barkod_Otomasyon.Models
{
    public partial class Kategori
    {
        public Kategori()
        {
            this.Uruns = new List<Urun>();
        }

        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public virtual ICollection<Urun> Uruns { get; set; }
    }
}
