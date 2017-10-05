using System;
using System.Collections.Generic;

namespace Barkod_Otomasyon.Models
{
    public partial class Kullanici
    {
        public Kullanici()
        {
            this.Fis = new List<Fi>();
            this.Iades = new List<Iade>();
            this.Musteris = new List<Musteri>();
            this.Tedarikcis = new List<Tedarikci>();
            this.Uruns = new List<Urun>();
        }

        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Gsm { get; set; }
        public Nullable<bool> AdminMi { get; set; }
        public Nullable<bool> AktifMi { get; set; }
        public virtual ICollection<Fi> Fis { get; set; }
        public virtual ICollection<Iade> Iades { get; set; }
        public virtual ICollection<Musteri> Musteris { get; set; }
        public virtual ICollection<Tedarikci> Tedarikcis { get; set; }
        public virtual ICollection<Urun> Uruns { get; set; }
    }
}
