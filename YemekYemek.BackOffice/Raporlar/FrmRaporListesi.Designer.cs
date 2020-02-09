namespace YemekYemek.BackOffice.Raporlar
{
    partial class FrmRaporListesi
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
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpKontroluMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.linkRptStokDurumu = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.linkRptStokHareketleri = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtRaporAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtRaporGrubu = new DevExpress.XtraEditors.TextEdit();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.linkRptBilgiFisi = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.grpKontroluMenu)).BeginInit();
            this.grpKontroluMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaporAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaporGrubu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Image = global::YemekYemek.BackOffice.Properties.Resources.customer_32x32;
            this.lblBaslik.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseImage = true;
            this.lblBaslik.Appearance.Options.UseImageAlign = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1050, 41);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Raporlar";
            // 
            // grpKontroluMenu
            // 
            this.grpKontroluMenu.Controls.Add(this.btnEkle);
            this.grpKontroluMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpKontroluMenu.Location = new System.Drawing.Point(0, 540);
            this.grpKontroluMenu.Name = "grpKontroluMenu";
            this.grpKontroluMenu.Size = new System.Drawing.Size(1050, 70);
            this.grpKontroluMenu.TabIndex = 3;
            this.grpKontroluMenu.Text = "Menü";
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.reportlayoutpivottable_32x322;
            this.btnEkle.Location = new System.Drawing.Point(12, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(109, 40);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Görüntüle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup4});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.linkRptStokDurumu,
            this.navBarItem2,
            this.navBarItem3,
            this.linkRptStokHareketleri,
            this.navBarItem5,
            this.linkRptBilgiFisi});
            this.navBarControl1.Location = new System.Drawing.Point(0, 41);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 270;
            this.navBarControl1.Size = new System.Drawing.Size(270, 499);
            this.navBarControl1.TabIndex = 4;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Stok Raporları";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.linkRptStokDurumu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // linkRptStokDurumu
            // 
            this.linkRptStokDurumu.Caption = "Genel Stok Durumu";
            this.linkRptStokDurumu.Name = "linkRptStokDurumu";
            this.linkRptStokDurumu.Tag = "Bu Rapor Stok Giriş-Çıkış-Mevcut Stok Bilgilerini Gösterir.";
            this.linkRptStokDurumu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarLink_Clicked);
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Stok Listesi";
            this.navBarItem2.Name = "navBarItem2";
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Grup Bazında Liste";
            this.navBarItem3.Name = "navBarItem3";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Stok Hareket Raporları";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.linkRptStokHareketleri)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // linkRptStokHareketleri
            // 
            this.linkRptStokHareketleri.Caption = "Stok Hareket";
            this.linkRptStokHareketleri.Name = "linkRptStokHareketleri";
            this.linkRptStokHareketleri.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarLink_Clicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Cari Raporları";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Cari Genel";
            this.navBarItem5.Name = "navBarItem5";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtAciklama);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.txtRaporAdi);
            this.groupControl1.Controls.Add(this.txtRaporGrubu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(270, 41);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(780, 189);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Rapor Bilgieri";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAciklama.Location = new System.Drawing.Point(109, 80);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Properties.ReadOnly = true;
            this.txtAciklama.Size = new System.Drawing.Size(659, 89);
            this.txtAciklama.TabIndex = 9;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(6, 80);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(57, 16);
            this.labelControl15.TabIndex = 6;
            this.labelControl15.Text = "Açıklama";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 16);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Rapor Adı";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(6, 55);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(81, 16);
            this.labelControl13.TabIndex = 7;
            this.labelControl13.Text = "Rapor Grubu";
            // 
            // txtRaporAdi
            // 
            this.txtRaporAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRaporAdi.Location = new System.Drawing.Point(109, 28);
            this.txtRaporAdi.Name = "txtRaporAdi";
            this.txtRaporAdi.Properties.ReadOnly = true;
            this.txtRaporAdi.Size = new System.Drawing.Size(659, 20);
            this.txtRaporAdi.TabIndex = 8;
            // 
            // txtRaporGrubu
            // 
            this.txtRaporGrubu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRaporGrubu.Location = new System.Drawing.Point(109, 54);
            this.txtRaporGrubu.Name = "txtRaporGrubu";
            this.txtRaporGrubu.Properties.ReadOnly = true;
            this.txtRaporGrubu.Size = new System.Drawing.Size(659, 20);
            this.txtRaporGrubu.TabIndex = 8;
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(270, 230);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(780, 310);
            this.filterControl1.TabIndex = 6;
            this.filterControl1.Text = "filterControl1";
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Bilgi Fişi";
            this.navBarGroup4.Expanded = true;
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.linkRptBilgiFisi)});
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // linkRptBilgiFisi
            // 
            this.linkRptBilgiFisi.Caption = "Bilgi Fişi";
            this.linkRptBilgiFisi.Name = "linkRptBilgiFisi";
            this.linkRptBilgiFisi.Tag = "Bilgi Fişi Müşteriye Faturasız İşlem Yapıldığını Sadece Sipariş Belgesi Vermek iç" +
    "in Kullanılır.";
            this.linkRptBilgiFisi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarLink_Clicked);
            // 
            // FrmRaporListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.filterControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.grpKontroluMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmRaporListesi";
            this.Text = "Raporlar Listesi";
            this.Load += new System.EventHandler(this.FrmRaporListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpKontroluMenu)).EndInit();
            this.grpKontroluMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaporAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaporGrubu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpKontroluMenu;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem linkRptStokDurumu;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem linkRptStokHareketleri;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtRaporGrubu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtRaporAdi;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarItem linkRptBilgiFisi;
    }
}