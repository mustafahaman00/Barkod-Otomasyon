namespace Barkod_Otomasyon
{
    partial class frmMusteriListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriListesi));
            this.btnYeniMusteri = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AdiSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gsm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniMusteri.Image")));
            this.btnYeniMusteri.Location = new System.Drawing.Point(12, 12);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(96, 23);
            this.btnYeniMusteri.TabIndex = 0;
            this.btnYeniMusteri.Text = "Yeni Müşteri ";
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(114, 12);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(105, 23);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.Location = new System.Drawing.Point(385, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(123, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil (Geri Alınamaz!)";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(12, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(757, 364);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AdiSoyadi,
            this.Gsm,
            this.Adres,
            this.KayitTarihi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // AdiSoyadi
            // 
            this.AdiSoyadi.Caption = "Adı Soyadı";
            this.AdiSoyadi.FieldName = "AdiSoyadi";
            this.AdiSoyadi.Name = "AdiSoyadi";
            this.AdiSoyadi.Visible = true;
            this.AdiSoyadi.VisibleIndex = 0;
            // 
            // Gsm
            // 
            this.Gsm.Caption = "Telefon";
            this.Gsm.FieldName = "Gsm";
            this.Gsm.Name = "Gsm";
            this.Gsm.Visible = true;
            this.Gsm.VisibleIndex = 1;
            // 
            // Adres
            // 
            this.Adres.Caption = "Adres";
            this.Adres.FieldName = "Adres";
            this.Adres.Name = "Adres";
            this.Adres.Visible = true;
            this.Adres.VisibleIndex = 2;
            // 
            // KayitTarihi
            // 
            this.KayitTarihi.Caption = "Kayıt Tarihi";
            this.KayitTarihi.FieldName = "KayitTarihi";
            this.KayitTarihi.Name = "KayitTarihi";
            this.KayitTarihi.Visible = true;
            this.KayitTarihi.VisibleIndex = 3;
            // 
            // btnYenile
            // 
            this.btnYenile.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.Image")));
            this.btnYenile.Location = new System.Drawing.Point(225, 12);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(105, 23);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // frmMusteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 417);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnYeniMusteri);
            this.Name = "frmMusteriListesi";
            this.Text = "Müşteri Listesi";
            this.Activated += new System.EventHandler(this.frmMusteriListesi_Activated);
            this.Load += new System.EventHandler(this.frmMusteriListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnYeniMusteri;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraGrid.Columns.GridColumn AdiSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn Gsm;
        private DevExpress.XtraGrid.Columns.GridColumn Adres;
        private DevExpress.XtraGrid.Columns.GridColumn KayitTarihi;

    }
}