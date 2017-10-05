namespace Barkod_Otomasyon
{
    partial class frmUrunListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunListesi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kategori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tedarikçi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Barkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AlisFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SatisFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnYenile);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnDuzenle);
            this.panel1.Controls.Add(this.txtUrunAdi);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 51);
            this.panel1.TabIndex = 1;
            // 
            // btnYenile
            // 
            this.btnYenile.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.Image")));
            this.btnYenile.Location = new System.Drawing.Point(700, 7);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 23);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.Location = new System.Drawing.Point(619, 7);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(538, 7);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDuzenle.TabIndex = 2;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(59, 9);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Properties.ReadOnly = true;
            this.txtUrunAdi.Size = new System.Drawing.Size(473, 20);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ürün Adı";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 51);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(826, 333);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UrunAdi,
            this.Kategori,
            this.Tedarikçi,
            this.Barkod,
            this.AlisFiyati,
            this.SatisFiyati,
            this.Aciklama});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // UrunAdi
            // 
            this.UrunAdi.Caption = "Ürün Adı";
            this.UrunAdi.FieldName = "UrunAdi";
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.Visible = true;
            this.UrunAdi.VisibleIndex = 0;
            // 
            // Kategori
            // 
            this.Kategori.Caption = "Kategori";
            this.Kategori.FieldName = "Kategori.KategoriAdi";
            this.Kategori.Name = "Kategori";
            this.Kategori.Visible = true;
            this.Kategori.VisibleIndex = 1;
            // 
            // Tedarikçi
            // 
            this.Tedarikçi.Caption = "Tedarikçi";
            this.Tedarikçi.FieldName = "Tedarikci.FirmaAdi";
            this.Tedarikçi.Name = "Tedarikçi";
            this.Tedarikçi.Visible = true;
            this.Tedarikçi.VisibleIndex = 2;
            // 
            // Barkod
            // 
            this.Barkod.Caption = "Barkod";
            this.Barkod.FieldName = "Barkod";
            this.Barkod.Name = "Barkod";
            this.Barkod.Visible = true;
            this.Barkod.VisibleIndex = 3;
            // 
            // AlisFiyati
            // 
            this.AlisFiyati.Caption = "Alış Fiyatı";
            this.AlisFiyati.FieldName = "AlisFiyati";
            this.AlisFiyati.Name = "AlisFiyati";
            this.AlisFiyati.Visible = true;
            this.AlisFiyati.VisibleIndex = 4;
            // 
            // SatisFiyati
            // 
            this.SatisFiyati.Caption = "Satış Fiyatı";
            this.SatisFiyati.FieldName = "SatisFiyati";
            this.SatisFiyati.Name = "SatisFiyati";
            this.SatisFiyati.Visible = true;
            this.SatisFiyati.VisibleIndex = 5;
            // 
            // Aciklama
            // 
            this.Aciklama.Caption = "Aciklama";
            this.Aciklama.FieldName = "Aciklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.Visible = true;
            this.Aciklama.VisibleIndex = 6;
            // 
            // frmUrunListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 384);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmUrunListesi";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.frmUrunListesi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn UrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn Kategori;
        private DevExpress.XtraGrid.Columns.GridColumn Tedarikçi;
        private DevExpress.XtraGrid.Columns.GridColumn Barkod;
        private DevExpress.XtraGrid.Columns.GridColumn AlisFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn SatisFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn Aciklama;

    }
}