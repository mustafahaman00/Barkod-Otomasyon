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
    public partial class frmGenelSatislarOn : DevExpress.XtraEditors.XtraForm
    {
        public DateTime IlkTarih;
        public DateTime SonTarih;
        public bool TumSatislar = false;
        public bool DevamEt = false;
        public frmGenelSatislarOn()
        {
            InitializeComponent();
        }

        private void frmGenelSatislarOn_Load(object sender, EventArgs e)
        {
            dtIlkTarih.DateTime = DateTime.Now;
            dtSonTarih.DateTime = DateTime.Now;
        }


        void TumSatislarAktif()
        {
            TumSatislar = true;
            dtIlkTarih.Enabled = false;
            dtSonTarih.Enabled = false;
        }

        void TumSatislarPasif()
        {
            TumSatislar = false;
            dtIlkTarih.Enabled = true;
            dtSonTarih.Enabled = true;
        }

        private void chkTumSatislar_CheckedChanged(object sender, EventArgs e)
        {
            if (!TumSatislar) TumSatislarAktif();
            else TumSatislarPasif();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            if (TumSatislar)
            {
                DevamEt = true;
                this.Close();
            }
            else
            {
                IlkTarih = dtIlkTarih.DateTime;
                SonTarih = dtSonTarih.DateTime;

                TimeSpan ilksaat = new TimeSpan(00, 00, 0);
                IlkTarih = IlkTarih.Date + ilksaat;

                TimeSpan sonsaat = new TimeSpan(23, 59, 59);
                SonTarih = SonTarih.Date + sonsaat;

                //MessageBox.Show(IlkTarih.ToShortTimeString() + "\n" + SonTarih.ToShortTimeString());
                if (IlkTarih <= SonTarih)
                {
                    DevamEt = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("İlk tarih son tarihten büyük olamaz");
                }
            }

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}