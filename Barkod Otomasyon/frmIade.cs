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
    public partial class frmIade : DevExpress.XtraEditors.XtraForm
    {
        public Musteri musteri;
        public Urun urun;
        public frmIade(Musteri ms)
        {
            if (ms != null)
            {
                musteri = ms;
            }
            else
            {
                this.Close();
            }
            InitializeComponent();
        }

        private void frmIade_Load(object sender, EventArgs e)
        {
            txtMusteriAdi.Text = musteri.AdiSoyadi;
            txtMusteriTelefon.Text = musteri.Gsm;
            txtMusteriAdresi.Text = musteri.Adres;

            txtKullaniciadi.Text = User.kullanici.Adi + " " + User.kullanici.Soyadi;
            if (User.kullanici.AdminMi == true)
            {
                txtKullaniciYetkisi.Text = "Yönetici";
            }
            else
            {
                txtKullaniciYetkisi.Text = "Personel";
            }

        }

        private void nmrAdet_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal sayi = Decimal.Parse(txtUrunFiyati.Text);
                if (sayi > 0)
                {
                    int adet = (int)nmrAdet.Value;
                    lblToplamTutar.Text = (adet * sayi).ToString();
                }
            }
            catch (Exception) { }
        }

        private void txtUrunFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char c = e.KeyChar;
            if (!Char.IsDigit(c))
            {
                if (!Char.IsControl(c))
                {
                    if (c == ',')
                    {
                        if (txtUrunFiyati.Text.Contains(',') || txtUrunFiyati.Text.Length < 1)
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }

            }
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) UrunBul();
        }
        void UrunBul()
        {
            if (txtBarkod.Text.Length > 0)
            {
                Urun bulunanUrun = (new Islemler()).UrunGetir(txtBarkod.Text);
                if (bulunanUrun != null)
                {
                    lblUrunAdi.Text = bulunanUrun.UrunAdi;
                    lblUrunFiyati.Text = bulunanUrun.SatisFiyati.ToString() + " ₺";
                    txtUrunFiyati.Text = bulunanUrun.SatisFiyati.ToString();
                    txtBarkod.Text = "";
                    urun = bulunanUrun;
                    lblToplamTutar.Text = bulunanUrun.SatisFiyati.ToString();
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı");
                    lblUrunFiyati.Text = "";
                    lblUrunAdi.Text = "";
                    urun = null;
                    txtBarkod.Text = "";
                    lblToplamTutar.Text = "00,00";

                }
            }
            else
            {
                MessageBox.Show("Bir barkod girmelisiniz");
            }

        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            UrunBul();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string aciklama = txtAciklama.Text;
            if (aciklama.Length > 5)
            {
                if (urun != null)
                {
                    if (musteri != null)
                    {
                        try
                        {
                            decimal birimFiyat = Decimal.Parse(txtUrunFiyati.Text);
                            decimal toplamTutar = Decimal.Parse(lblToplamTutar.Text);

                            DialogResult result =
                                                   MessageBox.Show(musteri.AdiSoyadi + " adlı müşteriden \n" +
                                                   urun.UrunAdi + " adlı üründen " + nmrAdet.Value.ToString() + " adet \n" +
                                                   "Toplamda " + toplamTutar.ToString() + " ₺ değerinde iade almak istediğinize emin misiniz?",
                                                   "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                bool durum = new Islemler().IadeKaydet(urun.Id, (int)nmrAdet.Value,
                                    musteri.Id, birimFiyat, toplamTutar, aciklama);
                                if (durum == true)
                                {
                                    MessageBox.Show("Iade işlemi tamamlanmıştır");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Iade alınırken bir hata meydana geldi");
                                }
                            }
                        }
                        catch (Exception)
                        {

                        }

                    }
                    else
                    {
                        string mesaj = "Musteri bulunamadı. Bir hata oluştu";
                        MessageBox.Show(mesaj);
                    }
                }
                else
                {
                    string mesaj = "Ürün seçmeden iade alamazsınız";
                    MessageBox.Show(mesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("En az 5 karakterli bir açıklama girmeniz gerekiyor");
            }
           
        }
    }
}