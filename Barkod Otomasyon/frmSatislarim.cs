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
    public partial class frmSatislarim : DevExpress.XtraEditors.XtraForm
    {
        int UserID;

        public frmSatislarim(int? id)
        {
            if (id != null && id > 0)
                UserID = (int)id;
            InitializeComponent();
        }

        private void frmSatislarim_Load(object sender, EventArgs e)
        {
            Yenile();
        }
        Decimal ToplamTutarHesapla(List<Fi> liste)
        {
            decimal tutar = 0;
            foreach (Fi item in liste)
            {
                foreach (Sati satis in item.Satis)
                {
                    tutar += (decimal)satis.ToplamFiyat;
                }
            }
            return tutar;
        }
        void Yenile()
        {
            if (UserID > 0)
            {
                List<Fi> liste =  (new Islemler()).FislerimiGetir(UserID);
                gridControl1.DataSource = liste;
                txtToplamTutar.Text = ToplamTutarHesapla(liste).ToString() + " ₺";
            }
        }
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Fi fis = gridView1.GetFocusedRow() as Fi;
                if (fis != null)
                {
                    frmFisUrunleri fs = new frmFisUrunleri(fis.Id);
                    fs.ShowDialog();
                }
            }
            catch (Exception)
            {

            }
        }

        private void frmSatislarim_Activated(object sender, EventArgs e)
        {
            Yenile();
        }
    }
}