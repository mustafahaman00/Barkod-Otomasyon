namespace Barkod_Otomasyon
{
    partial class frmKategoriDuzenle
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKategoriAdi = new DevExpress.XtraEditors.TextEdit();
            this.btnKategoriDuzenleKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtKategoriAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kategori Adı";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(92, 9);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(301, 20);
            this.txtKategoriAdi.TabIndex = 1;
            this.txtKategoriAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKategoriAdi_KeyDown);
            // 
            // btnKategoriDuzenleKaydet
            // 
            this.btnKategoriDuzenleKaydet.Location = new System.Drawing.Point(399, 7);
            this.btnKategoriDuzenleKaydet.Name = "btnKategoriDuzenleKaydet";
            this.btnKategoriDuzenleKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKategoriDuzenleKaydet.TabIndex = 2;
            this.btnKategoriDuzenleKaydet.Text = "Kaydet";
            this.btnKategoriDuzenleKaydet.Click += new System.EventHandler(this.btnKategoriDuzenleKaydet_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(399, 59);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // frmKategoriDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 94);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKategoriDuzenleKaydet);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKategoriDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Düzenle";
            this.Load += new System.EventHandler(this.frmKategoriDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKategoriAdi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKategoriAdi;
        private DevExpress.XtraEditors.SimpleButton btnKategoriDuzenleKaydet;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}