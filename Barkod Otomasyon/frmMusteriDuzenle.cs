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
    public partial class frmMusteriDuzenle : DevExpress.XtraEditors.XtraForm
    {
        Musteri musteri;
        Islemler islemler = new Islemler();
        public frmMusteriDuzenle(Musteri _musteri)
        {
            musteri = _musteri;
            InitializeComponent();
        }

        private void frmMusteriDuzenle_Load(object sender, EventArgs e)
        {
            txtAdiSoyadi.Text = musteri.AdiSoyadi;
            txtAdres.Text = musteri.Adres;
            txtEkleyen.Text = musteri.Kullanici.Adi + " " + musteri.Kullanici.Soyadi;
            txtTarih.Text = musteri.KayitTarihi.Value.ToShortDateString();
            txtTelefon.Text = musteri.Gsm;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }


        void Kaydet()
        {
            if (txtAdiSoyadi.Text.Trim().Length > 0)
            {
                if (txtTelefon.Text.Trim().Length > 9)
                {
                    if (txtAdres.Text.Trim().Length > 0)
                    {
                        if (islemler.MusteriDuzenle(musteri.Id, txtAdiSoyadi.Text.Trim()
                            , txtTelefon.Text.Trim(),
                            txtAdres.Text.Trim()))
                        {
                            MessageBox.Show("Müşteri başarıyla kaydedildi");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Müşteri düzenlenirken bir hata meydana geldi",
                                "Hata",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(txtAdres, "Lütfen bir adres giriniz");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtTelefon, "Lütfen doğru bir telefon numarası girin");
                }
            }
            else
            {
                errorProvider1.SetError(txtAdiSoyadi, "Lütfen bir isim giriniz");
            }
        }
    }
}