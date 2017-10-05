namespace Barkod_Otomasyon
{
    partial class frmSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatis));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBarkod = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.btnBorc = new DevExpress.XtraEditors.SimpleButton();
            this.btnSatis = new DevExpress.XtraEditors.SimpleButton();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikar = new DevExpress.XtraEditors.SimpleButton();
            this.nmrGuncellenecekAdet = new System.Windows.Forms.NumericUpDown();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pctResim = new System.Windows.Forms.PictureBox();
            this.txtFiyati = new System.Windows.Forms.TextBox();
            this.txtTedarikci = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.adet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.adetfiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toplamfiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGuncellenecekAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.nmrAdet);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btnEkle);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtBarkod);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1043, 48);
            this.panelControl1.TabIndex = 0;
            // 
            // nmrAdet
            // 
            this.nmrAdet.Font = new System.Drawing.Font("Tahoma", 25F);
            this.nmrAdet.Location = new System.Drawing.Point(72, 0);
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(187, 48);
            this.nmrAdet.TabIndex = 5;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 24);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Adet :";
            // 
            // btnEkle
            // 
            this.btnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnEkle.Appearance.Options.UseFont = true;
            this.btnEkle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.Location = new System.Drawing.Point(938, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(103, 44);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl1.Location = new System.Drawing.Point(268, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Barkod : ";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarkod.EditValue = "";
            this.txtBarkod.Location = new System.Drawing.Point(355, 0);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.txtBarkod.Properties.Appearance.Options.UseFont = true;
            this.txtBarkod.Size = new System.Drawing.Size(577, 46);
            this.txtBarkod.TabIndex = 0;
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
            this.txtBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkod_KeyPress);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.cmbMusteri);
            this.panelControl2.Controls.Add(this.btnBorc);
            this.panelControl2.Controls.Add(this.btnSatis);
            this.panelControl2.Controls.Add(this.txtTutar);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 461);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1043, 68);
            this.panelControl2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(409, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hesap :";
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteri.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(509, 19);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(236, 32);
            this.cmbMusteri.TabIndex = 3;
            // 
            // btnBorc
            // 
            this.btnBorc.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnBorc.Appearance.Options.UseFont = true;
            this.btnBorc.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBorc.Image = ((System.Drawing.Image)(resources.GetObject("btnBorc.Image")));
            this.btnBorc.Location = new System.Drawing.Point(751, 2);
            this.btnBorc.Name = "btnBorc";
            this.btnBorc.Size = new System.Drawing.Size(108, 64);
            this.btnBorc.TabIndex = 2;
            this.btnBorc.Text = "BORÇ";
            this.btnBorc.Click += new System.EventHandler(this.btnBorc_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSatis.Appearance.Options.UseFont = true;
            this.btnSatis.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSatis.Image = ((System.Drawing.Image)(resources.GetObject("btnSatis.Image")));
            this.btnSatis.Location = new System.Drawing.Point(859, 2);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(182, 64);
            this.btnSatis.TabIndex = 1;
            this.btnSatis.Text = "SATIŞ ( F5 )";
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtTutar.EditValue = "00.00 ₺";
            this.txtTutar.Location = new System.Drawing.Point(2, 2);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.txtTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 35F);
            this.txtTutar.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.txtTutar.Properties.Appearance.Options.UseBackColor = true;
            this.txtTutar.Properties.Appearance.Options.UseFont = true;
            this.txtTutar.Properties.Appearance.Options.UseForeColor = true;
            this.txtTutar.Size = new System.Drawing.Size(254, 64);
            this.txtTutar.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panel1);
            this.panelControl3.Controls.Add(this.nmrGuncellenecekAdet);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.pctResim);
            this.panelControl3.Controls.Add(this.txtFiyati);
            this.panelControl3.Controls.Add(this.txtTedarikci);
            this.panelControl3.Controls.Add(this.txtUrunAdi);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(0, 48);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(259, 413);
            this.panelControl3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnCikar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(2, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 59);
            this.panel1.TabIndex = 3;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(111, 0);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(144, 59);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCikar.Appearance.Options.UseFont = true;
            this.btnCikar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCikar.Image = ((System.Drawing.Image)(resources.GetObject("btnCikar.Image")));
            this.btnCikar.Location = new System.Drawing.Point(0, 0);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(111, 59);
            this.btnCikar.TabIndex = 0;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // nmrGuncellenecekAdet
            // 
            this.nmrGuncellenecekAdet.Font = new System.Drawing.Font("Tahoma", 25F);
            this.nmrGuncellenecekAdet.Location = new System.Drawing.Point(67, 294);
            this.nmrGuncellenecekAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrGuncellenecekAdet.Name = "nmrGuncellenecekAdet";
            this.nmrGuncellenecekAdet.Size = new System.Drawing.Size(189, 48);
            this.nmrGuncellenecekAdet.TabIndex = 7;
            this.nmrGuncellenecekAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrGuncellenecekAdet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmrGuncellenecekAdet_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl3.Location = new System.Drawing.Point(7, 306);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 24);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Adet :";
            // 
            // pctResim
            // 
            this.pctResim.Dock = System.Windows.Forms.DockStyle.Top;
            this.pctResim.Location = new System.Drawing.Point(2, 2);
            this.pctResim.Name = "pctResim";
            this.pctResim.Size = new System.Drawing.Size(255, 166);
            this.pctResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctResim.TabIndex = 4;
            this.pctResim.TabStop = false;
            // 
            // txtFiyati
            // 
            this.txtFiyati.Enabled = false;
            this.txtFiyati.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtFiyati.Location = new System.Drawing.Point(2, 258);
            this.txtFiyati.Name = "txtFiyati";
            this.txtFiyati.Size = new System.Drawing.Size(254, 30);
            this.txtFiyati.TabIndex = 3;
            // 
            // txtTedarikci
            // 
            this.txtTedarikci.Enabled = false;
            this.txtTedarikci.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtTedarikci.Location = new System.Drawing.Point(2, 216);
            this.txtTedarikci.Name = "txtTedarikci";
            this.txtTedarikci.Size = new System.Drawing.Size(254, 30);
            this.txtTedarikci.TabIndex = 2;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Enabled = false;
            this.txtUrunAdi.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtUrunAdi.Location = new System.Drawing.Point(2, 174);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(254, 30);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridControl1.Location = new System.Drawing.Point(259, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(784, 413);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.barkod,
            this.UrunAdi,
            this.adet,
            this.adetfiyat,
            this.toplamfiyat});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // barkod
            // 
            this.barkod.Caption = "Barkod";
            this.barkod.FieldName = "urun.Barkod";
            this.barkod.Name = "barkod";
            this.barkod.Visible = true;
            this.barkod.VisibleIndex = 0;
            // 
            // UrunAdi
            // 
            this.UrunAdi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
            this.UrunAdi.AppearanceCell.Options.UseFont = true;
            this.UrunAdi.Caption = "Urun Adı";
            this.UrunAdi.FieldName = "urun.UrunAdi";
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.Visible = true;
            this.UrunAdi.VisibleIndex = 1;
            // 
            // adet
            // 
            this.adet.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
            this.adet.AppearanceCell.Options.UseFont = true;
            this.adet.Caption = "Adet";
            this.adet.FieldName = "adet";
            this.adet.Name = "adet";
            this.adet.Visible = true;
            this.adet.VisibleIndex = 2;
            // 
            // adetfiyat
            // 
            this.adetfiyat.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
            this.adetfiyat.AppearanceCell.Options.UseFont = true;
            this.adetfiyat.Caption = "Birim Fiyatı";
            this.adetfiyat.FieldName = "adetFiyat";
            this.adetfiyat.Name = "adetfiyat";
            this.adetfiyat.Visible = true;
            this.adetfiyat.VisibleIndex = 3;
            // 
            // toplamfiyat
            // 
            this.toplamfiyat.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
            this.toplamfiyat.AppearanceCell.Options.UseFont = true;
            this.toplamfiyat.Caption = "Toplam Fiyat";
            this.toplamfiyat.FieldName = "toplamFiyat";
            this.toplamfiyat.Name = "toplamfiyat";
            this.toplamfiyat.Visible = true;
            this.toplamfiyat.VisibleIndex = 4;
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 529);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmSatis";
            this.Text = "Satış";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrGuncellenecekAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtBarkod;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private DevExpress.XtraEditors.SimpleButton btnBorc;
        private DevExpress.XtraEditors.SimpleButton btnSatis;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnCikar;
        private System.Windows.Forms.NumericUpDown nmrGuncellenecekAdet;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.PictureBox pctResim;
        private System.Windows.Forms.TextBox txtFiyati;
        private System.Windows.Forms.TextBox txtTedarikci;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn UrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn adet;
        private DevExpress.XtraGrid.Columns.GridColumn adetfiyat;
        private DevExpress.XtraGrid.Columns.GridColumn toplamfiyat;
        private DevExpress.XtraGrid.Columns.GridColumn barkod;

    }
}