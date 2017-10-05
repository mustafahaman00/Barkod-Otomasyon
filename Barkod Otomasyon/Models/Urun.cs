using System;
using System.Collections.Generic;

namespace Barkod_Otomasyon.Models
{
    public partial class Urun
    {
        public Urun()
        {
            this.Iades = new List<Iade>();
            this.Satis = new List<Sati>();
        }

        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public Nullable<int> KategoriID { get; set; }
        public Nullable<int> TedarikciID { get; set; }
        public string Barkod { get; set; }
        public Nullable<decimal> AlisFiyati { get; set; }
        public Nullable<decimal> SatisFiyati { get; set; }
        public string Aciklama { get; set; }
        public Nullable<System.DateTime> EklenmeTarihi { get; set; }
        public Nullable<int> EkleyenID { get; set; }
        public string ResimYolu { get; set; }
        public virtual ICollection<Iade> Iades { get; set; }
        public virtual Kategori Kategori { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual ICollection<Sati> Satis { get; set; }
        public virtual Tedarikci Tedarikci { get; set; }
    }
}
