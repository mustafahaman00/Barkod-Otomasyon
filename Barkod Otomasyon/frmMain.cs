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
        public frmMain()
        {
            InitializeComponent();
        }


        private void btnFiyatGoster_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFiyatOgren frm = new frmFiyatOgren();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKategoriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKategoriler frm = new frmKategoriler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUrunListesi frm = new frmUrunListesi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTedarikciler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTedarikciListesi frm = new frmTedarikciListesi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            using (Barkod_Otomasyon.Models.FdkBarkodOtomasyonContext db = new Models.FdkBarkodOtomasyonContext())
            {
                User.kullanici = db.Kullanicis.FirstOrDefault(x => x.KullaniciAdi == "dkadem");
            }
        }

        private void btnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMusteriListesi frm = new frmMusteriListesi();
            frm.MdiParent = this; frm.Show();
        }

        private void btnUrunEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUrunEkle frm = new frmUrunEkle(null);
            frm.ShowDialog();
        }

        private void btnKullaniciIslemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKullanicilar frm = new frmKullanicilar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnSatisYap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSatis frm = new frmSatis();
            frm.MdiParent = this;
            //frm.ShowDialog();
            frm.Show();
        }

        private void btnSatislar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSatislarim satislarim = new frmSatislarim(User.kullanici.Id);
            satislarim.MdiParent = this;
            satislarim.Show();
        }

        frmGenelSatislarOn frmOn = new frmGenelSatislarOn();
        private void btnGenelSatislar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOn.FormClosed += frmOn_FormClosed;
            frmOn.ShowDialog();
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

        frmBorcMusteriSecim fBorcOn;
        private void btnBorcTahsil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fBorcOn = new frmBorcMusteriSecim();
            fBorcOn.FormClosed += fBorcOn_FormClosed;
            fBorcOn.ShowDialog();
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

        frmIadeMusteriSecim fIadeSecim;
        private void btnIadeIslemi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //burada önce yönetici izni alınması gerekiyor

            fIadeSecim = new frmIadeMusteriSecim();
            fIadeSecim.FormClosed += fIadeSecim_FormClosed;
            fIadeSecim.ShowDialog();
        }

        void fIadeSecim_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fIadeSecim.Devam)
            {
                Musteri musteri = fIadeSecim.musteri;
                frmIade fIade = new frmIade(musteri);
                fIade.ShowDialog();
            }
        }

        private void btnIadeler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmIadeler f = new frmIadeler();
            f.MdiParent = this;
            f.Show();
        }

        private void btnGunlukAnaliz_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<KarZararUrunu> bugunkusatislar = islemler.GunSonuSatislariGetir();
            
            if (bugunkusatislar != null)
            {
                if (bugunkusatislar.Count > 0)
                {
                    frmKarZararUrunleri fkarzarar = new frmKarZararUrunleri(bugunkusatislar);
                    fkarzarar.MdiParent = this;
                    fkarzarar.Baslik = "Bugüne Ait Satış Analizi";
                    fkarzarar.Show();
                }
                else
                {
                    MessageBox.Show("Bugüne ait hiç satış bulunamadı", "Hata", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }else{MessageBox.Show("Satışlar gelirken bir hata meydana geldi");}

        }

        private void btnAylikAnaliz_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<KarZararUrunu> buaykisatislar = islemler.AySonuSatislariGetir();
            if (buaykisatislar != null)
            {
                if (buaykisatislar.Count > 0)
                {
                    frmKarZararUrunleri fkarzarar = new frmKarZararUrunleri(buaykisatislar);
                    fkarzarar.MdiParent = this;
                    fkarzarar.Baslik = "Bu Aya Ait Satış Analizi";
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
        private void btnTarihBazli_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fTarihSec = new frmKarZararTarihSecim();
            fTarihSec.FormClosed += fTarihSec_FormClosed;
            fTarihSec.ShowDialog();
        }

        void fTarihSec_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fTarihSec.DevamEt == true)
            {
                DateTime ilk = fTarihSec.ilk;
                DateTime son = fTarihSec.son;
                frmKarZararUrunleri fkar = new frmKarZararUrunleri(islemler.TarihBazlıSatislariGetir(
                    ilk,son));
                fkar.Baslik = ilk +"-"+ son + " : arasındaki satış analizi";
                fkar.MdiParent = this;
                fkar.Show();
            }
        }
    }
}
