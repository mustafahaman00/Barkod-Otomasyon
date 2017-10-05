namespace Barkod_Otomasyon
{
    partial class frmBorcTahsil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBorcTahsil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ürünadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BirimFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToplamFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnTahsilat = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTahsilat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 41);
            this.panel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(803, 458);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ürünadi,
            this.Adet,
            this.BirimFiyat,
            this.ToplamFiyat});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // ürünadi
            // 
            this.ürünadi.Caption = "Ürün";
            this.ürünadi.FieldName = "Urun.UrunAdi";
            this.ürünadi.Name = "ürünadi";
            this.ürünadi.Visible = true;
            this.ürünadi.VisibleIndex = 0;
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
            this.BirimFiyat.Caption = "BirimFiyat";
            this.BirimFiyat.FieldName = "BirimFiyat";
            this.BirimFiyat.Name = "BirimFiyat";
            this.BirimFiyat.Visible = true;
            this.BirimFiyat.VisibleIndex = 2;
            // 
            // ToplamFiyat
            // 
            this.ToplamFiyat.Caption = "ToplamFiyat";
            this.ToplamFiyat.FieldName = "ToplamFiyat";
            this.ToplamFiyat.Name = "ToplamFiyat";
            this.ToplamFiyat.Visible = true;
            this.ToplamFiyat.VisibleIndex = 3;
            // 
            // btnTahsilat
            // 
            this.btnTahsilat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTahsilat.Image = ((System.Drawing.Image)(resources.GetObject("btnTahsilat.Image")));
            this.btnTahsilat.Location = new System.Drawing.Point(672, 0);
            this.btnTahsilat.Name = "btnTahsilat";
            this.btnTahsilat.Size = new System.Drawing.Size(131, 41);
            this.btnTahsilat.TabIndex = 0;
            this.btnTahsilat.Text = "Tahsilat";
            this.btnTahsilat.Click += new System.EventHandler(this.btnTahsilat_Click);
            // 
            // frmBorcTahsil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 499);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmBorcTahsil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tahsilat";
            this.Load += new System.EventHandler(this.frmBorcTahsil_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnTahsilat;
        private DevExpress.XtraGrid.Columns.GridColumn ürünadi;
        private DevExpress.XtraGrid.Columns.GridColumn Adet;
        private DevExpress.XtraGrid.Columns.GridColumn BirimFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn ToplamFiyat;
    }
}