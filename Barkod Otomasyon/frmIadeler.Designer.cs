namespace Barkod_Otomasyon
{
    partial class frmIadeler
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
            this.UrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Müşteri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BirimFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Toplam = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl1.Size = new System.Drawing.Size(629, 371);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UrunAdi,
            this.Müşteri,
            this.Adet,
            this.BirimFiyat,
            this.Aciklama,
            this.Tarih,
            this.Toplam});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // UrunAdi
            // 
            this.UrunAdi.Caption = "Urun";
            this.UrunAdi.FieldName = "Urun.UrunAdi";
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.Visible = true;
            this.UrunAdi.VisibleIndex = 0;
            // 
            // Müşteri
            // 
            this.Müşteri.Caption = "Müşteri";
            this.Müşteri.FieldName = "Musteri.AdiSoyadi";
            this.Müşteri.Name = "Müşteri";
            this.Müşteri.Visible = true;
            this.Müşteri.VisibleIndex = 1;
            // 
            // Adet
            // 
            this.Adet.Caption = "Adet";
            this.Adet.FieldName = "Adet";
            this.Adet.Name = "Adet";
            this.Adet.Visible = true;
            this.Adet.VisibleIndex = 2;
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.Caption = "Birim Fiyat";
            this.BirimFiyat.FieldName = "BirimFiyat";
            this.BirimFiyat.Name = "BirimFiyat";
            this.BirimFiyat.Visible = true;
            this.BirimFiyat.VisibleIndex = 6;
            // 
            // Aciklama
            // 
            this.Aciklama.Caption = "Aciklama";
            this.Aciklama.FieldName = "Aciklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.Visible = true;
            this.Aciklama.VisibleIndex = 4;
            // 
            // Tarih
            // 
            this.Tarih.Caption = "Tarih";
            this.Tarih.FieldName = "IadeTarihi";
            this.Tarih.Name = "Tarih";
            this.Tarih.Visible = true;
            this.Tarih.VisibleIndex = 5;
            // 
            // Toplam
            // 
            this.Toplam.Caption = "Toplam";
            this.Toplam.FieldName = "ToplamFiyat";
            this.Toplam.Name = "Toplam";
            this.Toplam.Visible = true;
            this.Toplam.VisibleIndex = 6;
            // 
            // frmIadeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 371);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmIadeler";
            this.Text = "Iadeler";
            this.Activated += new System.EventHandler(this.frmIadeler_Activated);
            this.Load += new System.EventHandler(this.frmIadeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn UrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn Müşteri;
        private DevExpress.XtraGrid.Columns.GridColumn Adet;
        private DevExpress.XtraGrid.Columns.GridColumn BirimFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn Aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn Tarih;
        private DevExpress.XtraGrid.Columns.GridColumn Toplam;
    }
}