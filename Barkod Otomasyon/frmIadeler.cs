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
    public partial class frmIadeler : DevExpress.XtraEditors.XtraForm
    {
        public frmIadeler()
        {
            InitializeComponent();
        }

        private void frmIadeler_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        void Yenile()
        {
            gridControl1.DataSource = new Islemler().IadeleriGetir();
        }

        private void frmIadeler_Activated(object sender, EventArgs e)
        {
            Yenile();
        }
    }
}