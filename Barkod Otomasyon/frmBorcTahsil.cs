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
    public partial class frmBorcTahsil : DevExpress.XtraEditors.XtraForm
    {
        Fi fis;
        public bool OdendiMi = false;
        public frmBorcTahsil(Fi _fi)
        {
            fis = _fi;
            InitializeComponent();
        }

        private void frmBorcTahsil_Load(object sender, EventArgs e)
        {
            if (fis != null)
            {
                gridControl1.DataSource = new Islemler().FisSatislariniGetir(fis);
            }
        }

        private void btnTahsilat_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("Ödeme alındı olarak kaydedilecektir. Devam etmek istiyor musunuz?"
                , "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OdendiMi = true;
                if ((new Islemler()).BorcFisineOdemeYap(fis.Id))
                {
                    MessageBox.Show("Ödemeniz kaydedildi");
                    this.Close();
                }
            }
        }
    }
}