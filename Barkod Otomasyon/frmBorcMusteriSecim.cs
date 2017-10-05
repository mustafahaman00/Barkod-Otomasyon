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
    public partial class frmBorcMusteriSecim : DevExpress.XtraEditors.XtraForm
    {
        public Musteri musteri;
        public bool Devam = false;
        public frmBorcMusteriSecim()
        {
            InitializeComponent();
        }

        private void frmBorcMusteriSecim_Load(object sender, EventArgs e)
        {
            cmbMusteriler.DataSource = (new Islemler()).MusteriListele();
            cmbMusteriler.DisplayMember = "AdiSoyadi";
            cmbMusteriler.ValueMember = "Id";
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Musteri mus = cmbMusteriler.SelectedItem as Musteri;
            if (mus != null)
            {
                musteri = mus;
                Devam = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Bir Müşteri seçmeniz gerekiyor");
            }
            
           
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}