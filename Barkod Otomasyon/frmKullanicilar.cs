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
    public partial class frmKullanicilar : DevExpress.XtraEditors.XtraForm
    {
        public frmKullanicilar()
        {
            InitializeComponent();
        }
        void Yenile()
        {
            gridControl1.DataSource = (new Islemler()).KullanicilariGetir(User.kullanici.Id);
        }
        private void btnYenile_Click(object sender, EventArgs e)
        {
            Yenile();
        }

        private void frmKullanicilar_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            frmKullaniciOlustur frm = new frmKullaniciOlustur(null);
            frm.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Kullanici kull = gridView1.GetFocusedRow() as Kullanici;
            if (kull != null)
            {
                frmKullaniciOlustur f = new frmKullaniciOlustur(kull);
                f.ShowDialog();
            }
        }
    }
}