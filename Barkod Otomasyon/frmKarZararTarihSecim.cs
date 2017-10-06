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
    public partial class frmKarZararTarihSecim : DevExpress.XtraEditors.XtraForm
    {
        public bool DevamEt = false;
        public DateTime ilk;
        public DateTime son;
        public frmKarZararTarihSecim()
        {
            InitializeComponent();
        }

        private void frmKarZararTarihSecim_Load(object sender, EventArgs e)
        {

        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            ilk = dtIlkTarih.DateTime;
            son = dtSonTarih.DateTime;
            if (ilk <= son)
            {
                DevamEt = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("İlk tarih son tarihten büyük olamaz", "Hata");
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DevamEt = false; this.Close();
        }
    }
}