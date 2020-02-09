namespace YemekYemek.BackOffice.OdemeTuru
{
    partial class FrmOdemeTuru
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
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.gridConOdemeTuru = new DevExpress.XtraGrid.GridControl();
            this.gridOdemeTuru = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpKontroluMenu)).BeginInit();
            this.grpKontroluMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConOdemeTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeTuru)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(796, 41);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Ödeme Kartları";
            // 
            // grpKontroluMenu
            // 
            this.grpKontroluMenu.Controls.Add(this.btnKapat);
            this.grpKontroluMenu.Controls.Add(this.btnGuncelle);
            this.grpKontroluMenu.Controls.Add(this.btnSil);
            this.grpKontroluMenu.Controls.Add(this.btnDuzenle);
            this.grpKontroluMenu.Controls.Add(this.btnEkle);
            this.grpKontroluMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpKontroluMenu.Location = new System.Drawing.Point(0, 378);
            this.grpKontroluMenu.Name = "grpKontroluMenu";
            this.grpKontroluMenu.Size = new System.Drawing.Size(796, 70);
            this.grpKontroluMenu.TabIndex = 3;
            this.grpKontroluMenu.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.close_32x32;
            this.btnKapat.Location = new System.Drawing.Point(708, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 40);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.updatetableofcontents_32x32;
            this.btnGuncelle.Location = new System.Drawing.Point(276, 23);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(107, 40);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.deletedatasource_32x32;
            this.btnSil.Location = new System.Drawing.Point(195, 23);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 40);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.editdatasource_32x32;
            this.btnDuzenle.Location = new System.Drawing.Point(93, 23);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(96, 40);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.addnewdatasource_32x32;
            this.btnEkle.Location = new System.Drawing.Point(12, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 40);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // gridConOdemeTuru
            // 
            this.gridConOdemeTuru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConOdemeTuru.Location = new System.Drawing.Point(0, 41);
            this.gridConOdemeTuru.MainView = this.gridOdemeTuru;
            this.gridConOdemeTuru.Name = "gridConOdemeTuru";
            this.gridConOdemeTuru.Size = new System.Drawing.Size(796, 337);
            this.gridConOdemeTuru.TabIndex = 4;
            this.gridConOdemeTuru.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridOdemeTuru});
            // 
            // gridOdemeTuru
            // 
            this.gridOdemeTuru.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAciklama,
            this.colOdemeTuruKodu,
            this.colOdemeTuruAdi,
            this.colKasaGiris,
            this.colKasaCikis,
            this.colBakiye});
            this.gridOdemeTuru.GridControl = this.gridConOdemeTuru;
            this.gridOdemeTuru.Name = "gridOdemeTuru";
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            this.colAciklama.Width = 212;
            // 
            // colOdemeTuruKodu
            // 
            this.colOdemeTuruKodu.FieldName = "OdemeTuruKodu";
            this.colOdemeTuruKodu.Name = "colOdemeTuruKodu";
            this.colOdemeTuruKodu.Visible = true;
            this.colOdemeTuruKodu.VisibleIndex = 0;
            this.colOdemeTuruKodu.Width = 129;
            // 
            // colOdemeTuruAdi
            // 
            this.colOdemeTuruAdi.FieldName = "OdemeTuruAdi";
            this.colOdemeTuruAdi.Name = "colOdemeTuruAdi";
            this.colOdemeTuruAdi.Visible = true;
            this.colOdemeTuruAdi.VisibleIndex = 1;
            this.colOdemeTuruAdi.Width = 129;
            // 
            // colKasaGiris
            // 
            this.colKasaGiris.Caption = "Kasa Giriş";
            this.colKasaGiris.FieldName = "KasaGiris";
            this.colKasaGiris.Name = "colKasaGiris";
            this.colKasaGiris.Visible = true;
            this.colKasaGiris.VisibleIndex = 3;
            this.colKasaGiris.Width = 101;
            // 
            // colKasaCikis
            // 
            this.colKasaCikis.Caption = "Kasa Çıkış";
            this.colKasaCikis.FieldName = "KasaCikis";
            this.colKasaCikis.Name = "colKasaCikis";
            this.colKasaCikis.Visible = true;
            this.colKasaCikis.VisibleIndex = 4;
            this.colKasaCikis.Width = 101;
            // 
            // colBakiye
            // 
            this.colBakiye.Caption = "Bakiye";
            this.colBakiye.FieldName = "Bakiye";
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.Visible = true;
            this.colBakiye.VisibleIndex = 5;
            this.colBakiye.Width = 106;
            // 
            // FrmOdemeTuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 448);
            this.Controls.Add(this.gridConOdemeTuru);
            this.Controls.Add(this.grpKontroluMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmOdemeTuru";
            this.Text = "Ödeme Türü";
            this.Load += new System.EventHandler(this.FrmOdemeTuru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpKontroluMenu)).EndInit();
            this.grpKontroluMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridConOdemeTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeTuru)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpKontroluMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraGrid.GridControl gridConOdemeTuru;
        private DevExpress.XtraGrid.Views.Grid.GridView gridOdemeTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaGiris;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colBakiye;
    }
}