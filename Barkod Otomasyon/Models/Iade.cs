using System;
using System.Collections.Generic;

namespace Barkod_Otomasyon.Models
{
    public partial class Iade
    {
        public int Id { get; set; }
        public Nullable<int> UrunID { get; set; }
        public Nullable<int> Adet { get; set; }
        public Nullable<decimal> BirimFiyat { get; set; }
        public Nullable<decimal> ToplamFiyat { get; set; }
        public Nullable<System.DateTime> IadeTarihi { get; set; }
        public Nullable<int> KullaniciID { get; set; }
        public string Aciklama { get; set; }
        public Nullable<int> MusteriID { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual Urun Urun { get; set; }
    }
}
