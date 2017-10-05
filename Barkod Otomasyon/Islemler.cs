using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Barkod_Otomasyon.Models;
using System.Windows.Forms;
using System.Data.Entity.Validation;
namespace Barkod_Otomasyon
{

    public class Islemler
    {
        FdkBarkodOtomasyonContext db = new FdkBarkodOtomasyonContext();

        #region Diğer işlemler
        public Decimal ToplamtutariGetir(List<SatisUrunu> urunler)
        {
            decimal tutar = 0;
            foreach (SatisUrunu item in urunler)
            {
                tutar += (decimal)item.toplamFiyat;
            }
            return tutar;
        }
        #endregion

        #region Kategori İşlemleri
        public Kategori KategoriBul(int? id)
        {
            if (id != null && id > 0)
            {
                Kategori kategori = db.Kategoris.Find(id);
                return kategori;
            }
            return null;
        }
        public Kategori KategoriBul(string _Adi)
        {
            if (!String.IsNullOrEmpty(_Adi))
            {
                Kategori kategori = db.Kategoris.FirstOrDefault(x => x.KategoriAdi == _Adi);
                return kategori;
            }
            return null;
        }

        public bool KategoriEkle(string _Adi)
        {
            if (!String.IsNullOrEmpty(_Adi))
            {
                db.Kategoris.Add(new Kategori { KategoriAdi = _Adi });
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Kategori> Kategoriler()
        {
            return db.Kategoris.ToList();
        }
        public List<Urun> KategoriUrunleri(string _kategoriadi)
        {
            if (!String.IsNullOrEmpty(_kategoriadi))
            {
                Kategori kategori = db.Kategoris.FirstOrDefault(x => x.KategoriAdi == _kategoriadi);
                if (kategori != null)
                {
                    return kategori.Uruns.ToList();
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        public List<Urun> KategoriUrunleri(int? _kategoriId)
        {
            if (_kategoriId != null && _kategoriId > 0)
            {
                Kategori kategori = db.Kategoris.Find(_kategoriId);
                if (kategori != null)
                {
                    return kategori.Uruns.ToList();
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        public bool KategoriSil(int? _kategoriId)
        {
            if (_kategoriId != null && _kategoriId > 0)
            {
                Kategori kategori = db.Kategoris.Find(_kategoriId);
                if (kategori != null)
                {
                    db.Kategoris.Remove(kategori);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool KategoriSil(string _kategoriAdi)
        {
            if (!String.IsNullOrEmpty(_kategoriAdi))
            {
                Kategori kategori = db.Kategoris.FirstOrDefault(x => x.KategoriAdi == _kategoriAdi);
                if (kategori != null)
                {
                    db.Kategoris.Remove(kategori);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool KategoriDuzenle(int _kategoriID, string _kategoriAdi)
        {
            Kategori kategori = KategoriBul(_kategoriID);
            kategori.KategoriAdi = _kategoriAdi.Trim();
            db.SaveChanges();
            return true;
        }

        #endregion

        #region Ürün İşlemleri

        public Urun UrunGetir(string barkod)
        {
            Urun urun = db.Uruns.FirstOrDefault(x => x.Barkod == barkod);
            return urun;
        }

        public bool UrunEkle(
            string urunadi,
            Kategori kategori,
            Tedarikci tedarikci,
            string barkod,
            decimal alisfiyati,
            decimal satisfiyati,
            string aciklama,
            DateTime eklenmetarihi,
            string resimyolu,
            int ekleyenid
            )
        {
            try
            {


                Urun _urun = new Urun
                {
                    UrunAdi = urunadi,
                    KategoriID = kategori.Id,
                    TedarikciID = tedarikci.Id,
                    Barkod = barkod,
                    AlisFiyati = alisfiyati,
                    SatisFiyati = satisfiyati,
                    Aciklama = aciklama,
                    EklenmeTarihi = eklenmetarihi,
                    ResimYolu = resimyolu,
                    EkleyenID = ekleyenid
                };
                db.Uruns.Add(_urun);
                db.SaveChanges();
                return true;
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    String adem = "Entity of type " +
                        eve.Entry.Entity.GetType().Name
                        + " in state \"{1}\" has the following validation errors:" + eve.Entry.State;
                    MessageBox.Show(adem);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        String bulut = "- Property: " +
                            ve.PropertyName
                            + ", Error: " +
                             ve.ErrorMessage;
                        MessageBox.Show(bulut);
                    }
                }
                throw;
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //    return false;
            //}



        }

        public bool UrunDuzenle(
            int? urunid,
            string urunadi,
            Kategori kategori,
            Tedarikci tedarikci,
            string barkod,
            decimal alisfiyati,
            decimal satisfiyati,
            string aciklama,
            DateTime eklenmetarihi,
            string resimyolu,
            int ekleyenid
            )
        {
            try
            {
                if (urunid != null && urunid > 0)
                {
                    Urun urun = db.Uruns.Find(urunid);
                    if (urun != null)
                    {
                        //Urun _urun = new Urun
                        //{
                        //    UrunAdi = urunadi,
                        //    KategoriID = kategori.Id,
                        //    TedarikciID = tedarikci.Id,
                        //    Barkod = barkod,
                        //    AlisFiyati = alisfiyati,
                        //    SatisFiyati = satisfiyati,
                        //    Aciklama = aciklama,
                        //    EklenmeTarihi = eklenmetarihi,
                        //    ResimYolu = resimyolu,
                        //    EkleyenID = ekleyenid
                        //};
                        urun.UrunAdi = urunadi;
                        urun.KategoriID = kategori.Id;
                        urun.TedarikciID = tedarikci.Id;
                        urun.Barkod = barkod;
                        urun.AlisFiyati = alisfiyati;
                        urun.SatisFiyati = satisfiyati;
                        urun.Aciklama = aciklama;
                        urun.ResimYolu = resimyolu;
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;

                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Urun> UrunleriListele()
        {
            return db.Uruns.ToList();
        }
        public bool UrunSil(int? id)
        {
            if (id != null && id > 0)
            {
                Urun urun = db.Uruns.Find(id);
                if (urun != null)
                {
                    db.Uruns.Remove(urun);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else { return false; }
        }


        #endregion

        #region Tedarikçi İşlemleri

        public List<Tedarikci> TedarikciListesi()
        {
            return db.Tedarikcis.ToList();
        }

        public Tedarikci TedarikciBul(int? _id)
        {
            if (_id != null && _id > 0)
            {
                Tedarikci ted = db.Tedarikcis.Find(_id);
                return ted;
            }
            return null;
        }
        public List<Urun> TedarikciUrunleri(int? _id)
        {
            if (_id != null && _id > 0)
            {
                Tedarikci ted = db.Tedarikcis.Find(_id);
                if (ted != null)
                {
                    return ted.Uruns.ToList();
                }
                else { return null; }
            }
            else { return null; }
        }
        public bool TedarikciSil(int? _id)
        {
            if (_id != null && _id > 0)
            {
                Tedarikci ted = db.Tedarikcis.Find(_id);
                if (ted != null)
                {
                    db.Tedarikcis.Remove(ted);
                    db.SaveChanges();
                    return true;
                }
                else { return false; }
            }
            else { return false; }
        }
        public bool TedarikciEkle(String firmaAdi, String gsm, String adres)
        {
            try
            {
                Tedarikci yenited = new Tedarikci
                            {
                                FirmaAdi = firmaAdi,
                                Adres = adres,
                                Gsm = gsm,
                                KayitTarihi = DateTime.Now,
                                KaydedenID = User.kullanici.Id
                            };
                db.Tedarikcis.Add(yenited);
                db.SaveChanges();
                return true;
            }
            catch (Exception) { return false; }

        }
        public bool TedarikciDuzenle(int? _id, String firmaadi, string gsm, string adres)
        {
            if (_id != null && _id > 0)
            {
                Tedarikci tedarikci = db.Tedarikcis.Find(_id);
                if (tedarikci != null)
                {
                    tedarikci.FirmaAdi = firmaadi;
                    tedarikci.Adres = adres;
                    tedarikci.Gsm = gsm;
                    tedarikci.KayitTarihi = DateTime.Now;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        #endregion

        #region Müşteri İşlemleri

        public List<Musteri> MusteriListele()
        {
            return db.Musteris.ToList();
        }

        public List<Fi> MusteriFisleri(int? id)
        {
            if (id != null && id > 0)
            {
                Musteri musteri = db.Musteris.Find(id);
                if (musteri != null)
                {
                    return musteri.Fis.ToList();
                } return null;
            }
            return null;
        }


        #region Müşteri Ekle Sil Düzenle
        public bool MusteriSil(int? id)
        {
            if (id != null && id > 0)
            {
                Musteri musteri = db.Musteris.Find(id);
                db.Musteris.Remove(musteri);
                db.SaveChanges();
                return true;
            } return false;
        }
        public bool MusteriEkle(String adisoyadi, String gsm, String adres)
        {
            try
            {
                Musteri musteri = new Musteri
                {
                    AdiSoyadi = adisoyadi,
                    Gsm = gsm,
                    Adres = adres,
                    EkleyenID = User.kullanici.Id,
                    KayitTarihi = DateTime.Now
                };
                db.Musteris.Add(musteri);
                db.SaveChanges();
                return true;
            }
            catch (Exception) { return false; }

        }
        public bool MusteriDuzenle(int? _id, string adisoyadi, string gsm, string adres)
        {
            if (_id != null && _id > 0)
            {
                Musteri musteri = db.Musteris.Find(_id);
                musteri.AdiSoyadi = adisoyadi;
                musteri.Gsm = gsm;
                musteri.Adres = adres;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        #endregion
        #endregion

        #region Kullanıcı işlemleri
        public List<Kullanici> KullanicilariGetir(int? kendiKullanicisiId)
        {
            if (kendiKullanicisiId != null && kendiKullanicisiId > 0)
            {
                var result = db.Kullanicis.Where(x => x.Id != kendiKullanicisiId).ToList();
                return result;
            }
            return null;
        }
        public bool KullaniciEkle(
            string kullaniciadi,
            string parola,
            string adi,
            string soyadi,
            string gsm,
            bool aktifmi,
            bool adminmi)
        {

            try
            {
                Kullanici kisi = new Kullanici
                            {
                                KullaniciAdi = kullaniciadi,
                                Parola = parola,
                                Adi = adi,
                                Soyadi = soyadi,
                                Gsm = gsm,
                                AktifMi = aktifmi,
                                AdminMi = adminmi
                            };
                db.Kullanicis.Add(kisi);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public Kullanici KullaniciGetirTelefonla(string telefon)
        {
            if (!String.IsNullOrEmpty(telefon))
            {
                Kullanici gi = db.Kullanicis.FirstOrDefault(x => x.Gsm == telefon);
                return gi;
            }
            else
            {
                return null;
            }
        }
        public Kullanici KullaniciGetirKullaniciAdiIle(string kullaniciadi)
        {
            if (!String.IsNullOrEmpty(kullaniciadi))
            {
                Kullanici k = db.Kullanicis.FirstOrDefault(x => x.KullaniciAdi == kullaniciadi);
                return k;
            }
            return null;
        }
        public bool KullaniciVarMi(string kullaniciAdi)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi))
            {
                Kullanici user = db.Kullanicis.FirstOrDefault(x => x.KullaniciAdi == kullaniciAdi);
                if (user != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        public bool KullaniciVarMiTelefonla(string telefon)
        {
            if (!string.IsNullOrEmpty(telefon))
            {
                Kullanici user = db.Kullanicis.FirstOrDefault(x => x.Gsm == telefon);
                if (user != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else { return false; }
        }
        public bool KullaniciDuzenle(
            int? kullaniciId,
            string kullaniciadi,
            string parola,
            string adi,
            string soyadi,
            string gsm,
            bool aktifmi,
            bool adminmi
            )
        {
            try
            {
                if (kullaniciId != null && kullaniciId > 0)
                {
                    Kullanici user = db.Kullanicis.Find(kullaniciId);
                    if (user != null)
                    {
                        user.Adi = adi;
                        user.Soyadi = soyadi;
                        user.Gsm = gsm;
                        user.KullaniciAdi = kullaniciadi;
                        user.Parola = parola;
                        user.AktifMi = aktifmi;
                        user.AdminMi = adminmi;
                        db.SaveChanges();
                        return true;

                    }
                    else { return false; }
                }
                else { return false; }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Fiş İşlemleri
        public Fi YeniOdenmisFisOlustur(int? kullaniciId, int? musteriId)
        {
            if (kullaniciId != null && kullaniciId > 0)
            {
                if (musteriId != null && musteriId > 0)
                {
                    Fi fis = new Fi
                    {
                        KullaniciID = kullaniciId,
                        MusteriID = musteriId,
                        SatisTarihi = DateTime.Now,
                        ToplamTutar = 0,
                        OdendiMi = true
                    };
                    db.Fis.Add(fis);
                    db.SaveChanges();
                    return fis;
                }
                else { return null; }
            }
            else { return null; }
        }
        public Fi YeniBorcFisOlustur(int? kullaniciId, int? musteriId)
        {
            if (kullaniciId != null && kullaniciId > 0)
            {
                if (musteriId != null && musteriId > 0)
                {
                    Fi fis = new Fi
                    {
                        KullaniciID = kullaniciId,
                        MusteriID = musteriId,
                        SatisTarihi = DateTime.Now,
                        ToplamTutar = 0,
                        OdendiMi = false
                    };
                    db.Fis.Add(fis);
                    db.SaveChanges();
                    return fis;
                }
                else { return null; }
            }
            else { return null; }
        }

        public List<Fi> OdenmemisMusteriFisleriniGetir(int? musteriID)
        {
            if (musteriID != null && musteriID > 0)
            {
                Musteri musteri = db.Musteris.Find(musteriID);
                if (musteri != null)
                {
                    return musteri.Fis.Where(x => x.OdendiMi == false).ToList();
                }
            }
            return null
                ;
        }

        #endregion

        #region Satış İşlemleri
        public bool SatisYap(int? fisID, List<SatisUrunu> urunler, bool odendiMi)
        {
            if (fisID != null && fisID > 0)
            {
                Fi fis = db.Fis.Find(fisID);
                if (urunler != null && urunler.Count > 0)
                {
                    foreach (SatisUrunu item in urunler)
                    {
                        Sati satis = new Sati
                        {
                            FisID = fisID,
                            Adet = item.adet,
                            BirimFiyat = item.adetFiyat,
                            ToplamFiyat = (item.adet * item.adetFiyat),
                            AdetAlisFiyati = item.adetAlisFiyati,
                            AdetSatisFiyati = item.urun.SatisFiyati,
                            UrunID = item.urun.Id
                        };
                        db.Satis.Add(satis);
                    }

                    fis.OdendiMi = odendiMi;
                    fis.SatisTarihi = DateTime.Now;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else { return false; }
        }

        public bool UrunleriFiseKaydet(List<SatisUrunu> urunler, Fi fis)
        {
            try
            {
                foreach (SatisUrunu item in urunler)
                {

                    Sati satis = new Sati
                    {
                        Adet = item.adet,
                        BirimFiyat = item.adetFiyat,
                        FisID = fis.Id,
                        ToplamFiyat = item.toplamFiyat,
                        AdetAlisFiyati = item.adetAlisFiyati,
                        AdetSatisFiyati =item.urun.SatisFiyati,
                        UrunID = item.urun.Id
                    };
                    db.Satis.Add(satis);
                }
                decimal toplamfistutari = ToplamtutariGetir(urunler);
                fis.ToplamTutar = (decimal)toplamfistutari;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public List<Sati> FisSatislariniGetir(Fi fis)
        {
            if (fis != null)
            {
                return fis.Satis.ToList();
            } return null;
        }

        public bool BorcFisineOdemeYap(int? fisID)
        {
            try
            {
                if (fisID != null && fisID > 0)
                {
                    Fi fis = db.Fis.Find(fisID);
                    if (fis != null)
                    {
                        fis.OdendiMi = true;
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else { return false; }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Analiz ve Raporlar
        public List<Fi> FislerimiGetir(int? userID)
        {
            if (userID != null && userID > 0)
            {
                List<Fi> fisler = db.Fis.Where(x => x.KullaniciID == userID).ToList();
                return fisler;
            } return null;
        }
        public List<Fi> TumFisleriGetir()
        {
            return db.Fis.ToList();
        }

        public List<Fi> FisleriGetirTariheGore(DateTime ilk, DateTime son)
        {
            if (ilk != null && son != null)
            {
                List<Fi> liste = db.Fis.Where(x => x.SatisTarihi <= son && x.SatisTarihi >= ilk).ToList();
                return liste;
            } return null;
        }
        public List<Fi> FislerimiTariheGoreGetir(int? userID, DateTime ilk, DateTime son)
        {
            if (userID != null && userID > 0)
            {
                if (ilk != null && son != null)
                {
                    return db.Fis.Where(x => x.KullaniciID == userID && x.SatisTarihi >= ilk && x.SatisTarihi <= son).ToList();

                } return null;
            } return null;
        }
        public List<Sati> FisinSatislariniGetir(int? fisID)
        {
            if (fisID != null && fisID > 0)
            {
                Fi fis = db.Fis.Find(fisID);
                if (fis != null)
                {
                    return fis.Satis.ToList();
                }
                return null;
            }
            return null;
        }

        public decimal FisTutariniHesapla(int? fisID)
        {
            if (fisID != null && fisID > 0)
            {
                Fi fis = db.Fis.Find(fisID);
                if (fis != null)
                {
                    return (decimal)fis.ToplamTutar;
                    //decimal tutar = 0;
                    //foreach (Sati item in fis.Satis)
                    //{
                    //    tutar += (decimal)item.ToplamFiyat;
                    //}
                    //return tutar;
                } return 0;
            } return 0;
        }


        public List<KarZararUrunu> GunSonuSatislariGetir()
        {
            try
            {
                DateTime tarih = DateTime.Now;
                DateTime bugun = new DateTime(tarih.Year, tarih.Month, tarih.Day, 0, 0, 0);
                List<Fi> liste = db.Fis.Where(x => x.SatisTarihi >= bugun).ToList();
                List<Sati> satislar = new List<Sati>();
                foreach (Fi item in liste)
                {
                    List<Sati> fisSatislari = item.Satis.ToList();
                    satislar.AddRange(fisSatislari);
                }

                List<KarZararUrunu> karzararlar = new List<KarZararUrunu>();
                foreach (Sati item in satislar)
                {
                    decimal topMaliyet = (decimal)(item.Adet * item.AdetAlisFiyati);
                    decimal topTutar = (decimal)item.ToplamFiyat;
                    decimal toplamkar = topTutar - topMaliyet;
                    KarZararUrunu kz = new KarZararUrunu
                    {
                        Satis = item,
                        ToplamKar = toplamkar
                    };
                    karzararlar.Add(kz);
                }
                return karzararlar;
            }
            catch (Exception) { return null; }
           
            
        }
        public List<KarZararUrunu> AySonuSatislariGetir()
        {
            try
            {
                DateTime tarih = DateTime.Now;
                DateTime bugun = new DateTime(tarih.Year, tarih.Month, 1, 0, 0, 0);
                List<Fi> liste = db.Fis.Where(x => x.SatisTarihi >= bugun).ToList();
                List<Sati> satislar = new List<Sati>();
                foreach (Fi item in liste)
                {
                    List<Sati> fisSatislari = item.Satis.ToList();
                    satislar.AddRange(fisSatislari);
                }

                List<KarZararUrunu> karzararlar = new List<KarZararUrunu>();
                foreach (Sati item in satislar)
                {
                    decimal topMaliyet = (decimal)(item.Adet * item.AdetAlisFiyati);
                    decimal topTutar = (decimal)item.ToplamFiyat;
                    decimal toplamkar = topTutar - topMaliyet;
                    KarZararUrunu kz = new KarZararUrunu
                    {
                        Satis = item,
                        ToplamKar = toplamkar
                    };
                    karzararlar.Add(kz);
                }
                return karzararlar;
            }
            catch (Exception) { return null; }
           
        }

        public List<KarZararUrunu> TarihBazlıSatislariGetir(DateTime ilk, DateTime son)
        {
            try
            {
                DateTime ilkTarih = new DateTime(ilk.Year, ilk.Month, ilk.Day, 0, 0, 0);
                DateTime sonTarih = new DateTime(son.Year, son.Month, son.Day, 23, 59, 59);

                List<Fi> liste = db.Fis.Where(x => x.SatisTarihi >= ilkTarih && x.SatisTarihi<=sonTarih).ToList();
                List<Sati> satislar = new List<Sati>();
                foreach (Fi item in liste)
                {
                    List<Sati> fisSatislari = item.Satis.ToList();
                    satislar.AddRange(fisSatislari);
                }

                List<KarZararUrunu> karzararlar = new List<KarZararUrunu>();
                foreach (Sati item in satislar)
                {
                    decimal topMaliyet = (decimal)(item.Adet * item.AdetAlisFiyati);
                    decimal topTutar = (decimal)item.ToplamFiyat;
                    decimal toplamkar = topTutar - topMaliyet;
                    KarZararUrunu kz = new KarZararUrunu
                    {
                        Satis = item,
                        ToplamKar = toplamkar
                    };
                    karzararlar.Add(kz);
                }
                return karzararlar;
            }
            catch (Exception) { return null; }
        }
        #endregion

        #region Iade İşlemleri
        public bool IadeKaydet(int urunid, int adet, int musteriid, decimal birimFiyat, decimal tutar, string aciklama)
        {
            try
            {
                Urun urun = db.Uruns.Find(urunid);
                Musteri musteri = db.Musteris.Find(musteriid);
                if (urun != null && musteri != null)
                {
                    Iade iade = new Iade
                    {
                        Aciklama = aciklama,
                        Adet = adet,
                        MusteriID = musteri.Id,
                        BirimFiyat = birimFiyat,
                        IadeTarihi = DateTime.Now,
                        ToplamFiyat = tutar,
                        UrunID = urun.Id,
                        KullaniciID = User.kullanici.Id
                    };
                    db.Iades.Add(iade);
                    db.SaveChanges();
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Iade> IadeleriGetir()
        {
            return db.Iades.ToList();
        }
        #endregion

    }
}
