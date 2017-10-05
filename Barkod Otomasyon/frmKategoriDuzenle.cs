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
    public partial class frmKategoriDuzenle : DevExpress.XtraEditors.XtraForm
    {
        public int KategoriId = 0;
        Kategori kategori;
        public frmKategoriDuzenle(int _KategoriId)
        {
            KategoriId = _KategoriId;
            kategori = (new Islemler()).KategoriBul(KategoriId);
            InitializeComponent();
        }

        private void frmKategoriDuzenle_Load(object sender, EventArgs e)
        {

            if (kategori != null)
            {
                txtKategoriAdi.Text = kategori.KategoriAdi;
            }
            else
            {
                MessageBox.Show("Kategori  bilgileri alınırken bir hata meydana geldi");
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKategoriDuzenleKaydet_Click(object sender, EventArgs e)
        {
            kaydet();

        }

        private void txtKategoriAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        void kaydet()
        {
            if (txtKategoriAdi.Text.Length > 0)
            {
                if (!Char.IsDigit(txtKategoriAdi.Text.Trim()[0]))
                {
                    if ((new Islemler()).KategoriDuzenle(kategori.Id, txtKategoriAdi.Text) == true)
                    {
                        MessageBox.Show("Kategori Başarıyla Kaydedildi");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Kategori kaydedilirken bir hata meydana geldi", "Hata"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Kategori adı rakamla başlayamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kategori adı girmelisiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}