namespace YemekYemek.BackOffice.Kasa
{
    partial class FrmKasaHareket
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
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridConKasaHareket = new DevExpress.XtraGrid.GridControl();
            this.gridKasaHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridConOdemeTuruToplam = new DevExpress.XtraGrid.GridControl();
            this.gridOdemeTuruToplam = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridConGenelToplam = new DevExpress.XtraGrid.GridControl();
            this.gridGenelToplam = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpKontroluMenu)).BeginInit();
            this.grpKontroluMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConKasaHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasaHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConOdemeTuruToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeTuruToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConGenelToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGenelToplam)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Image = global::YemekYemek.BackOffice.Properties.Resources.convert_32x32;
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
            this.lblBaslik.Size = new System.Drawing.Size(1008, 41);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Kasa Hareketleri";
            // 
            // grpKontroluMenu
            // 
            this.grpKontroluMenu.Controls.Add(this.btnKapat);
            this.grpKontroluMenu.Controls.Add(this.btnAra);
            this.grpKontroluMenu.Controls.Add(this.btnGuncelle);
            this.grpKontroluMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpKontroluMenu.Location = new System.Drawing.Point(0, 659);
            this.grpKontroluMenu.Name = "grpKontroluMenu";
            this.grpKontroluMenu.Size = new System.Drawing.Size(1008, 70);
            this.grpKontroluMenu.TabIndex = 3;
            this.grpKontroluMenu.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.close_32x32;
            this.btnKapat.Location = new System.Drawing.Point(206, 25);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 40);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.lookup_reference_32x32;
            this.btnAra.Location = new System.Drawing.Point(125, 25);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 40);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.updatetableofcontents_32x32;
            this.btnGuncelle.Location = new System.Drawing.Point(12, 25);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(107, 40);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 41);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridConKasaHareket);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1008, 618);
            this.splitContainerControl1.SplitterPosition = 439;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridConKasaHareket
            // 
            this.gridConKasaHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConKasaHareket.Location = new System.Drawing.Point(0, 0);
            this.gridConKasaHareket.MainView = this.gridKasaHareket;
            this.gridConKasaHareket.Name = "gridConKasaHareket";
            this.gridConKasaHareket.Size = new System.Drawing.Size(1008, 439);
            this.gridConKasaHareket.TabIndex = 1;
            this.gridConKasaHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKasaHareket});
            // 
            // gridKasaHareket
            // 
            this.gridKasaHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTarih,
            this.colSaat,
            this.colFisKodu,
            this.colHareket,
            this.colOdemeTuru,
            this.colCariKodu,
            this.colCariAdi,
            this.ColTutar});
            this.gridKasaHareket.GridControl = this.gridConKasaHareket;
            this.gridKasaHareket.Name = "gridKasaHareket";
            this.gridKasaHareket.OptionsView.ShowGroupPanel = false;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.DisplayFormat.FormatString = "d";
            this.colTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 0;
            // 
            // colSaat
            // 
            this.colSaat.Caption = "Saat";
            this.colSaat.DisplayFormat.FormatString = "t";
            this.colSaat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSaat.FieldName = "Tarih";
            this.colSaat.Name = "colSaat";
            this.colSaat.Visible = true;
            this.colSaat.VisibleIndex = 1;
            // 
            // colFisKodu
            // 
            this.colFisKodu.Caption = "Fiş Kodu";
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 2;
            // 
            // colHareket
            // 
            this.colHareket.Caption = "Hareket";
            this.colHareket.FieldName = "Hareket";
            this.colHareket.Name = "colHareket";
            this.colHareket.Visible = true;
            this.colHareket.VisibleIndex = 3;
            // 
            // colOdemeTuru
            // 
            this.colOdemeTuru.Caption = "Ödeme Türü";
            this.colOdemeTuru.FieldName = "OdemeTuruAdi";
            this.colOdemeTuru.Name = "colOdemeTuru";
            this.colOdemeTuru.Visible = true;
            this.colOdemeTuru.VisibleIndex = 4;
            // 
            // colCariKodu
            // 
            this.colCariKodu.Caption = "Cari Kodu";
            this.colCariKodu.FieldName = "CariKodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 5;
            // 
            // colCariAdi
            // 
            this.colCariAdi.Caption = "Cari Adı";
            this.colCariAdi.FieldName = "CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 6;
            // 
            // ColTutar
            // 
            this.ColTutar.Caption = "Tutar";
            this.ColTutar.FieldName = "Tutar";
            this.ColTutar.Name = "ColTutar";
            this.ColTutar.Visible = true;
            this.ColTutar.VisibleIndex = 7;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1008, 174);
            this.splitContainerControl2.SplitterPosition = 510;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridConOdemeTuruToplam);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(510, 174);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Ödeme Türüne Göre Toplamlar";
            // 
            // gridConOdemeTuruToplam
            // 
            this.gridConOdemeTuruToplam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConOdemeTuruToplam.Location = new System.Drawing.Point(2, 20);
            this.gridConOdemeTuruToplam.MainView = this.gridOdemeTuruToplam;
            this.gridConOdemeTuruToplam.Name = "gridConOdemeTuruToplam";
            this.gridConOdemeTuruToplam.Size = new System.Drawing.Size(506, 152);
            this.gridConOdemeTuruToplam.TabIndex = 2;
            this.gridConOdemeTuruToplam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridOdemeTuruToplam});
            // 
            // gridOdemeTuruToplam
            // 
            this.gridOdemeTuruToplam.GridControl = this.gridConOdemeTuruToplam;
            this.gridOdemeTuruToplam.Name = "gridOdemeTuruToplam";
            this.gridOdemeTuruToplam.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridConGenelToplam);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(493, 174);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Genel Toplamlar";
            // 
            // gridConGenelToplam
            // 
            this.gridConGenelToplam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConGenelToplam.Location = new System.Drawing.Point(2, 20);
            this.gridConGenelToplam.MainView = this.gridGenelToplam;
            this.gridConGenelToplam.Name = "gridConGenelToplam";
            this.gridConGenelToplam.Size = new System.Drawing.Size(489, 152);
            this.gridConGenelToplam.TabIndex = 2;
            this.gridConGenelToplam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridGenelToplam});
            // 
            // gridGenelToplam
            // 
            this.gridGenelToplam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridGenelToplam.GridControl = this.gridConGenelToplam;
            this.gridGenelToplam.Name = "gridGenelToplam";
            this.gridGenelToplam.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Bilgi";
            this.gridColumn6.FieldName = "Bilgi";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Kayıt Sayısı";
            this.gridColumn7.FieldName = "KayitSayisi";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Genel Toplam";
            this.gridColumn8.FieldName = "Toplam";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            // 
            // FrmKasaHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpKontroluMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmKasaHareket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Hareket";
            this.Load += new System.EventHandler(this.FrmKasaHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpKontroluMenu)).EndInit();
            this.grpKontroluMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridConKasaHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasaHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridConOdemeTuruToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeTuruToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridConGenelToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGenelToplam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpKontroluMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridConKasaHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKasaHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridConOdemeTuruToplam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridOdemeTuruToplam;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridConGenelToplam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridGenelToplam;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn ColTutar;
    }
}