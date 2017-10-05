using System;
using System.Collections.Generic;

namespace Barkod_Otomasyon.Models
{
    public partial class Sati
    {
        public int Id { get; set; }
        public Nullable<int> UrunID { get; set; }
        public Nullable<int> Adet { get; set; }
        public Nullable<decimal> BirimFiyat { get; set; }
        public Nullable<decimal> ToplamFiyat { get; set; }
        public Nullable<int> FisID { get; set; }
        public Nullable<decimal> AdetAlisFiyati { get; set; }
        public Nullable<decimal> AdetSatisFiyati { get; set; }
        public virtual Fi Fi { get; set; }
        public virtual Urun Urun { get; set; }
    }
}
