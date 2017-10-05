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
    public partial class frmGenelSatislar : DevExpress.XtraEditors.XtraForm
    {
        List<Fi> liste;
        public frmGenelSatislar(List<Fi> _liste)
        {
            liste = _liste;
            InitializeComponent();

        }

        private void frmGenelSatislar_Load(object sender, EventArgs e)
        {
            if (liste != null && liste.Count > 0)
            {
                gridControl1.DataSource = liste;
                txtToplam.Text = ToplamTutariGetir().ToString() + " ₺";
            }
        }

        Decimal ToplamTutariGetir()
        {
            Decimal toplam = 0;
            foreach (Fi item in liste)
            {
                foreach (Sati _item in item.Satis)
                {
                    toplam += (decimal)_item.ToplamFiyat;
                }
            }
            return toplam;
        }
    }
}