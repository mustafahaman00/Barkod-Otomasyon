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
    public partial class frmBorcMusteri : DevExpress.XtraEditors.XtraForm
    {
        public Musteri musteri;
        public frmBorcMusteri(Musteri mus)
        {
            musteri = mus;
            InitializeComponent();
        }

        private void frmBorcMusteri_Load(object sender, EventArgs e)
        {
            if (musteri != null)
            {
                string baslik = musteri.AdiSoyadi + " Fişleri";
                this.Text = baslik;
                Yenile();
            }
            else
            {
                MessageBox.Show("Müşteri fişleri yüklenirken bir hata meydana geldi. Müşteri tanınmıyor");
            }
        }
        void Yenile()
        {
            gridControl1.DataSource = (new Islemler()).MusteriFisleri(musteri.Id);
        }

        frmBorcTahsil fTahsil;
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Fi secilenFis = gridView1.GetFocusedRow() as Fi;
            if (secilenFis != null)
            {
                if (secilenFis.OdendiMi == false)
                {
                    fTahsil = new frmBorcTahsil(secilenFis);
                    fTahsil.FormClosed += fTahsil_FormClosed;
                    fTahsil.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bu fiş zaten ödenmiş");
                }

            }
        }

        void fTahsil_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fTahsil.OdendiMi)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Tahsilatı yapmadığınız belirlendi.", "Bilgi");
            }
        }

        private void frmBorcMusteri_Activated(object sender, EventArgs e)
        {
            Yenile();
        }
    }
}