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
    public partial class frmSatisSon : DevExpress.XtraEditors.XtraForm
    {
        public bool OdendiMi = false;
        public decimal Tutar;
        public frmSatisSon()
        {
            InitializeComponent();
        }

        private void frmSatisSon_Load(object sender, EventArgs e)
        {

        }

        private void txtAlinanTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char c = e.KeyChar;
            if (!Char.IsDigit(c))
            {
                if (!Char.IsControl(c))
                {
                    if (c == ',')
                    {
                        if (txtAlinanTutar.Text.Contains(',') || txtAlinanTutar.Text.Length < 1)
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

        void OdemeAl()
        {
            if (txtAlinanTutar.Text == "00,00")
            {
                OdendiMi = true;
                this.Close();
            }
            else
            {
                decimal alinanTutar = Decimal.Parse(txtAlinanTutar.Text);
                decimal alinacakTutar = Tutar;

                decimal kalan = alinanTutar - alinacakTutar;
                if (kalan > 0)
                {
                    txtParaUstu.Text = kalan.ToString();
                    MessageBox.Show("Para Üstü : " + kalan.ToString() + " ₺");
                    OdendiMi = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Alınan Para ödenecek tutardan azdır");
                    txtAlinanTutar.Text = "";
                }
            }

        }




        private void txtAlinanTutar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OdemeAl();
            }
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            OdemeAl();
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            OdendiMi = false;
            this.Close();
        }

    }
}