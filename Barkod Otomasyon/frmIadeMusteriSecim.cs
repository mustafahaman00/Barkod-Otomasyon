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
    public partial class frmIadeMusteriSecim : DevExpress.XtraEditors.XtraForm
    {
        public Musteri musteri;
        public bool Devam = false;
            
        public frmIadeMusteriSecim()
        {
            InitializeComponent();
        }

        private void frmIadeMusteriSecim_Load(object sender, EventArgs e)
        {
            cmbMusteri.DataSource = new Islemler().MusteriListele();
            cmbMusteri.DisplayMember = "AdiSoyadi";
            cmbMusteri.ValueMember = "Id";
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Devam = false;
        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            Musteri ms = cmbMusteri.SelectedItem as Musteri;
            if(ms!=null)
            {
                musteri = ms;
                Devam = true;
                this.Close();
            }
            else
            {
                string hata = "Müşteri seçilirken bir hata meydana geldi. Müşteriyi sistemde bulamadık";
                MessageBox.Show(hata, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
                
        }
    }
}