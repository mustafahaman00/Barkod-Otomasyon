namespace Barkod_Otomasyon
{
    partial class frmKullanicilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullanicilar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeniKullanici = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Soyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gsm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Yönetici = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AktifMi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnYenile);
            this.panel1.Controls.Add(this.btnDuzenle);
            this.panel1.Controls.Add(this.btnYeniKullanici);
            this.panel1.Controls.Add(this.textEdit1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 38);
            this.panel1.TabIndex = 0;
            // 
            // btnYenile
            // 
            this.btnYenile.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.Image")));
            this.btnYenile.Location = new System.Drawing.Point(648, 7);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(105, 23);
            this.btnYenile.TabIndex = 7;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(537, 7);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(105, 23);
            this.btnDuzenle.TabIndex = 6;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnYeniKullanici
            // 
            this.btnYeniKullanici.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniKullanici.Image")));
            this.btnYeniKullanici.Location = new System.Drawing.Point(435, 7);
            this.btnYeniKullanici.Name = "btnYeniKullanici";
            this.btnYeniKullanici.Size = new System.Drawing.Size(96, 23);
            this.btnYeniKullanici.TabIndex = 5;
            this.btnYeniKullanici.Text = "Yeni Kullanıcı";
            this.btnYeniKullanici.Click += new System.EventHandler(this.btnYeniKullanici_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(73, 9);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(356, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kullanıcı Adı";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 38);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(810, 405);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KullaniciAdi,
            this.Adi,
            this.Soyadi,
            this.Gsm,
            this.Yönetici,
            this.AktifMi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.Caption = "KullaniciAdi";
            this.KullaniciAdi.FieldName = "KullaniciAdi";
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.Visible = true;
            this.KullaniciAdi.VisibleIndex = 0;
            // 
            // Adi
            // 
            this.Adi.Caption = "Adı";
            this.Adi.FieldName = "Adi";
            this.Adi.Name = "Adi";
            this.Adi.Visible = true;
            this.Adi.VisibleIndex = 1;
            // 
            // Soyadi
            // 
            this.Soyadi.Caption = "Soyadı";
            this.Soyadi.FieldName = "Soyadi";
            this.Soyadi.Name = "Soyadi";
            this.Soyadi.Visible = true;
            this.Soyadi.VisibleIndex = 2;
            // 
            // Gsm
            // 
            this.Gsm.Caption = "Telefon";
            this.Gsm.FieldName = "Gsm";
            this.Gsm.Name = "Gsm";
            this.Gsm.Visible = true;
            this.Gsm.VisibleIndex = 3;
            // 
            // Yönetici
            // 
            this.Yönetici.Caption = "Yönetici";
            this.Yönetici.FieldName = "AdminMi";
            this.Yönetici.Name = "Yönetici";
            this.Yönetici.Visible = true;
            this.Yönetici.VisibleIndex = 4;
            // 
            // AktifMi
            // 
            this.AktifMi.Caption = "Aktif";
            this.AktifMi.FieldName = "AktifMi";
            this.AktifMi.Name = "AktifMi";
            this.AktifMi.Visible = true;
            this.AktifMi.VisibleIndex = 5;
            // 
            // frmKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 443);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmKullanicilar";
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.frmKullanicilar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnYeniKullanici;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn KullaniciAdi;
        private DevExpress.XtraGrid.Columns.GridColumn Adi;
        private DevExpress.XtraGrid.Columns.GridColumn Soyadi;
        private DevExpress.XtraGrid.Columns.GridColumn Gsm;
        private DevExpress.XtraGrid.Columns.GridColumn Yönetici;
        private DevExpress.XtraGrid.Columns.GridColumn AktifMi;
    }
}