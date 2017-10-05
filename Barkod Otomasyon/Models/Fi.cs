using System;
using System.Collections.Generic;

namespace Barkod_Otomasyon.Models
{
    public partial class Fi
    {
        public Fi()
        {
            this.Satis = new List<Sati>();
        }

        public int Id { get; set; }
        public Nullable<System.DateTime> SatisTarihi { get; set; }
        public Nullable<int> MusteriID { get; set; }
        public Nullable<int> KullaniciID { get; set; }
        public Nullable<bool> OdendiMi { get; set; }
        public Nullable<decimal> ToplamTutar { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual ICollection<Sati> Satis { get; set; }
    }
}
