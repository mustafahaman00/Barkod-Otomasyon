namespace Barkod_Otomasyon
{
    partial class frmSatislarim
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
            this.SatisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Müşteri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OdemeDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunAdedi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtToplamTutar = new DevExpress.XtraEditors.TextEdit();
            this.Tutar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamTutar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(930, 503);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SatisTarihi,
            this.Müşteri,
            this.OdemeDurumu,
            this.UrunAdedi,
            this.Tutar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // SatisTarihi
            // 
            this.SatisTarihi.Caption = "Satış Tarihi";
            this.SatisTarihi.FieldName = "SatisTarihi";
            this.SatisTarihi.Name = "SatisTarihi";
            this.SatisTarihi.Visible = true;
            this.SatisTarihi.VisibleIndex = 0;
            // 
            // Müşteri
            // 
            this.Müşteri.Caption = "Müşteri";
            this.Müşteri.FieldName = "Musteri.AdiSoyadi";
            this.Müşteri.Name = "Müşteri";
            this.Müşteri.Visible = true;
            this.Müşteri.VisibleIndex = 1;
            // 
            // OdemeDurumu
            // 
            this.OdemeDurumu.Caption = "Ödeme Durumu";
            this.OdemeDurumu.FieldName = "OdendiMi";
            this.OdemeDurumu.Name = "OdemeDurumu";
            this.OdemeDurumu.Visible = true;
            this.OdemeDurumu.VisibleIndex = 2;
            // 
            // UrunAdedi
            // 
            this.UrunAdedi.Caption = "ÜrünAdedi";
            this.UrunAdedi.FieldName = "Satis.Count";
            this.UrunAdedi.Name = "UrunAdedi";
            this.UrunAdedi.Visible = true;
            this.UrunAdedi.VisibleIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtToplamTutar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 39);
            this.panel1.TabIndex = 1;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtToplamTutar.EditValue = "00,00 ₺";
            this.txtToplamTutar.Location = new System.Drawing.Point(769, 0);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.txtToplamTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtToplamTutar.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.txtToplamTutar.Properties.Appearance.Options.UseBackColor = true;
            this.txtToplamTutar.Properties.Appearance.Options.UseFont = true;
            this.txtToplamTutar.Properties.Appearance.Options.UseForeColor = true;
            this.txtToplamTutar.Properties.ReadOnly = true;
            this.txtToplamTutar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtToplamTutar.Size = new System.Drawing.Size(161, 40);
            this.txtToplamTutar.TabIndex = 0;
            // 
            // Tutar
            // 
            this.Tutar.Caption = "Tutar";
            this.Tutar.FieldName = "ToplamTutar";
            this.Tutar.Name = "Tutar";
            this.Tutar.Visible = true;
            this.Tutar.VisibleIndex = 4;
            // 
            // frmSatislarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 542);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmSatislarim";
            this.Text = "Satışlarım";
            this.Activated += new System.EventHandler(this.frmSatislarim_Activated);
            this.Load += new System.EventHandler(this.frmSatislarim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamTutar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn SatisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn Müşteri;
        private DevExpress.XtraGrid.Columns.GridColumn OdemeDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn UrunAdedi;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn Tutar;
    }
}