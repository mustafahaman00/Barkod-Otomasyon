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

namespace Barkod_Otomasyon
{
    public partial class frmMusteriYeni : DevExpress.XtraEditors.XtraForm
    {
        Islemler islemler = new Islemler();
        public frmMusteriYeni()
        {
            InitializeComponent();
        }

        private void frmMusteriYeni_Load(object sender, EventArgs e)
        {
            txtEkleyen.Text = User.kullanici.Adi + " " + User.kullanici.Soyadi;
        }

        private void txtAdres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Kaydet();
            }
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
                        if(islemler.MusteriEkle(txtAdiSoyadi.Text.Trim()
                            ,txtTelefon.Text.Trim(),
                            txtAdres.Text.Trim()))
                        {
                            MessageBox.Show("Müşteri başarıyla kaydedildi");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Müşteri eklenirken bir hata meydana geldi",
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


        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}