namespace Barkod_Otomasyon
{
    partial class frmKullaniciOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciOlustur));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.chkAktifMi = new DevExpress.XtraEditors.CheckEdit();
            this.chkAdminMi = new DevExpress.XtraEditors.CheckEdit();
            this.txtAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.txtGsm = new DevExpress.XtraEditors.TextEdit();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAktifMi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAdminMi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGsm.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtParola);
            this.groupControl1.Controls.Add(this.txtKullaniciAdi);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(368, 85);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Giriş Bilgileri";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(81, 23);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(263, 20);
            this.txtKullaniciAdi.TabIndex = 2;
            this.txtKullaniciAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGsm_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(35, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Parola : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kullanıcı Adı : ";
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(81, 51);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(263, 20);
            this.txtParola.TabIndex = 3;
            this.txtParola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGsm_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(52, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Adı :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(35, 122);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Soyadı :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(47, 150);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Gsm :";
            // 
            // chkAktifMi
            // 
            this.chkAktifMi.EditValue = true;
            this.chkAktifMi.Location = new System.Drawing.Point(42, 179);
            this.chkAktifMi.Name = "chkAktifMi";
            this.chkAktifMi.Properties.Caption = "Aktif : ";
            this.chkAktifMi.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.chkAktifMi.Size = new System.Drawing.Size(75, 19);
            this.chkAktifMi.TabIndex = 4;
            // 
            // chkAdminMi
            // 
            this.chkAdminMi.Location = new System.Drawing.Point(125, 179);
            this.chkAdminMi.Name = "chkAdminMi";
            this.chkAdminMi.Properties.Caption = "Yönetici : ";
            this.chkAdminMi.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.chkAdminMi.Size = new System.Drawing.Size(75, 19);
            this.chkAdminMi.TabIndex = 5;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(84, 91);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(282, 20);
            this.txtAdi.TabIndex = 6;
            this.txtAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGsm_KeyDown);
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(84, 117);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(282, 20);
            this.txtSoyadi.TabIndex = 7;
            this.txtSoyadi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGsm_KeyDown);
            // 
            // txtGsm
            // 
            this.txtGsm.Location = new System.Drawing.Point(84, 143);
            this.txtGsm.Name = "txtGsm";
            this.txtGsm.Properties.MaxLength = 11;
            this.txtGsm.Size = new System.Drawing.Size(282, 20);
            this.txtGsm.TabIndex = 8;
            this.txtGsm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGsm_KeyDown);
            this.txtGsm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGsm_KeyPress);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(291, 177);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(206, 177);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmKullaniciOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 220);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtGsm);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.chkAdminMi);
            this.Controls.Add(this.chkAktifMi);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKullaniciOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı İşlemleri";
            this.Load += new System.EventHandler(this.frmKullaniciOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAktifMi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAdminMi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGsm.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CheckEdit chkAktifMi;
        private DevExpress.XtraEditors.CheckEdit chkAdminMi;
        private DevExpress.XtraEditors.TextEdit txtAdi;
        private DevExpress.XtraEditors.TextEdit txtSoyadi;
        private DevExpress.XtraEditors.TextEdit txtGsm;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
    }
}