namespace Barkod_Otomasyon
{
    partial class frmFiyatOgren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiyatOgren));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtBarkod = new DevExpress.XtraEditors.TextEdit();
            this.txtUrun = new DevExpress.XtraEditors.TextEdit();
            this.txtSatisFiyati = new DevExpress.XtraEditors.TextEdit();
            this.txtTedarikci = new DevExpress.XtraEditors.TextEdit();
            this.pctResim = new System.Windows.Forms.PictureBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnBul = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTedarikci.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctResim)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Location = new System.Drawing.Point(40, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 23);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Barkod :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl2.Location = new System.Drawing.Point(57, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 23);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ürün :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl3.Location = new System.Drawing.Point(23, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 23);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tedarikçi :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl4.Location = new System.Drawing.Point(10, 176);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(101, 23);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Satış Fiyatı :";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarkod.EditValue = "";
            this.txtBarkod.Location = new System.Drawing.Point(124, 17);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtBarkod.Properties.Appearance.Options.UseFont = true;
            this.txtBarkod.Size = new System.Drawing.Size(974, 30);
            this.txtBarkod.TabIndex = 1;
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
            this.txtBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkod_KeyPress);
            // 
            // txtUrun
            // 
            this.txtUrun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrun.EditValue = "";
            this.txtUrun.Enabled = false;
            this.txtUrun.Location = new System.Drawing.Point(124, 59);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtUrun.Properties.Appearance.Options.UseFont = true;
            this.txtUrun.Size = new System.Drawing.Size(974, 30);
            this.txtUrun.TabIndex = 6;
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSatisFiyati.EditValue = "";
            this.txtSatisFiyati.Location = new System.Drawing.Point(124, 165);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 24F);
            this.txtSatisFiyati.Properties.Appearance.Options.UseFont = true;
            this.txtSatisFiyati.Properties.ReadOnly = true;
            this.txtSatisFiyati.Size = new System.Drawing.Size(974, 46);
            this.txtSatisFiyati.TabIndex = 8;
            // 
            // txtTedarikci
            // 
            this.txtTedarikci.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTedarikci.EditValue = "";
            this.txtTedarikci.Enabled = false;
            this.txtTedarikci.Location = new System.Drawing.Point(124, 98);
            this.txtTedarikci.Name = "txtTedarikci";
            this.txtTedarikci.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtTedarikci.Properties.Appearance.Options.UseFont = true;
            this.txtTedarikci.Size = new System.Drawing.Size(974, 30);
            this.txtTedarikci.TabIndex = 7;
            // 
            // pctResim
            // 
            this.pctResim.Enabled = false;
            this.pctResim.Image = global::Barkod_Otomasyon.Properties.Resources.ResimYok;
            this.pctResim.Location = new System.Drawing.Point(124, 229);
            this.pctResim.Name = "pctResim";
            this.pctResim.Size = new System.Drawing.Size(250, 250);
            this.pctResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctResim.TabIndex = 9;
            this.pctResim.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl5.Location = new System.Drawing.Point(42, 245);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 23);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Görseli :";
            // 
            // btnBul
            // 
            this.btnBul.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnBul.Appearance.Options.UseFont = true;
            this.btnBul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBul.Image = ((System.Drawing.Image)(resources.GetObject("btnBul.Image")));
            this.btnBul.Location = new System.Drawing.Point(0, 0);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(1110, 55);
            this.btnBul.TabIndex = 11;
            this.btnBul.Text = "Bul";
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBul);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 627);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 55);
            this.panel1.TabIndex = 13;
            // 
            // frmFiyatOgren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.pctResim);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.txtTedarikci);
            this.Controls.Add(this.txtUrun);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtBarkod);
            this.Name = "frmFiyatOgren";
            this.RightToLeftLayout = true;
            this.Text = "Fiyat Öğren";
            this.Load += new System.EventHandler(this.frmFiyatOgren_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTedarikci.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctResim)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtBarkod;
        private DevExpress.XtraEditors.TextEdit txtUrun;
        private DevExpress.XtraEditors.TextEdit txtSatisFiyati;
        private DevExpress.XtraEditors.TextEdit txtTedarikci;
        private System.Windows.Forms.PictureBox pctResim;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnBul;
        private System.Windows.Forms.Panel panel1;

    }
}