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
    public partial class frmUrunListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmUrunListesi()
        {
            InitializeComponent();
        }

        private void frmUrunListesi_Load(object sender, EventArgs e)
        {

            Yenile();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Urun urun = gridView1.GetFocusedRow() as Urun;
            if (urun != null)
            {
                txtUrunAdi.Text = urun.UrunAdi;

            }
        }
        frmUrunEkle frmUrunDuzen;
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Urun urun = gridView1.GetFocusedRow() as Urun;
            if (urun != null)
            {
                frmUrunDuzen = new frmUrunEkle(urun);
                frmUrunDuzen.FormClosed += frmUrunDuzen_FormClosed;
                frmUrunDuzen.ShowDialog();
            }
        }

        void frmUrunDuzen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Yenile();
        }

        void Yenile()
        {
            gridControl1.DataSource = (new Islemler()).UrunleriListele();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Yenile();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Urun urun = gridView1.GetFocusedRow() as Urun;
            if (urun != null)
            {
                if (urun.Satis.Count == 0)
                {
                    DialogResult result =
                        MessageBox.Show(urun.UrunAdi + " adlı ürünü silmek istediğinizden emin misiniz?",
                        "Onay",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if ((new Islemler()).UrunSil(urun.Id))
                        {
                            MessageBox.Show("Ürün başarıyla silindi.");
                            Yenile();
                        }
                    }



                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçiniz");
            }
        }
    }
}