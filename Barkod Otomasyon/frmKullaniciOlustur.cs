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
    public partial class frmKullaniciOlustur : DevExpress.XtraEditors.XtraForm
    {
        Kullanici degisecek = null;
        public frmKullaniciOlustur(Kullanici _user)
        {
            degisecek = _user;
            InitializeComponent();
        }

        private void frmKullaniciOlustur_Load(object sender, EventArgs e)
        {
            BaslangicIslemleri();
        }

        private void BaslangicIslemleri()
        {
            if (degisecek != null)
            {
                txtKullaniciAdi.Text = degisecek.KullaniciAdi;
                txtParola.Text = degisecek.Parola;
                txtGsm.Text = degisecek.Gsm;
                txtAdi.Text = degisecek.Adi;
                txtSoyadi.Text = degisecek.Soyadi;
                if (degisecek.AdminMi == true) chkAdminMi.Checked = true;
                else chkAdminMi.Checked = false;
                if (degisecek.AktifMi == true) chkAktifMi.Checked = true;
                else chkAktifMi.Checked = false;
            }
        }
        ErrorProvider hata = new ErrorProvider();
        void Kaydet()
        {
            string adi = txtAdi.Text.Trim();
            string soyadi = txtSoyadi.Text.Trim();
            string gsm = txtGsm.Text.Trim();
            string kullaniciadi = txtKullaniciAdi.Text.Trim();
            string parola = txtParola.Text.Trim();
            if (adi.Length > 2)
            {
                if (soyadi.Length > 2)
                {
                    if (gsm.Length == 10 || gsm.Length == 11)
                    {
                        if (kullaniciadi.Length > 5)
                        {
                            if (parola.Length > 5)
                            {
                                Islemler islemler = new Islemler();
                                if (islemler.KullaniciVarMiTelefonla(gsm))
                                {
                                    MessageBox.Show("Bu telefona ait kullanıcı var zaten.\nLütfen doğru bir telefon giriniz"
                                        , "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtGsm.Focus();

                                }
                                else
                                {
                                    if (islemler.KullaniciVarMi(kullaniciadi))
                                    {
                                        MessageBox.Show("Bu kullanıcı adıyla birisi var zaten.\nLütfen doğru bir kullanıcı adı giriniz"
                                        , "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtKullaniciAdi.Focus();
                                    }
                                    else
                                    {
                                        if (islemler.KullaniciEkle(
                                            kullaniciadi,
                                            parola,
                                            adi,
                                            soyadi,
                                            gsm,
                                            chkAktifMi.Checked,
                                            chkAdminMi.Checked))
                                        {
                                            MessageBox.Show("Kullanıcı başarıyla kaydedildi");
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Kullanıcı eklenirken bir hata meydana geldi",
                                                "Hata",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                                        }
                                    }
                                }
                                hata.SetError(txtParola, "");
                            }
                            else
                            {
                                hata.SetError(txtParola, "Lütfen en az 6 karakterli bir parola belirleyin");
                            }
                            hata.SetError(txtKullaniciAdi, "");
                        }
                        else
                        {
                            hata.SetError(txtKullaniciAdi, "Lütfen en az 6 karakterli bir kullanıcı adı belirleyin");
                        }
                        hata.SetError(txtGsm, "");
                    }
                    else
                    {
                        hata.SetError(txtGsm, "Lütfen doğru bir gsm numarası giriniz");
                    }
                    hata.SetError(txtSoyadi, "");
                }
                else
                {
                    hata.SetError(txtSoyadi, "Lütfen en az 2 karakter olacak şekilde belirleyin");

                }
                hata.SetError(txtAdi, "");
            }
            else
            {
                hata.SetError(txtAdi, "Lütfen en az 2 karakterli bir isim belirleyiniz");
            }
        }

       
        bool BuTelefonluBaskasiVarMi(string telefon)//bu telefonda kayıtlı varmı varsa değişecek kişi mi
        {
            Islemler islemler = new Islemler();
            Kullanici kisi = islemler.KullaniciGetirTelefonla(telefon);
            if (kisi == null)
            {
                return false;
            }
            else
            {
                if (kisi.Id == degisecek.Id)
                {
                    return false;
                }
                else
                {
                    MessageBox.Show("Bu telefonda zaten başkası var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return true;
                }
            }
        }
        bool BuAddaBaskasiVarMi(string kullaniciadi)
        {
            Islemler islemler = new Islemler();
            Kullanici kisi = islemler.KullaniciGetirKullaniciAdiIle(kullaniciadi);
            if (kisi == null)
            {
                return false;
            }
            else
            {
                if (kisi.Id == degisecek.Id)
                {
                    return false;
                }
                else
                {
                    MessageBox.Show("Bu isimde zaten başkası var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
        }
        void Duzenle()
        {
            string adi = txtAdi.Text.Trim();
            string soyadi = txtSoyadi.Text.Trim();
            string gsm = txtGsm.Text.Trim();
            string kullaniciadi = txtKullaniciAdi.Text.Trim();
            string parola = txtParola.Text.Trim();
            if (adi.Length > 2)
            {
                if (soyadi.Length > 2)
                {
                    if (gsm.Length == 10 || gsm.Length == 11)
                    {
                        if (kullaniciadi.Length > 5)
                        {
                            if (parola.Length > 5)
                            {

                                if (!BuAddaBaskasiVarMi(kullaniciadi) && !BuTelefonluBaskasiVarMi(gsm))
                                {
                                    Islemler islemler = new Islemler();
                                    if (islemler.KullaniciDuzenle(
                                            degisecek.Id,
                                            kullaniciadi,
                                            parola,
                                            adi,
                                            soyadi,
                                            gsm,
                                            chkAktifMi.Checked,
                                            chkAdminMi.Checked))
                                    {
                                        MessageBox.Show("Kullanıcı başarıyla düzenlendi");
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Kullanıcı düzenlenirken bir hata meydana geldi",
                                            "Hata",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                                    }
                                }

                               
                                hata.SetError(txtParola, "");
                            }
                            else
                            {
                                hata.SetError(txtParola, "Lütfen en az 6 karakterli bir parola belirleyin");
                            }
                            hata.SetError(txtKullaniciAdi, "");
                        }
                        else
                        {
                            hata.SetError(txtKullaniciAdi, "Lütfen en az 6 karakterli bir kullanıcı adı belirleyin");
                        }
                        hata.SetError(txtGsm, "");
                    }
                    else
                    {
                        hata.SetError(txtGsm, "Lütfen doğru bir gsm numarası giriniz");
                    }
                    hata.SetError(txtSoyadi, "");
                }
                else
                {
                    hata.SetError(txtSoyadi, "Lütfen en az 2 karakter olacak şekilde belirleyin");

                }
                hata.SetError(txtAdi, "");
            }
            else
            {
                hata.SetError(txtAdi, "Lütfen en az 2 karakterli bir isim belirleyiniz");
            }
        }




        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        void Temizle()
        {
            foreach (Object item in this.Controls)
            {
                try
                {
                    TextEdit tx = (TextEdit)item;
                    tx.Text = "";
                }
                catch (Exception) { }

            }
            txtKullaniciAdi.Text = "";
            txtParola.Text = "";
            chkAdminMi.Checked = false;
            chkAktifMi.Checked = false;
        }

        private void txtGsm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (degisecek == null)
                Kaydet();
            else
                Duzenle();
        }

        private void txtGsm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (degisecek == null)
                    Kaydet();
                else
                    Duzenle();
            }
        }

    }
}