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
    public partial class frmFisUrunleri : DevExpress.XtraEditors.XtraForm
    {
        int fisID;
        public frmFisUrunleri(int? satilanFisID)
        {
            if (satilanFisID != null && satilanFisID > 0)
            {
                fisID = (int)satilanFisID;
            }
            InitializeComponent();
        }

        private void frmFisUrunleri_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (new Islemler()).FisinSatislariniGetir(fisID);
            txtToplamTutar.Text = (new Islemler()).FisTutariniHesapla(fisID).ToString()+" ₺";
        }
    }
}