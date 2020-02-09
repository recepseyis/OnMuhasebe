namespace YemekYemek.Update
{
    partial class frm
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
            this.btnIndir = new DevExpress.XtraEditors.SimpleButton();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblindirilenVeri = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIndir
            // 
            this.btnIndir.Location = new System.Drawing.Point(39, 538);
            this.btnIndir.Name = "btnIndir";
            this.btnIndir.Size = new System.Drawing.Size(381, 55);
            this.btnIndir.TabIndex = 0;
            this.btnIndir.Text = "Güncellemeleri İndir";
            this.btnIndir.Click += new System.EventHandler(this.btnIndir_Click);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(0, 478);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Properties.Step = 1;
            this.progressBarControl1.Properties.TextOrientation = DevExpress.Utils.Drawing.TextOrientation.Horizontal;
            this.progressBarControl1.ShowProgressInTaskBar = true;
            this.progressBarControl1.Size = new System.Drawing.Size(481, 18);
            this.progressBarControl1.TabIndex = 2;
            // 
            // lblindirilenVeri
            // 
            this.lblindirilenVeri.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblindirilenVeri.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.lblindirilenVeri.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblindirilenVeri.Appearance.Options.UseBackColor = true;
            this.lblindirilenVeri.Appearance.Options.UseFont = true;
            this.lblindirilenVeri.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblindirilenVeri.Location = new System.Drawing.Point(147, 502);
            this.lblindirilenVeri.Name = "lblindirilenVeri";
            this.lblindirilenVeri.Size = new System.Drawing.Size(0, 33);
            this.lblindirilenVeri.TabIndex = 3;
            this.lblindirilenVeri.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YemekYemek.Update.Properties.Resources.Aa4C;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 486);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 597);
            this.ControlBox = false;
            this.Controls.Add(this.btnIndir);
            this.Controls.Add(this.lblindirilenVeri);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnIndir;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.LabelControl lblindirilenVeri;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

