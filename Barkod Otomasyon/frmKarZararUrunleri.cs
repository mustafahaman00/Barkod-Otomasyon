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
    public partial class frmKarZararUrunleri : DevExpress.XtraEditors.XtraForm
    {
        List<KarZararUrunu> liste;
        public frmKarZararUrunleri(List<KarZararUrunu> _liste,string baslik)
        {
            liste = _liste;
            this.Text = baslik;
            InitializeComponent();
        }

        private void frmKarZararUrunleri_Load(object sender, EventArgs e)
        {
            if (liste != null)
            {
                gridControl1.DataSource = liste;
            }
        }
    }
}