namespace Barkod_Otomasyon
{
    partial class frmSatisSon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisSon));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlinanTutar = new DevExpress.XtraEditors.TextEdit();
            this.txtParaUstu = new DevExpress.XtraEditors.TextEdit();
            this.btnOde = new DevExpress.XtraEditors.SimpleButton();
            this.btnDevam = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlinanTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParaUstu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alınan Tutar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(32, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Para Üstü :";
            // 
            // txtAlinanTutar
            // 
            this.txtAlinanTutar.EditValue = "00,00";
            this.txtAlinanTutar.Location = new System.Drawing.Point(126, 6);
            this.txtAlinanTutar.Name = "txtAlinanTutar";
            this.txtAlinanTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAlinanTutar.Properties.Appearance.Options.UseFont = true;
            this.txtAlinanTutar.Size = new System.Drawing.Size(230, 26);
            this.txtAlinanTutar.TabIndex = 2;
            this.txtAlinanTutar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlinanTutar_KeyDown);
            this.txtAlinanTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlinanTutar_KeyPress);
            // 
            // txtParaUstu
            // 
            this.txtParaUstu.Location = new System.Drawing.Point(126, 83);
            this.txtParaUstu.Name = "txtParaUstu";
            this.txtParaUstu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtParaUstu.Properties.Appearance.Options.UseFont = true;
            this.txtParaUstu.Properties.ReadOnly = true;
            this.txtParaUstu.Size = new System.Drawing.Size(230, 26);
            this.txtParaUstu.TabIndex = 3;
            // 
            // btnOde
            // 
            this.btnOde.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnOde.Appearance.Options.UseFont = true;
            this.btnOde.Image = ((System.Drawing.Image)(resources.GetObject("btnOde.Image")));
            this.btnOde.Location = new System.Drawing.Point(261, 38);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(95, 39);
            this.btnOde.TabIndex = 4;
            this.btnOde.Text = "Öde";
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // btnDevam
            // 
            this.btnDevam.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDevam.Appearance.Options.UseFont = true;
            this.btnDevam.Image = ((System.Drawing.Image)(resources.GetObject("btnDevam.Image")));
            this.btnDevam.Location = new System.Drawing.Point(16, 38);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(215, 39);
            this.btnDevam.TabIndex = 5;
            this.btnDevam.Text = "Alışverişe Devam Et";
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // frmSatisSon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 118);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.txtParaUstu);
            this.Controls.Add(this.txtAlinanTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSatisSon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Yöntemi";
            this.Load += new System.EventHandler(this.frmSatisSon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAlinanTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParaUstu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtAlinanTutar;
        private DevExpress.XtraEditors.TextEdit txtParaUstu;
        private DevExpress.XtraEditors.SimpleButton btnOde;
        private DevExpress.XtraEditors.SimpleButton btnDevam;
    }
}