using System;
using System.Collections.Generic;

namespace Barkod_Otomasyon.Models
{
    public partial class Musteri
    {
        public Musteri()
        {
            this.Fis = new List<Fi>();
            this.Iades = new List<Iade>();
        }

        public int Id { get; set; }
        public string AdiSoyadi { get; set; }
        public string Gsm { get; set; }
        public string Adres { get; set; }
        public Nullable<int> EkleyenID { get; set; }
        public Nullable<System.DateTime> KayitTarihi { get; set; }
        public virtual ICollection<Fi> Fis { get; set; }
        public virtual ICollection<Iade> Iades { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
