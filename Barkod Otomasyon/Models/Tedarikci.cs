using System;
using System.Collections.Generic;

namespace Barkod_Otomasyon.Models
{
    public partial class Tedarikci
    {
        public Tedarikci()
        {
            this.Uruns = new List<Urun>();
        }

        public int Id { get; set; }
        public string FirmaAdi { get; set; }
        public string Adres { get; set; }
        public string Gsm { get; set; }
        public Nullable<System.DateTime> KayitTarihi { get; set; }
        public Nullable<int> KaydedenID { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual ICollection<Urun> Uruns { get; set; }
    }
}
