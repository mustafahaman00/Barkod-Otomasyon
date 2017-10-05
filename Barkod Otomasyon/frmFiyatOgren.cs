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
    public partial class frmFiyatOgren : DevExpress.XtraEditors.XtraForm
    {
        public frmFiyatOgren()
        {
            InitializeComponent();
        }

        private void frmFiyatOgren_Load(object sender, EventArgs e)
        {

        }
        ErrorProvider hata = new ErrorProvider();
        private void btnBul_Click(object sender, EventArgs e)
        {
            Ogren();

        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char c = e.KeyChar;
            if (!char.IsControl(c))
            {
                if (!Char.IsDigit(c))
                {
                    e.Handled = true;
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
                catch (Exception) { }

            }
            pctResim.Image = null;
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ogren();
            }
        }
        void Ogren()
        {
            if (txtBarkod.Text.Length > 0)
            {
                hata.SetError(txtBarkod, "");
                Urun urun = (new Islemler()).UrunGetir(txtBarkod.Text);
                if (urun == null)
                {
                    MessageBox.Show("Bu barkod ile bir ürün bulunamadı.",
                        "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Temizle();
                }
                else
                {
                    txtSatisFiyati.Text = urun.SatisFiyati.ToString();
                    txtTedarikci.Text = urun.Tedarikci.FirmaAdi;
                    txtUrun.Text = urun.UrunAdi;

                    string resimyolu = urun.ResimYolu;
                    if (!String.IsNullOrEmpty(resimyolu))
                    {
                        Image resim = Image.FromFile(resimyolu);
                        pctResim.Image = resim;
                    }
                    else
                    {
                        String yer = Application.StartupPath + "/Resimler/ResimYok.jpg";
                        Image img = Image.FromFile(yer);
                        pctResim.Image = img;
                    }
                }
            }
            else
            {
                hata.SetError(txtBarkod, "Lütfen bir barkod giriniz");
            }
        }

    }
}