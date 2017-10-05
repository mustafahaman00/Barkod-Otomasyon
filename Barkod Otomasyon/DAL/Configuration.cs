using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Barkod_Otomasyon.Models;

    class Configuration:CreateDatabaseIfNotExists<FdkBarkodOtomasyonContext>
    {
        protected override void Seed(FdkBarkodOtomasyonContext context)
        {
            Kullanici user = new Kullanici
            {
                Adi="Adem",
                Soyadi="Bulut",
                KullaniciAdi="dkadem",
                Parola="merdiye",
                AktifMi=true,
                AdminMi=true
            };
            context.Kullanicis.Add(user);
            context.SaveChanges();
            context.Tedarikcis.Add(new Tedarikci
            {
                FirmaAdi="GenelTedarikci",
                Gsm="05077278014",
                KayitTarihi=DateTime.Now,
                KaydedenID=user.Id,
                Adres="Gültepe Mahallesi MAQAM OFFICE Kat:9 No:902 FDK Bilişim Merkez/Sivas "
            });
            context.Musteris.Add(new Musteri
            {
                AdiSoyadi="PeşinSatış",
                Adres="Peşin Satis",
                Gsm="05077278014",
                KayitTarihi=DateTime.Now
            });

            context.SaveChanges();
        }
    }
