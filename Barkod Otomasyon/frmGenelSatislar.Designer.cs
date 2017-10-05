namespace Barkod_Otomasyon
{
    partial class frmGenelSatislar
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtToplam = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Musteri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kullanici = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Odeme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tutar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtToplam);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 437);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(799, 45);
            this.panelControl2.TabIndex = 1;
            // 
            // txtToplam
            // 
            this.txtToplam.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtToplam.Location = new System.Drawing.Point(597, 2);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.txtToplam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtToplam.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.txtToplam.Properties.Appearance.Options.UseBackColor = true;
            this.txtToplam.Properties.Appearance.Options.UseFont = true;
            this.txtToplam.Properties.Appearance.Options.UseForeColor = true;
            this.txtToplam.Properties.ReadOnly = true;
            this.txtToplam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtToplam.Size = new System.Drawing.Size(200, 40);
            this.txtToplam.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(799, 437);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Tarih,
            this.Kullanici,
            this.Musteri,
            this.Odeme,
            this.Tutar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView1.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridView1.OptionsPrint.PrintFilterInfo = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // Tarih
            // 
            this.Tarih.Caption = "Tarih";
            this.Tarih.FieldName = "SatisTarihi";
            this.Tarih.Name = "Tarih";
            this.Tarih.Visible = true;
            this.Tarih.VisibleIndex = 0;
            // 
            // Musteri
            // 
            this.Musteri.Caption = "Müşteri";
            this.Musteri.FieldName = "Musteri.AdiSoyadi";
            this.Musteri.Name = "Musteri";
            this.Musteri.Visible = true;
            this.Musteri.VisibleIndex = 2;
            // 
            // Kullanici
            // 
            this.Kullanici.Caption = "Kullanıcı";
            this.Kullanici.FieldName = "Kullanici.KullaniciAdi";
            this.Kullanici.Name = "Kullanici";
            this.Kullanici.Visible = true;
            this.Kullanici.VisibleIndex = 1;
            // 
            // Odeme
            // 
            this.Odeme.Caption = "Ödeme";
            this.Odeme.FieldName = "OdendiMi";
            this.Odeme.Name = "Odeme";
            this.Odeme.Visible = true;
            this.Odeme.VisibleIndex = 3;
            // 
            // Tutar
            // 
            this.Tutar.Caption = "Tutar";
            this.Tutar.FieldName = "ToplamTutar";
            this.Tutar.Name = "Tutar";
            this.Tutar.Visible = true;
            this.Tutar.VisibleIndex = 4;
            // 
            // frmGenelSatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 482);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "frmGenelSatislar";
            this.Text = "Genel Satışlar";
            this.Load += new System.EventHandler(this.frmGenelSatislar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtToplam;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Tarih;
        private DevExpress.XtraGrid.Columns.GridColumn Kullanici;
        private DevExpress.XtraGrid.Columns.GridColumn Musteri;
        private DevExpress.XtraGrid.Columns.GridColumn Odeme;
        private DevExpress.XtraGrid.Columns.GridColumn Tutar;
    }
}