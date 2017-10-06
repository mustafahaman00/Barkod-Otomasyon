using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Barkod_Otomasyon.Models;
namespace Barkod_Otomasyon
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        Islemler islemler = new Islemler();
        frmIadeMusteriSecim fIadeSecim;
        frmKullaniciSec fKul;
        frmBorcMusteriSecim fBorcOn;
        frmGenelSatislarOn frmOn = new frmGenelSatislarOn();

        public frmMain()
        {
            InitializeComponent();
        }
        #region Genel Methotlar
        void CikisYap()
        {
            DialogResult sonuc = MessageBox.Show("Uygulamadan çıkış yapmak istediğinize emin misiniz?"
                , "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void FiyatGoster()
        {
            frmFiyatOgren frm = new frmFiyatOgren();
            frm.MdiParent = this;
            frm.Show();
        }
        private void KategorileriGoster()
        {
            frmKategoriler frm = new frmKategoriler();
            frm.MdiParent = this;
            frm.Show();
        }
        private void UrunleriGoster()
        {
            frmUrunListesi frm = new frmUrunListesi();
            frm.MdiParent = this;
            frm.Show();
        }
        private void TedarikcileriGoster()
        {
            frmTedarikciListesi frm = new frmTedarikciListesi();
            frm.MdiParent = this;
            frm.Show();
        }
        private void MusterileriGoster()
        {
            frmMusteriListesi frm = new frmMusteriListesi();
            frm.MdiParent = this; frm.Show();
        }
        private void KullanicilariGoster()
        {
            frmKullanicilar frm = new frmKullanicilar();
            frm.MdiParent = this;
            frm.Show();
        }
        private void SatislarimiGoster()
        {
            frmSatislarim satislarim = new frmSatislarim(User.kullanici.Id);
            satislarim.MdiParent = this;
            satislarim.Show();
        }
        private void GenelSatislariGoster()
        {
            frmOn.FormClosed += frmOn_FormClosed;
            frmOn.ShowDialog();
        }
        private void BorcTahsilat()
        {
            fBorcOn = new frmBorcMusteriSecim();
            fBorcOn.FormClosed += fBorcOn_FormClosed;
            fBorcOn.ShowDialog();
        }
        private void IadeIslemiYap()
        {
            fIadeSecim = new frmIadeMusteriSecim();
            fIadeSecim.FormClosed += fIadeSecim_FormClosed;
            fIadeSecim.ShowDialog();
        }
        private void IadeleriGoster()
        {
            frmIadeler f = new frmIadeler();
            f.MdiParent = this;
            f.Show();
        }
        private void GunlukAnaliziGoster()
        {
            List<KarZararUrunu> bugunkusatislar = islemler.GunSonuSatislariGetir();

            if (bugunkusatislar != null)
            {
                if (bugunkusatislar.Count > 0)
                {
                    frmKarZararUrunleri fkarzarar = new frmKarZararUrunleri(bugunkusatislar, "Bugüne Ait Satış Analizi");
                    fkarzarar.MdiParent = this;
                    fkarzarar.Show();
                }
                else
                {
                    MessageBox.Show("Bugüne ait hiç satış bulunamadı", "Hata", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show("Satışlar gelirken bir hata meydana geldi"); }

        }
        private void AylikAnaliziGoster()
        {
            List<KarZararUrunu> buaykisatislar = islemler.AySonuSatislariGetir();
            if (buaykisatislar != null)
            {
                if (buaykisatislar.Count > 0)
                {
                    frmKarZararUrunleri fkarzarar = new frmKarZararUrunleri(buaykisatislar, "Bu Aya Ait Satış Analizi");
                    fkarzarar.MdiParent = this;
                    fkarzarar.Show();
                }
                else
                {
                    MessageBox.Show("Bu aya ait satış bulunamadı", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Satışlar gelirken bir hata meydana geldi");
            }
        }
        frmKarZararTarihSecim fTarihSec;
        private void TarihBazliAnalizGoster()
        {
            fTarihSec = new frmKarZararTarihSecim();
            fTarihSec.FormClosed += fTarihSec_FormClosed;
            fTarihSec.ShowDialog();
        }
        private void KullaniciBazliAnalizGoster()
        {
            fKul = new frmKullaniciSec();
            fKul.FormClosed += fKul_FormClosed;
            fKul.ShowDialog();
        }
        private void SatisYap()
        {
            frmSatis frm = new frmSatis();
            frm.MdiParent = this;
            frm.Show();
        }
        private void UrunEkle()
        {
            frmUrunEkle frm = new frmUrunEkle(null);
            frm.ShowDialog();
        }
        private void YuklenmeDurumu()
        {
        }


        #endregion

        #region Eventlar

        void fIadeSecim_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fIadeSecim.Devam)
            {
                Musteri musteri = fIadeSecim.musteri;
                frmIade fIade = new frmIade(musteri);
                fIade.ShowDialog();
            }
        }
        void frmOn_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmOn.DevamEt)
            {
                if (frmOn.TumSatislar)
                {
                    List<Fi> Liste = islemler.TumFisleriGetir().ToList(); ;
                    if (Liste.Count > 0)
                    {
                        frmGenelSatislar f = new frmGenelSatislar(Liste);
                        f.MdiParent = this;
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Hiç satış bulunamadı");
                    }


                }
                else
                {
                    DateTime ilk = frmOn.IlkTarih;
                    DateTime son = frmOn.SonTarih;


                    List<Fi> Liste = islemler.FisleriGetirTariheGore(ilk, son).ToList();
                    if (Liste.Count > 0)
                    {
                        frmGenelSatislar f = new frmGenelSatislar(Liste);
                        f.MdiParent = this;
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Hiç satış bulunamadı");
                    }

                }
            }
        }
        void fBorcOn_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fBorcOn.Devam)
            {
                Musteri musteri = fBorcOn.musteri;
                List<Fi> fisler = islemler.MusteriFisleri(musteri.Id);
                if (fisler.Count > 0)
                {
                    frmBorcMusteri frm = new frmBorcMusteri(musteri);
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Müşterinin hiç fişi bulunamadı");
                }
            }
        }
        void fTarihSec_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fTarihSec.DevamEt == true)
            {
                DateTime ilk = fTarihSec.ilk;
                DateTime son = fTarihSec.son;
                frmKarZararUrunleri fkar = new frmKarZararUrunleri(islemler.TarihBazliSatislariGetir(
                    ilk, son), "Tarih bazlı satış analizi");

                fkar.MdiParent = this;
                fkar.Show();
            }
        }
        void fKul_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fKul.DevamEt)
            {
                if (fKul.tarihDurumu)
                {
                    DateTime ilk = fKul.ilk;
                    DateTime son = fKul.son;
                    if (ilk != null && son != null)
                    {
                        List<KarZararUrunu> liste = islemler.KullaniciBazliSatislariGetir(fKul.secilenKullanici.Id, ilk, son).ToList();
                        if (liste.Count > 0)
                        {
                            frmKarZararUrunleri fkar = new frmKarZararUrunleri(liste, fKul.secilenKullanici.KullaniciAdi + " 'e ait kar zarar raporu");
                            fkar.MdiParent = this;
                            fkar.Show();
                        }
                        else
                        {
                            MessageBox.Show("Seçilen tarihlerde kullanıcıya ait fiş bulunamadı", "Hata",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        List<KarZararUrunu> liste = islemler.KullaniciBazliSatislariGetir(fKul.secilenKullanici.Id).ToList();
                        if (liste.Count > 0)
                        {
                            frmKarZararUrunleri fkar = new frmKarZararUrunleri(liste, " Kullanıcı bazlı kar zarar raporu");
                            fkar.MdiParent = this;
                            fkar.Show();
                        }
                        else
                        {
                            MessageBox.Show("Seçilen kullanıcıya ait fiş bulunamadı");
                        }
                    }
                }
                else
                {
                    List<KarZararUrunu> liste = islemler.KullaniciBazliSatislariGetir(fKul.secilenKullanici.Id).ToList();
                    if (liste.Count > 0)
                    {
                        frmKarZararUrunleri fkar = new frmKarZararUrunleri(liste, "Kullanıcı bazlı kar zarar raporu");
                        fkar.MdiParent = this;
                        fkar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Seçilen kullanıcıya ait fiş bulunamadı");
                    }
                }
            }
        }
        #endregion

        #region ClickEvent

        private void btnFiyatGoster_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FiyatGoster();
        }

        private void btnKategoriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KategorileriGoster();
        }

        private void btnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UrunleriGoster();
        }

        private void btnTedarikciler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TedarikcileriGoster();
        }



        private void btnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MusterileriGoster();
        }

        private void btnUrunEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UrunEkle();
        }

        private void btnKullaniciIslemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KullanicilariGoster();
        }

        private void btnSatisYap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SatisYap();
        }

        private void btnSatislar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SatislarimiGoster();
        }

        private void btnGenelSatislar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GenelSatislariGoster();
        }

        private void btnBorcTahsil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BorcTahsilat();
        }

        private void btnIadeIslemi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IadeIslemiYap();
        }

        private void btnIadeler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IadeleriGoster();
        }

        private void btnGunlukAnaliz_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GunlukAnaliziGoster();
        }

        private void btnAylikAnaliz_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AylikAnaliziGoster();
        }

        private void btnTarihBazli_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TarihBazliAnalizGoster();
        }

        private void btnKullaniciBazliAnaliz_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KullaniciBazliAnalizGoster();
        }

        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            YuklenmeDurumu();
        }


        #region Menu Islemleri



        private void mnuCikis_Click(object sender, EventArgs e)
        {
            CikisYap();
        }

        private void mnuUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkle();
        }

        private void mnuUrunListele_Click(object sender, EventArgs e)
        {
            UrunleriGoster();
        }

        private void mnuKategoriler_Click(object sender, EventArgs e)
        {
            KategorileriGoster();
        }

        private void mnuMusteriEkle_Click(object sender, EventArgs e)
        {
            MusterileriGoster();
        }

        private void mnuMusteriBorclari_Click(object sender, EventArgs e)
        {
            BorcTahsilat();
        }

        private void mnuTedarikciler_Click(object sender, EventArgs e)
        {
            TedarikcileriGoster();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuFiyatGoster_Click(object sender, EventArgs e)
        {
            FiyatGoster();
        }

        private void mnuSatisYap_Click(object sender, EventArgs e)
        {
            SatisYap();
        }

        private void mnuKendiSatislarim_Click(object sender, EventArgs e)
        {
            SatislarimiGoster();
        }

        private void mnuGenelSatislar_Click(object sender, EventArgs e)
        {
            GenelSatislariGoster();
        }

        private void ıadeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuIadeOlustur_Click(object sender, EventArgs e)
        {
            IadeIslemiYap();
        }

        private void mnuIadeleriGoruntule_Click(object sender, EventArgs e)
        {
            IadeleriGoster();
        }

        private void mnuKullanicilar_Click(object sender, EventArgs e)
        {
            KullanicilariGoster();
        }

        private void mnuGunSonuAnalizi_Click(object sender, EventArgs e)
        {
            GunlukAnaliziGoster();
        }

        private void mnuAySonuAnalizi_Click(object sender, EventArgs e)
        {
            AylikAnaliziGoster();
        }

        private void mnuTarihBazliAnaliz_Click(object sender, EventArgs e)
        {
            TarihBazliAnalizGoster();
        }

        private void mnuKullaniciBazliAnaliz_Click(object sender, EventArgs e)
        {
            KullaniciBazliAnalizGoster();
        }

        #endregion
    }
}
