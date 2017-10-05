namespace Barkod_Otomasyon
{
    partial class frmBorcMusteri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MusteriAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SatisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KullanıcıAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Odeme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(738, 482);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MusteriAdi,
            this.SatisTarihi,
            this.KullanıcıAdı,
            this.Odeme,
            this.ToplamTutar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // MusteriAdi
            // 
            this.MusteriAdi.Caption = "Müşteri";
            this.MusteriAdi.FieldName = "Musteri.AdiSoyadi";
            this.MusteriAdi.Name = "MusteriAdi";
            this.MusteriAdi.Visible = true;
            this.MusteriAdi.VisibleIndex = 0;
            // 
            // SatisTarihi
            // 
            this.SatisTarihi.Caption = "Tarih";
            this.SatisTarihi.FieldName = "SatisTarihi";
            this.SatisTarihi.Name = "SatisTarihi";
            this.SatisTarihi.Visible = true;
            this.SatisTarihi.VisibleIndex = 1;
            // 
            // KullanıcıAdı
            // 
            this.KullanıcıAdı.Caption = "Kullanici";
            this.KullanıcıAdı.FieldName = "Kullanici.KullaniciAdi";
            this.KullanıcıAdı.Name = "KullanıcıAdı";
            this.KullanıcıAdı.Visible = true;
            this.KullanıcıAdı.VisibleIndex = 2;
            // 
            // Odeme
            // 
            this.Odeme.Caption = "Ödeme";
            this.Odeme.FieldName = "OdendiMi";
            this.Odeme.Name = "Odeme";
            this.Odeme.Visible = true;
            this.Odeme.VisibleIndex = 3;
            // 
            // ToplamTutar
            // 
            this.ToplamTutar.Caption = "ToplamTutar";
            this.ToplamTutar.FieldName = "ToplamTutar";
            this.ToplamTutar.Name = "ToplamTutar";
            this.ToplamTutar.Visible = true;
            this.ToplamTutar.VisibleIndex = 4;
            // 
            // frmBorcMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 482);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmBorcMusteri";
            this.Text = "Müşteri Fişleri";
            this.Activated += new System.EventHandler(this.frmBorcMusteri_Activated);
            this.Load += new System.EventHandler(this.frmBorcMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MusteriAdi;
        private DevExpress.XtraGrid.Columns.GridColumn SatisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn KullanıcıAdı;
        private DevExpress.XtraGrid.Columns.GridColumn Odeme;
        private DevExpress.XtraGrid.Columns.GridColumn ToplamTutar;
    }
}