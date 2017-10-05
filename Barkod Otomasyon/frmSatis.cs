using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Barkod_Otomasyon.Models;
namespace Barkod_Otomasyon
{
    public partial class frmSatis : DevExpress.XtraEditors.XtraForm
    {
        SatisUrunu guncellenecek = null;

        Islemler islemler = new Islemler();
        List<SatisUrunu> urunler = new List<SatisUrunu>();
        public frmSatis()
        {
            InitializeComponent();
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Ekle();
            if (e.KeyCode == Keys.F5) Satis();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        void Ekle()
        {
            string barkod = txtBarkod.Text.Trim();
            if (barkod.Length > 0)
            {
                Urun urun = islemler.UrunGetir(barkod);
                if (urun != null)
                {
                    int adet = Convert.ToInt32(nmrAdet.Value);
                    SatisUrunu satisUrun = new SatisUrunu
                    {
                        adet = adet,
                        adetFiyat = (decimal)urun.SatisFiyati,
                        urun = urun,
                        toplamFiyat = adet * (decimal)urun.SatisFiyati,
                        adetAlisFiyati = (decimal)urun.AlisFiyati
                    };
                    UrunlerListesineEkle(satisUrun);
                    txtBarkod.Text = "";
                    nmrAdet.Value = 1;
                    txtBarkod.Focus();


                }
                else
                {
                    MessageBox.Show("Girdiğiniz barkod kayıtlı değildir");
                    txtBarkod.Text = "";
                }
            }
        }
        void UrunlerListesineEkle(SatisUrunu urun)
        {
            bool varmi = false;
            foreach (SatisUrunu item in urunler)
            {
                if (item.urun == urun.urun)
                {
                    item.adet = item.adet + urun.adet;
                    item.toplamFiyat = item.adet * item.adetFiyat;
                    varmi = true;
                }
            }
            if (!varmi)
            {
                urunler.Add(urun);
            }
            BilgileriDoldur(urun);
            ListeyiYenile();
        }

        void ListeyiYenile()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = urunler;
            //gridView1.PopulateColumns();


            decimal toplamtutar = 0;
            foreach (SatisUrunu item in urunler)
            {
                decimal tutar = item.adet * item.adetFiyat;
                toplamtutar += tutar;
            }
            txtTutar.Text = toplamtutar.ToString() + " ₺";
        }


        void BilgileriDoldur(SatisUrunu urun)
        {
            foreach (SatisUrunu item in urunler)
            {
                if (item.urun == urun.urun)
                {
                    txtUrunAdi.Text = urun.urun.UrunAdi;
                    txtFiyati.Text = urun.adetFiyat.ToString();
                    txtTedarikci.Text = urun.urun.Tedarikci.FirmaAdi;
                    nmrGuncellenecekAdet.Value = item.adet;
                }
                guncellenecek = urun;
            }


            string resimYolu = urun.urun.ResimYolu;
            if (!String.IsNullOrEmpty(resimYolu))
            {
                if (System.IO.File.Exists(resimYolu))
                {
                    Image img = Image.FromFile(resimYolu);
                    pctResim.Image = img;
                }
            }
        }
        void Guncelle()
        {
            int adet = Convert.ToInt32(nmrGuncellenecekAdet.Value);
            if (guncellenecek != null)
            {
                foreach (SatisUrunu item in urunler)
                {
                    if (item.urun == guncellenecek.urun)
                    {
                        item.adet = adet;
                    }
                }
                ListeyiYenile();
                BilgileriDoldur(guncellenecek);

            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void nmrGuncellenecekAdet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Guncelle();
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            cmbMusteri.DataSource = islemler.MusteriListele();
            cmbMusteri.ValueMember = "Id";
            cmbMusteri.DisplayMember = "AdiSoyadi";



        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            SatisUrunu urun = urunler.Where(x => x.urun.Id == guncellenecek.urun.Id).FirstOrDefault();
            if (urun != null)
            {
                DialogResult result = MessageBox.Show("Ürünü çıkarmak istediğinizden emin misiniz?",
                    "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    urunler.Remove(urun);
                    ListeyiYenile();
                }
            }
        }
        void BilgileriBosalt()
        {
            pctResim.Image = null;
            txtUrunAdi.Text = "";
            txtTedarikci.Text = "";
            txtFiyati.Text = "";
            nmrAdet.Value = 1;
            guncellenecek = null;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                SatisUrunu urun = gridView1.GetFocusedRow() as SatisUrunu;
                if (urun != null)
                {
                    guncellenecek = urun;
                    BilgileriDoldur(guncellenecek);
                }
            }
            catch (Exception) { }
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            Satis();
        }
        frmSatisSon satisson;
        private decimal ToplamTutarHesapla()
        {
            decimal toplam = 0;
            foreach (SatisUrunu item in urunler)
            {
                toplam += item.toplamFiyat;
            }
            return toplam;
        }
        private void Satis()
        {
            if (urunler.Count > 0)
            {
                satisson = new frmSatisSon();
                satisson.Tutar = ToplamTutarHesapla();
                satisson.FormClosing += f_FormClosing;
                satisson.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ürün eklemelisiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        void f_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (satisson.OdendiMi)
            {
                Musteri musteri = cmbMusteri.SelectedItem as Musteri;
                Fi fis = islemler.YeniOdenmisFisOlustur(User.kullanici.Id, musteri.Id);
                if (fis != null)
                {
                    if (islemler.UrunleriFiseKaydet(urunler, fis))
                    {
                        MessageBox.Show("Satış kaydedildi");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Fis olusturulurken bir hata meydana geldi");
                }

            }
        }

        private void btnBorc_Click(object sender, EventArgs e)
        {
            if (urunler.Count > 0)
            {
                Musteri musteri = cmbMusteri.SelectedItem as Musteri;
                if (musteri != null)
                {
                    DialogResult result = MessageBox.Show("Hesabı " + musteri.AdiSoyadi + " adlı müşteriye borç olarak kaydetmek istediğinizden emin misiniz?", "Onay",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        BorcKaydet();
                    }

                }
                else
                {
                    MessageBox.Show("Bir müşteri seçmeniz gerekir. Eğer müşteri seçmeyecekseniz sadece PeşinSatış isminde cari oluşturabilirsiniz.");
                }
            }
            else
            {
                MessageBox.Show("Ürün eklemeniz gerekir", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void BorcKaydet()
        {
            Musteri musteri = cmbMusteri.SelectedItem as Musteri;
            if (musteri != null)
            {
                Fi fis = islemler.YeniBorcFisOlustur(User.kullanici.Id, musteri.Id);
                if (fis != null)
                {
                    if (islemler.UrunleriFiseKaydet(urunler, fis))
                    {
                        MessageBox.Show("Satış kaydedildi");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Fiş oluşturulurken bir hata meydana geldi");
                }




            }
            else
            {
                MessageBox.Show("Müşteri seçilirken bir hata meydana geldi.");
            }

        }
    }
}