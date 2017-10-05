namespace Barkod_Otomasyon
{
    partial class frmFisUrunleri
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtToplamTutar = new DevExpress.XtraEditors.TextEdit();
            this.Urun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BirimFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToplamFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamTutar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1045, 506);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Urun,
            this.Adet,
            this.BirimFiyat,
            this.ToplamFiyat});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtToplamTutar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 506);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1045, 51);
            this.panelControl1.TabIndex = 1;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtToplamTutar.EditValue = "00,00 ₺";
            this.txtToplamTutar.Location = new System.Drawing.Point(860, 2);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.txtToplamTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.txtToplamTutar.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.txtToplamTutar.Properties.Appearance.Options.UseBackColor = true;
            this.txtToplamTutar.Properties.Appearance.Options.UseFont = true;
            this.txtToplamTutar.Properties.Appearance.Options.UseForeColor = true;
            this.txtToplamTutar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtToplamTutar.Size = new System.Drawing.Size(183, 46);
            this.txtToplamTutar.TabIndex = 0;
            // 
            // Urun
            // 
            this.Urun.Caption = "Ürün";
            this.Urun.FieldName = "Urun.UrunAdi";
            this.Urun.Name = "Urun";
            this.Urun.Visible = true;
            this.Urun.VisibleIndex = 0;
            // 
            // Adet
            // 
            this.Adet.Caption = "Adet";
            this.Adet.FieldName = "Adet";
            this.Adet.Name = "Adet";
            this.Adet.Visible = true;
            this.Adet.VisibleIndex = 1;
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.Caption = "Birim Fiyat";
            this.BirimFiyat.FieldName = "BirimFiyat";
            this.BirimFiyat.Name = "BirimFiyat";
            this.BirimFiyat.Visible = true;
            this.BirimFiyat.VisibleIndex = 2;
            // 
            // ToplamFiyat
            // 
            this.ToplamFiyat.Caption = "Toplam Fiyat";
            this.ToplamFiyat.FieldName = "ToplamFiyat";
            this.ToplamFiyat.Name = "ToplamFiyat";
            this.ToplamFiyat.Visible = true;
            this.ToplamFiyat.VisibleIndex = 3;
            // 
            // frmFisUrunleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 557);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmFisUrunleri";
            this.Text = "Satılan Ürünler";
            this.Load += new System.EventHandler(this.frmFisUrunleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamTutar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn Urun;
        private DevExpress.XtraGrid.Columns.GridColumn Adet;
        private DevExpress.XtraGrid.Columns.GridColumn BirimFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn ToplamFiyat;
    }
}