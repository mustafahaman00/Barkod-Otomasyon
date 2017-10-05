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
    public partial class frmMusteriListesi : DevExpress.XtraEditors.XtraForm
    {
        Islemler islemler = new Islemler();
        public frmMusteriListesi()
        {
            InitializeComponent();
        }
        void Yenile()
        {
            gridControl1.DataSource = (new Islemler()).MusteriListele();
            
        }
        private void btnYenile_Click(object sender, EventArgs e)
        {
            Yenile();
        }

        private void frmMusteriListesi_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            frmMusteriYeni frm = new frmMusteriYeni();
            frm.FormClosed += frm_FormClosed;
            frm.ShowDialog();
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Yenile();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Musteri musteri = gridView1.GetFocusedRow() as Musteri;
            if (musteri != null)
            {
                string musteriadi = musteri.AdiSoyadi;
                DialogResult result = MessageBox.Show(
                    musteriadi + " adlı müşteriyi düzenlemek istediğinizden emin misiniz?",
                    "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes)
                {
                    frmMusteriDuzenle f1 = new frmMusteriDuzenle(musteri);
                    f1.FormClosed += f1_FormClosed;
                    f1.ShowDialog()
                        ;
                }
            }
            else
            {

            }
        }

        void f1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Yenile();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Musteri musteri = gridView1.GetFocusedRow() as Musteri;
            if (musteri != null)
            {

                if (islemler.MusteriFisleri(musteri.Id).Count < 1)
                {
                    string musteriadi = musteri.AdiSoyadi;
                    DialogResult result = MessageBox.Show(
                        musteriadi + " adlı müşteriyi düzenlemek istediğinizden emin misiniz?",
                        "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                        );
                    if (result == DialogResult.Yes)
                    {
                        if (islemler.MusteriSil(musteri.Id))
                        {
                            MessageBox.Show("Müşteri başarıyla silindi");
                            Yenile();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Müşteri silinirken bir hata meydana geldi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bu müşteriye ait fişler bulunuyor. Bu müşteriyi silemezsiniz!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void frmMusteriListesi_Activated(object sender, EventArgs e)
        {
            Yenile();
        }
    }
}