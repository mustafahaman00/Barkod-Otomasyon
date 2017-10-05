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
    public partial class frmUrunEkle : DevExpress.XtraEditors.XtraForm
    {
        Urun degisecekUrun;
        Islemler islemler = new Islemler();
        public frmUrunEkle(Urun urun)
        {
            degisecekUrun = urun;
            InitializeComponent();
        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            cmbKategori.DataSource = islemler.Kategoriler();
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbTedarikci.ValueMember = "Id";

            cmbTedarikci.DataSource = islemler.TedarikciListesi();
            cmbTedarikci.DisplayMember = "FirmaAdi";
            cmbTedarikci.ValueMember = "Id";

            if (degisecekUrun != null)
            {
                txtBarkod.Text = degisecekUrun.Barkod;
                txtUrunAdi.Text = degisecekUrun.UrunAdi;
                txtAlisFiyati.Text = degisecekUrun.AlisFiyati.ToString();
                txtSatisFiyati.Text = degisecekUrun.SatisFiyati.ToString();
                txtAciklama.Text = degisecekUrun.Aciklama;

                if (!string.IsNullOrEmpty(degisecekUrun.ResimYolu))
                {
                    txtResimYolu.Text = degisecekUrun.ResimYolu;
                    if (System.IO.File.Exists(txtResimYolu.Text))
                    {
                        Image resim = Image.FromFile(txtResimYolu.Text);
                        pctResim.Image = resim;
                    }
                }
            }
        }
        void ResimSil(string yol)
        {
            if (System.IO.File.Exists(yol))
            {
                System.IO.File.Delete(yol);
            }
        }
        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (op.ShowDialog() == DialogResult.OK)
            {
                Image img = ScaleImage(Image.FromFile(op.FileName), 250, 250);
                pctResim.Image = img;
                Guid gid = Guid.NewGuid();
                string anayol = Application.StartupPath;
                string dosyayolu = anayol + "/Resimler/" + gid.ToString() + ".jpg";
                img.Save(dosyayolu);
                if (txtResimYolu.Text.Length > 0)
                {
                    ResimSil(txtResimYolu.Text);
                }
                txtResimYolu.Text = dosyayolu;
            }
        }
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }


        private void txtAlisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char c = e.KeyChar;
            if (!Char.IsDigit(c))
            {
                if (!Char.IsControl(c))
                {
                    if (c == ',')
                    {
                        if (txtAlisFiyati.Text.Contains(',') || txtAlisFiyati.Text.Length < 1)
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

        private void txtSatisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char c = e.KeyChar;
            if (!Char.IsDigit(c))
            {
                if (!Char.IsControl(c))
                {
                    if (c == ',')
                    {
                        if (txtSatisFiyati.Text.Contains(',') || txtSatisFiyati.Text.Length < 1)
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        ErrorProvider hata = new ErrorProvider();
        bool hatalariKontrolEt()
        {

            if (txtUrunAdi.Text.Length < 1)
            {
                hata.SetError(txtUrunAdi, "Lütfen bir ürün adı giriniz");
                txtUrunAdi.Focus();
                return false;
            }
            else
            {
                hata.SetError(txtUrunAdi, "");
            }

            ////////////

            if (txtAlisFiyati.Text.Length < 1)
            {
                hata.SetError(txtAlisFiyati, "Lütfen bir alış fiyatı giriniz");
                txtAlisFiyati.Focus();
                return false;
            }
            else
            {
                hata.SetError(txtAlisFiyati, "");
            }

            ////////////

            if (txtSatisFiyati.Text.Length < 1)
            {
                txtSatisFiyati.Focus();
                hata.SetError(txtSatisFiyati, "Lütfen bir satış fiyatı belirleyin");
                return false;
            }
            else
            {
                hata.SetError(txtSatisFiyati, "");
            }
            /////////
            if (txtBarkod.Text.Length < 1)
            {
                txtBarkod.Focus();
                hata.SetError(txtBarkod, "Lütfen bir barkod giriniz");
                return false;
            }
            else
            {
                hata.SetError(txtBarkod, "");
            }
            //////////////Kategori ve Tedarikçi Kontrolleri/////////////

            Kategori kategori = cmbKategori.SelectedItem as Kategori;
            Tedarikci tedarikci = cmbTedarikci.SelectedItem as Tedarikci;
            if (kategori == null)
            {
                cmbKategori.Focus();
                hata.SetError(cmbKategori, "Kategori seçmeniz gerekir. \nEğer kategori yoksa önce kategori ekleyiniz.");
                return false;
            }
            else { hata.SetError(cmbKategori, ""); }

            if (tedarikci == null)
            {
                cmbTedarikci.Focus();
                hata.SetError(cmbTedarikci, "Tedarikçi seçmeniz gerekiyor.\nEğer tedarikçi yoksa önce tedarikçi  eklemeniz gerekiyor.");
                return false;
            }
            else { hata.SetError(cmbTedarikci, ""); }


            return true;
        }



        private void txtAciklama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Kaydet();
            if (e.KeyCode == Keys.Escape) this.Close();
        }




        void Kaydet()
        {
            if (degisecekUrun == null)
            {
                if (hatalariKontrolEt())
                {
                    Urun urun = islemler.UrunGetir(txtBarkod.Text);

                    if (urun == null)
                    {
                        Kategori kategori = cmbKategori.SelectedItem as Kategori;
                        Tedarikci tedarikci = cmbTedarikci.SelectedItem as Tedarikci;
                        Decimal alisFiyati = Decimal.Parse(txtAlisFiyati.Text);
                        Decimal satisFiyati = Decimal.Parse(txtSatisFiyati.Text);
                        if (islemler.UrunEkle(
                           txtUrunAdi.Text.Trim(),
                           kategori,
                           tedarikci,
                           txtBarkod.Text,
                           alisFiyati,
                           satisFiyati,
                           txtAciklama.Text,
                           DateTime.Now,
                           txtResimYolu.Text,
                           User.kullanici.Id))
                        {
                            MessageBox.Show("Ürün başarıyla eklendi");
                            Temizle();
                        }
                        else
                        {
                            MessageBox.Show("Ürün eklenirken bir hata meydana geldi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu barkod *" + urun.UrunAdi + "* adlı üründe kayıtlıdır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBarkod.Text = "";
                        txtBarkod.Focus();
                    }


                }
            }
            else
            {
                if (hatalariKontrolEt())
                {
                    int sayi = islemler.UrunleriListele().Where(x => x.Barkod == txtBarkod.Text).ToList().Count;
                    if (sayi == 1)
                    {
                        Urun urun = islemler.UrunGetir(txtBarkod.Text);
                        if (urun.Barkod == degisecekUrun.Barkod)
                        {
                            Kategori kategori = cmbKategori.SelectedItem as Kategori;
                            Tedarikci tedarikci = cmbTedarikci.SelectedItem as Tedarikci;
                            Decimal alisFiyati = Decimal.Parse(txtAlisFiyati.Text);
                            Decimal satisFiyati = Decimal.Parse(txtSatisFiyati.Text);
                            if (islemler.UrunDuzenle(
                                degisecekUrun.Id,
                               txtUrunAdi.Text.Trim(),
                               kategori,
                               tedarikci,
                               txtBarkod.Text,
                               alisFiyati,
                               satisFiyati,
                               txtAciklama.Text,
                               DateTime.Now,
                               txtResimYolu.Text,
                               User.kullanici.Id))
                            {
                                MessageBox.Show("Ürün başarıyla düzenlendi");
                                Temizle();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Ürün düzenlenirken bir hata meydana geldi");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bu barkodda farklı bir ürün var zaten", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else if (sayi < 1)
                    {
                        Kategori kategori = cmbKategori.SelectedItem as Kategori;
                        Tedarikci tedarikci = cmbTedarikci.SelectedItem as Tedarikci;
                        Decimal alisFiyati = Decimal.Parse(txtAlisFiyati.Text);
                        Decimal satisFiyati = Decimal.Parse(txtSatisFiyati.Text);
                        if (islemler.UrunDuzenle(
                            degisecekUrun.Id,
                           txtUrunAdi.Text.Trim(),
                           kategori,
                           tedarikci,
                           txtBarkod.Text,
                           alisFiyati,
                           satisFiyati,
                           txtAciklama.Text,
                           DateTime.Now,
                           txtResimYolu.Text,
                           User.kullanici.Id))
                        {
                            MessageBox.Show("Ürün başarıyla düzenlendi");
                            Temizle();
                        }
                        else
                        {
                            MessageBox.Show("Ürün düzenlenirken bir hata meydana geldi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu barkod birden fazla üründe kullanılmış. Tekrar kullanamazsınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBarkod.Text = "";
                        txtBarkod.Focus();
                    }


                }
            }


        }


        void Temizle()
        {
            foreach (Object item in this.Controls)
            {
                try
                {
                    TextEdit text = (TextEdit)item;
                    text.Text = "";
                }
                catch (Exception)
                {

                }

            }
            txtUrunAdi.Focus();
            degisecekUrun = null;
            pctResim.Image = null;
        }
    }
}