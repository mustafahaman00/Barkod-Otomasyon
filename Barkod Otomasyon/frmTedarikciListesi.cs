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
    public partial class frmTedarikciListesi : DevExpress.XtraEditors.XtraForm
    {
        Islemler islemler = new Islemler();
        Tedarikci tedarikci = null;
        public frmTedarikciListesi()
        {
            InitializeComponent();
        }
        void Yenile()
        {
            gridControl1.DataSource = (new Islemler()).TedarikciListesi();
        }
        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {            
                Tedarikci ted = gridView1.GetFocusedRow() as Tedarikci;
                if (ted != null)
                {
                    if (islemler.TedarikciUrunleri(ted.Id).Count < 1)
                    {
                        DialogResult result = MessageBox.Show(
                            "Tedarikçiyi silmek istediğinizden emin misiniz?",
                            "Onay",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (islemler.TedarikciSil(ted.Id))
                            {
                                MessageBox.Show("Tedarikçi başarıyla silindi");
                                Yenile();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Tedarikçi silinirken bir hata meydana geldi!",
                                    "Hata",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tedarikçinin ürünleri hala elinizde var.\nBu durumda tedarikçiyi kaldıramazsınız!",
                            "Hata",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception) { }

                 
        }
        ErrorProvider hata = new ErrorProvider();
        void Kaydet()
        {
            string firmaadi = txtFirmaAdi.Text.Trim();
            string telefon = txtTelefon.Text.Trim();
            string adres = txtAdres.Text.Trim();
            if (firmaadi.Length>1)
            {
                if (telefon.Length == 10 || telefon.Length == 11)
                {
                    if (adres.Length > 0)
                    {
                        if (tedarikci == null)
                        {
                            if (islemler.TedarikciEkle(firmaadi, telefon, adres))
                            {
                                MessageBox.Show("Tedarikçi başarıyla eklendi.");
                                Yenile();
                                EklemeModunaGec();

                            }
                            else
                            {
                                MessageBox.Show("Tedarikçi eklenirken bir hata meydana geldi",
                                    "Hata",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            if (islemler.TedarikciDuzenle(tedarikci.Id, firmaadi, telefon, adres))
                            {
                                MessageBox.Show("Tedarikçi düzenleme işlemi başarıyla tamamlandı.",
                                    "Bilgi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                Yenile();
                                EklemeModunaGec();
                            }
                            else
                            {
                                MessageBox.Show("Tedarikçi düzenleme işleminde bir hata meydana geldi",
                                                            "Hata",
                                                            MessageBoxButtons.OK,
                                                            MessageBoxIcon.Error);
                                tedarikci = null;
                                txtAdres.Text = ""; txtFirmaAdi.Text = ""; txtTelefon.Text = "";
                            }
                        }
                        hata.SetError(txtAdres, "");
                    }
                    else
                    {
                        hata.SetError(txtAdres, "Lütfen bir adres giriniz");
                    }
                    hata.SetError(txtTelefon, "");
                }
                else
                {
                    hata.SetError(txtTelefon, "Lütfen doğru bir telefon adresi giriniz");
                }
                hata.SetError(txtFirmaAdi, "");
                
            }
            else
            {
                hata.SetError(txtFirmaAdi, "Lütfen doğru bir isim giriniz");
            }
        }
        private void btnTedarikciKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        private void frmTedarikciListesi_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            DuzenlemeModunaGec();
        }
        void DuzenlemeModunaGec()
        {
            Tedarikci ted = gridView1.GetFocusedRow() as Tedarikci;
            if (ted != null)
            {
                tedarikci = ted;
                txtFirmaAdi.BackColor = Color.AliceBlue;
                txtAdres.BackColor = Color.AliceBlue;
                txtTelefon.BackColor = Color.AliceBlue;

                txtFirmaAdi.Text = ted.FirmaAdi;
                txtAdres.Text = ted.Adres;
                txtTelefon.Text = ted.Gsm;

                groupControl2.Text = "Tedarikçi Firma Düzenleniyor";

            }
        }
        void EklemeModunaGec()
        {
            tedarikci = null;
            txtFirmaAdi.BackColor = (new TextBox()).BackColor;
            txtAdres.BackColor = (new TextBox()).BackColor;
            txtTelefon.BackColor = (new TextBox()).BackColor;

            txtFirmaAdi.Text="";
            txtAdres.Text = "";
            txtTelefon.Text = "";
            groupControl2.Text = "Yeni Tedarikçi Firma";
        }

        private void txtAdres_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
                Kaydet();
        }


    }
}