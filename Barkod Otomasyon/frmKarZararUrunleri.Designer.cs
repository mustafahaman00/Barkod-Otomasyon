namespace Barkod_Otomasyon
{
    partial class frmKarZararUrunleri
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ürün = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AlisFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.satisFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToplamKar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 370);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(666, 36);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(666, 370);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Tarih,
            this.Ürün,
            this.Adet,
            this.AlisFiyati,
            this.satisFiyati,
            this.ToplamKar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Tarih
            // 
            this.Tarih.Caption = "Tarih";
            this.Tarih.FieldName = "Satis.Fi.SatisTarihi";
            this.Tarih.Name = "Tarih";
            this.Tarih.Visible = true;
            this.Tarih.VisibleIndex = 0;
            // 
            // Ürün
            // 
            this.Ürün.Caption = "Ürün";
            this.Ürün.FieldName = "Satis.Urun.UrunAdi";
            this.Ürün.Name = "Ürün";
            this.Ürün.Visible = true;
            this.Ürün.VisibleIndex = 1;
            // 
            // Adet
            // 
            this.Adet.Caption = "Adet";
            this.Adet.FieldName = "Satis.Adet";
            this.Adet.Name = "Adet";
            this.Adet.Visible = true;
            this.Adet.VisibleIndex = 2;
            // 
            // AlisFiyati
            // 
            this.AlisFiyati.Caption = "Alış Fiyatı";
            this.AlisFiyati.FieldName = "Satis.AdetAlisFiyati";
            this.AlisFiyati.Name = "AlisFiyati";
            this.AlisFiyati.Visible = true;
            this.AlisFiyati.VisibleIndex = 3;
            // 
            // satisFiyati
            // 
            this.satisFiyati.Caption = "Satış Fiyatı";
            this.satisFiyati.FieldName = "Satis.AdetSatisFiyati";
            this.satisFiyati.Name = "satisFiyati";
            this.satisFiyati.Visible = true;
            this.satisFiyati.VisibleIndex = 4;
            // 
            // ToplamKar
            // 
            this.ToplamKar.Caption = "Toplam Kar";
            this.ToplamKar.FieldName = "ToplamKar";
            this.ToplamKar.Name = "ToplamKar";
            this.ToplamKar.Visible = true;
            this.ToplamKar.VisibleIndex = 5;
            // 
            // frmKarZararUrunleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 406);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmKarZararUrunleri";
            this.Text = "Kar - Zarar Analizi";
            this.Load += new System.EventHandler(this.frmKarZararUrunleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Tarih;
        private DevExpress.XtraGrid.Columns.GridColumn Ürün;
        private DevExpress.XtraGrid.Columns.GridColumn Adet;
        private DevExpress.XtraGrid.Columns.GridColumn AlisFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn satisFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn ToplamKar;
    }
}