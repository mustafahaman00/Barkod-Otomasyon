namespace Barkod_Otomasyon
{
    partial class frmTedarikciListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTedarikciListesi));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnTedarikciKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtAdres = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.txtFirmaAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FirmaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.splitter1);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(795, 113);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(225, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(568, 109);
            this.panelControl2.TabIndex = 2;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnTedarikciKaydet);
            this.groupControl2.Controls.Add(this.txtAdres);
            this.groupControl2.Controls.Add(this.txtTelefon);
            this.groupControl2.Controls.Add(this.txtFirmaAdi);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(564, 105);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Tedarikçi Firma";
            // 
            // btnTedarikciKaydet
            // 
            this.btnTedarikciKaydet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTedarikciKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnTedarikciKaydet.Image")));
            this.btnTedarikciKaydet.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnTedarikciKaydet.Location = new System.Drawing.Point(487, 20);
            this.btnTedarikciKaydet.Name = "btnTedarikciKaydet";
            this.btnTedarikciKaydet.Size = new System.Drawing.Size(75, 83);
            this.btnTedarikciKaydet.TabIndex = 6;
            this.btnTedarikciKaydet.Text = "Kaydet";
            this.btnTedarikciKaydet.Click += new System.EventHandler(this.btnTedarikciKaydet_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdres.Location = new System.Drawing.Point(70, 80);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(411, 20);
            this.txtAdres.TabIndex = 5;
            this.txtAdres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdres_KeyDown);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefon.Location = new System.Drawing.Point(70, 54);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Properties.MaxLength = 12;
            this.txtTelefon.Size = new System.Drawing.Size(411, 20);
            this.txtTelefon.TabIndex = 4;
            this.txtTelefon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdres_KeyDown);
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefon_KeyPress);
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirmaAdi.Location = new System.Drawing.Point(70, 27);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Properties.MaxLength = 50;
            this.txtFirmaAdi.Size = new System.Drawing.Size(411, 20);
            this.txtFirmaAdi.TabIndex = 3;
            this.txtFirmaAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdres_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Adres :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Telefon :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Firma Adı :";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(222, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 109);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.splitter2);
            this.groupControl1.Controls.Add(this.btnDuzenle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(220, 109);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnSil
            // 
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSil.Location = new System.Drawing.Point(2, 65);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(216, 42);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(2, 62);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(216, 3);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDuzenle.Location = new System.Drawing.Point(2, 20);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(216, 42);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 113);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(795, 330);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FirmaAdi,
            this.Adres,
            this.Telefon,
            this.KayitTarihi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // FirmaAdi
            // 
            this.FirmaAdi.Caption = "Firma Adı";
            this.FirmaAdi.FieldName = "FirmaAdi";
            this.FirmaAdi.Name = "FirmaAdi";
            this.FirmaAdi.Visible = true;
            this.FirmaAdi.VisibleIndex = 0;
            // 
            // Adres
            // 
            this.Adres.Caption = "Adres";
            this.Adres.FieldName = "Adres";
            this.Adres.Name = "Adres";
            this.Adres.Visible = true;
            this.Adres.VisibleIndex = 1;
            // 
            // Telefon
            // 
            this.Telefon.Caption = "Telefon";
            this.Telefon.FieldName = "Gsm";
            this.Telefon.Name = "Telefon";
            this.Telefon.Visible = true;
            this.Telefon.VisibleIndex = 2;
            // 
            // KayitTarihi
            // 
            this.KayitTarihi.Caption = "Kayıt Tarihi";
            this.KayitTarihi.FieldName = "KayitTarihi";
            this.KayitTarihi.Name = "KayitTarihi";
            this.KayitTarihi.Visible = true;
            this.KayitTarihi.VisibleIndex = 3;
            // 
            // frmTedarikciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 443);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmTedarikciListesi";
            this.Text = "Tedarikçi Listesi";
            this.Load += new System.EventHandler(this.frmTedarikciListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnTedarikciKaydet;
        private DevExpress.XtraEditors.TextEdit txtAdres;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private DevExpress.XtraEditors.TextEdit txtFirmaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Splitter splitter1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private System.Windows.Forms.Splitter splitter2;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn FirmaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn Adres;
        private DevExpress.XtraGrid.Columns.GridColumn Telefon;
        private DevExpress.XtraGrid.Columns.GridColumn KayitTarihi;

    }
}