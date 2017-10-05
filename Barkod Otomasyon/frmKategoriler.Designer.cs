namespace Barkod_Otomasyon
{
    partial class frmKategoriler
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnKategoriSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKategoriDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKategoriKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtKategoriAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KategoriAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adet = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKategoriAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnYenile);
            this.groupControl1.Controls.Add(this.btnKategoriSil);
            this.groupControl1.Controls.Add(this.btnKategoriDuzenle);
            this.groupControl1.Controls.Add(this.btnKategoriKaydet);
            this.groupControl1.Controls.Add(this.txtKategoriAdi);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1043, 53);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Yeni Kategori";
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(963, 22);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 23);
            this.btnYenile.TabIndex = 5;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.Location = new System.Drawing.Point(822, 23);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(107, 23);
            this.btnKategoriSil.TabIndex = 4;
            this.btnKategoriSil.Text = "Sil ( Geri Alınamaz)";
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // btnKategoriDuzenle
            // 
            this.btnKategoriDuzenle.Location = new System.Drawing.Point(741, 23);
            this.btnKategoriDuzenle.Name = "btnKategoriDuzenle";
            this.btnKategoriDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnKategoriDuzenle.TabIndex = 3;
            this.btnKategoriDuzenle.Text = "Düzenle";
            this.btnKategoriDuzenle.Click += new System.EventHandler(this.btnKategoriDuzenle_Click);
            // 
            // btnKategoriKaydet
            // 
            this.btnKategoriKaydet.Location = new System.Drawing.Point(660, 24);
            this.btnKategoriKaydet.Name = "btnKategoriKaydet";
            this.btnKategoriKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKategoriKaydet.TabIndex = 2;
            this.btnKategoriKaydet.Text = "Kaydet";
            this.btnKategoriKaydet.Click += new System.EventHandler(this.btnKategoriKaydet_Click);
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(91, 25);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(562, 20);
            this.txtKategoriAdi.TabIndex = 1;
            this.txtKategoriAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKategoriAdi_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kategori Adı :";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 53);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1043, 371);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KategoriAdi,
            this.Adet});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // KategoriAdi
            // 
            this.KategoriAdi.Caption = "Kategori Adı";
            this.KategoriAdi.FieldName = "KategoriAdi";
            this.KategoriAdi.Name = "KategoriAdi";
            this.KategoriAdi.Visible = true;
            this.KategoriAdi.VisibleIndex = 0;
            // 
            // Adet
            // 
            this.Adet.Caption = "Ürün Adedi";
            this.Adet.FieldName = "Uruns.Count";
            this.Adet.Name = "Adet";
            this.Adet.Visible = true;
            this.Adet.VisibleIndex = 1;
            // 
            // frmKategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 424);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmKategoriler";
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.frmKategoriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKategoriAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKategoriKaydet;
        private DevExpress.XtraEditors.TextEdit txtKategoriAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnKategoriSil;
        private DevExpress.XtraEditors.SimpleButton btnKategoriDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraGrid.Columns.GridColumn KategoriAdi;
        private DevExpress.XtraGrid.Columns.GridColumn Adet;
    }
}