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
        public string Baslik = "";
        List<KarZararUrunu> liste;
        public frmKarZararUrunleri(List<KarZararUrunu> _liste)
        {
            liste = _liste;
            InitializeComponent();
        }

        private void frmKarZararUrunleri_Load(object sender, EventArgs e)
        {
            this.Text = Baslik;
            if (liste != null)
            {
                gridControl1.DataSource = liste;
            }
        }
    }
}