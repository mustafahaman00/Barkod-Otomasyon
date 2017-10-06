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
    public partial class frmKullaniciGiris : DevExpress.XtraEditors.XtraForm
    {
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }

        private void txtKullaniciAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Giris();
        }


        void Giris()
        {
            string KullaniciAdi = txtKullaniciAdi.Text.Trim();
            string Parola = txtParola.Text.Trim();

            if (KullaniciAdi.Length > 5 && Parola.Length > 5)
            {
                if ((new Islemler()).KullaniciVarMi(KullaniciAdi))
                {
                    Kullanici user = new Islemler().KullaniciGiris(KullaniciAdi, Parola);
                    if (user != null)
                    {
                        User.kullanici = user;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Parolanız yanlış. Lütfen tekrar deneyin", "Hata");
                        txtParola.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre en az 6 karakter olmalıdır", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Giris();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKullaniciGiris_Load(object sender, EventArgs e)
        {
            txtParola.Properties.UseSystemPasswordChar = true;
        }
    }
}