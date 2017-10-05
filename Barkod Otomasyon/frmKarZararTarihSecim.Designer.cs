namespace Barkod_Otomasyon
{
    partial class frmKarZararTarihSecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKarZararTarihSecim));
            this.dtIlkTarih = new DevExpress.XtraScheduler.DateNavigator();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtSonTarih = new DevExpress.XtraScheduler.DateNavigator();
            this.btnDevamEt = new DevExpress.XtraEditors.SimpleButton();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtIlkTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtIlkTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSonTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSonTarih.CalendarTimeProperties)).BeginInit();
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
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "İlk Tarih :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(257, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Son Tarih :";
            // 
            // dtSonTarih
            // 
            this.dtSonTarih.AllowAnimatedContentChange = true;
            this.dtSonTarih.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dtSonTarih.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dtSonTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSonTarih.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtSonTarih.Location = new System.Drawing.Point(257, 31);
            this.dtSonTarih.Name = "dtSonTarih";
            this.dtSonTarih.Size = new System.Drawing.Size(213, 243);
            this.dtSonTarih.TabIndex = 3;
            // 
            // btnDevamEt
            // 
            this.btnDevamEt.Image = ((System.Drawing.Image)(resources.GetObject("btnDevamEt.Image")));
            this.btnDevamEt.Location = new System.Drawing.Point(373, 280);
            this.btnDevamEt.Name = "btnDevamEt";
            this.btnDevamEt.Size = new System.Drawing.Size(97, 32);
            this.btnDevamEt.TabIndex = 4;
            this.btnDevamEt.Text = "Devam Et";
            this.btnDevamEt.Click += new System.EventHandler(this.btnDevamEt_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Image = ((System.Drawing.Image)(resources.GetObject("btnIptal.Image")));
            this.btnIptal.Location = new System.Drawing.Point(257, 280);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(97, 32);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "İptal";
            // 
            // frmKarZararTarihSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 319);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnDevamEt);
            this.Controls.Add(this.dtSonTarih);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtIlkTarih);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKarZararTarihSecim";
            this.Text = "Tarih Seçin";
            this.Load += new System.EventHandler(this.frmKarZararTarihSecim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtIlkTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtIlkTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSonTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSonTarih)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraScheduler.DateNavigator dtIlkTarih;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraScheduler.DateNavigator dtSonTarih;
        private DevExpress.XtraEditors.SimpleButton btnDevamEt;
        private DevExpress.XtraEditors.SimpleButton btnIptal;

    }
}