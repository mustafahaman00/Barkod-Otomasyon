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
    public partial class frmKategoriler : DevExpress.XtraEditors.XtraForm
    {
        Islemler islemler = new Islemler();
        public frmKategoriler()
        {
            InitializeComponent();
        }

        public void Hata(String _icerik)
        {
            MessageBox.Show(_icerik, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Bilgi(String _icerik)
        {
            MessageBox.Show(_icerik, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void ListeYenile()
        {
            gridControl1.DataSource = (new Islemler()).Kategoriler();
            //islemler.Kategoriler();
            //gridView1.PopulateColumns();

        }
        public void KategoriEkle()
        {
            string adi = txtKategoriAdi.Text.Trim();
            if (Char.IsDigit(adi[0]))
            {
                Hata("Kategori adı rakamla başlayamaz");
            }
            else
            {
                if (islemler.KategoriBul(adi) == null)
                {
                    if (islemler.KategoriEkle(adi) == true)
                    {
                        Bilgi("Kategori başarıyla eklendi");
                        txtKategoriAdi.Text = "";
                    }
                    else
                    {
                        Hata("Kategori eklenirken bir hata meydana geldi");
                    }
                }
                else
                {
                    Hata("Eklemeye çalıştığınız kategori zaten mevcut");
                }
            }
            ListeYenile();
        }
        private void btnKategoriKaydet_Click(object sender, EventArgs e)
        {
            KategoriEkle();
        }

        private void txtKategoriAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KategoriEkle();
            }
        }

        private void frmKategoriler_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = islemler.Kategoriler();
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            Kategori kategori = gridView1.GetFocusedRow() as Kategori;
            if (kategori != null)
            {
                if (islemler.KategoriUrunleri(kategori.KategoriAdi).Count < 1)
                {
                    DialogResult result =
                        MessageBox.Show("Kategoriyi silmek istediğinizden emin misiniz?", "Onay",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (islemler.KategoriSil(kategori.Id) == true)
                        {
                            Bilgi("Kategori başarıyla silindi");
                            ListeYenile();
                        }
                        else
                        {
                            Hata("Kategori silinirken bir hata meydana geldi");
                        }
                    }


                }
                else
                {
                    Hata("Bu kategoriye ait ürünler olduğu için bunu silemezsiniz.");
                }
            }
            else
            {
                MessageBox.Show("Silmek için önce bir kategori seçmelisiniz");
            }
        }

        private void btnKategoriDuzenle_Click(object sender, EventArgs e)
        {
            Kategori kategori = gridView1.GetFocusedRow() as Kategori;
            if (kategori != null)
            {
                Kategori _kategori = islemler.KategoriBul(kategori.KategoriAdi);
                if (_kategori != null)
                {
                    frmKategoriDuzenle frm = new frmKategoriDuzenle(_kategori.Id);
                    frm.FormClosed += frm_FormClosed;
                    frm.ShowDialog();
                }
            }

        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListeYenile();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ListeYenile();
        }

    }
}