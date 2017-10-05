namespace Barkod_Otomasyon
{
    partial class frmGenelSatislarOn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenelSatislarOn));
            this.dtIlkTarih = new DevExpress.XtraScheduler.DateNavigator();
            this.dtSonTarih = new DevExpress.XtraScheduler.DateNavigator();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.chkTumSatislar = new DevExpress.XtraEditors.CheckEdit();
            this.btnGoster = new DevExpress.XtraEditors.SimpleButton();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtIlkTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtIlkTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSonTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSonTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTumSatislar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtIlkTarih
            // 
            this.dtIlkTarih.AllowAnimatedContentChange = true;
            this.dtIlkTarih.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dtIlkTarih.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dtIlkTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtIlkTarih.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtIlkTarih.Location = new System.Drawing.Point(12, 31);
            this.dtIlkTarih.Name = "dtIlkTarih";
            this.dtIlkTarih.Size = new System.Drawing.Size(213, 243);
            this.dtIlkTarih.TabIndex = 0;
            // 
            // dtSonTarih
            // 
            this.dtSonTarih.AllowAnimatedContentChange = true;
            this.dtSonTarih.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dtSonTarih.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dtSonTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSonTarih.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtSonTarih.Location = new System.Drawing.Point(281, 31);
            this.dtSonTarih.Name = "dtSonTarih";
            this.dtSonTarih.Size = new System.Drawing.Size(213, 243);
            this.dtSonTarih.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(244, 125);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "--->";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(244, 144);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(16, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "<--";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "İlk Tarih  :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(281, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Son Tarih  :";
            // 
            // chkTumSatislar
            // 
            this.chkTumSatislar.Location = new System.Drawing.Point(12, 280);
            this.chkTumSatislar.Name = "chkTumSatislar";
            this.chkTumSatislar.Properties.Caption = "Tüm Satışları Getir";
            this.chkTumSatislar.Size = new System.Drawing.Size(147, 19);
            this.chkTumSatislar.TabIndex = 6;
            this.chkTumSatislar.CheckedChanged += new System.EventHandler(this.chkTumSatislar_CheckedChanged);
            // 
            // btnGoster
            // 
            this.btnGoster.Image = ((System.Drawing.Image)(resources.GetObject("btnGoster.Image")));
            this.btnGoster.Location = new System.Drawing.Point(396, 295);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(98, 46);
            this.btnGoster.TabIndex = 7;
            this.btnGoster.Text = "Göster";
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Image = ((System.Drawing.Image)(resources.GetObject("btnIptal.Image")));
            this.btnIptal.Location = new System.Drawing.Point(292, 295);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(98, 46);
            this.btnIptal.TabIndex = 8;
            this.btnIptal.Text = "Iptal";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // frmGenelSatislarOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 353);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.chkTumSatislar);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtSonTarih);
            this.Controls.Add(this.dtIlkTarih);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGenelSatislarOn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Aralığı Seçin";
            this.Load += new System.EventHandler(this.frmGenelSatislarOn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtIlkTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtIlkTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSonTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSonTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTumSatislar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraScheduler.DateNavigator dtIlkTarih;
        private DevExpress.XtraScheduler.DateNavigator dtSonTarih;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit chkTumSatislar;
        private DevExpress.XtraEditors.SimpleButton btnGoster;
        private DevExpress.XtraEditors.SimpleButton btnIptal;

    }
}