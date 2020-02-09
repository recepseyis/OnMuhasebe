namespace YemekYemek.BackOffice.Cari
{
    partial class FrmCariHareket
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
            this.gridConCariHareket = new DevExpress.XtraGrid.GridControl();
            this.gridCariHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlasiyerKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlasiyerAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdenen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKalanTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridConFisToplam = new DevExpress.XtraGrid.GridControl();
            this.gridFisToplam = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFisTuruBilgi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisTuruKayitSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisTuruToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridConBakiye = new DevExpress.XtraGrid.GridControl();
            this.gridBakiye = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpKontroluMenu)).BeginInit();
            this.grpKontroluMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConCariHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCariHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConFisToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFisToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConBakiye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBakiye)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Image = global::YemekYemek.BackOffice.Properties.Resources.customer_32x321;
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
            this.lblBaslik.Size = new System.Drawing.Size(1086, 41);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Cari Hareketleri";
            // 
            // grpKontroluMenu
            // 
            this.grpKontroluMenu.Controls.Add(this.btnKapat);
            this.grpKontroluMenu.Controls.Add(this.btnAra);
            this.grpKontroluMenu.Controls.Add(this.btnGuncelle);
            this.grpKontroluMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpKontroluMenu.Location = new System.Drawing.Point(0, 544);
            this.grpKontroluMenu.Name = "grpKontroluMenu";
            this.grpKontroluMenu.Size = new System.Drawing.Size(1086, 70);
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
            this.splitContainerControl1.Panel1.Controls.Add(this.gridConCariHareket);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1086, 503);
            this.splitContainerControl1.SplitterPosition = 289;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridConCariHareket
            // 
            this.gridConCariHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConCariHareket.Location = new System.Drawing.Point(0, 0);
            this.gridConCariHareket.MainView = this.gridCariHareket;
            this.gridConCariHareket.Name = "gridConCariHareket";
            this.gridConCariHareket.Size = new System.Drawing.Size(1086, 289);
            this.gridConCariHareket.TabIndex = 1;
            this.gridConCariHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridCariHareket});
            // 
            // gridCariHareket
            // 
            this.gridCariHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAciklama,
            this.colFisKodu,
            this.colFisTuru,
            this.colBelgeNo,
            this.colSaat,
            this.colTarih,
            this.colPlasiyerKodu,
            this.colPlasiyerAdi,
            this.colIskontoOrani,
            this.colIskontoTutar,
            this.colToplamTutar,
            this.colOdenen,
            this.colKalanTutar});
            this.gridCariHareket.GridControl = this.gridConCariHareket;
            this.gridCariHareket.Name = "gridCariHareket";
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 7;
            this.colAciklama.Width = 231;
            // 
            // colFisKodu
            // 
            this.colFisKodu.Caption = "Fiş Kodu";
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.OptionsColumn.AllowEdit = false;
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 1;
            this.colFisKodu.Width = 89;
            // 
            // colFisTuru
            // 
            this.colFisTuru.Caption = "Fiş Türü";
            this.colFisTuru.FieldName = "FisTuru";
            this.colFisTuru.Name = "colFisTuru";
            this.colFisTuru.OptionsColumn.AllowEdit = false;
            this.colFisTuru.Visible = true;
            this.colFisTuru.VisibleIndex = 0;
            this.colFisTuru.Width = 151;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.Caption = "Belge No";
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.OptionsColumn.AllowEdit = false;
            this.colBelgeNo.Visible = true;
            this.colBelgeNo.VisibleIndex = 2;
            this.colBelgeNo.Width = 89;
            // 
            // colSaat
            // 
            this.colSaat.Caption = "Saat";
            this.colSaat.DisplayFormat.FormatString = "t";
            this.colSaat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSaat.FieldName = "Saat";
            this.colSaat.Name = "colSaat";
            this.colSaat.OptionsColumn.AllowEdit = false;
            this.colSaat.Visible = true;
            this.colSaat.VisibleIndex = 4;
            this.colSaat.Width = 55;
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
            this.colTarih.VisibleIndex = 3;
            this.colTarih.Width = 71;
            // 
            // colPlasiyerKodu
            // 
            this.colPlasiyerKodu.FieldName = "PlasiyerKodu";
            this.colPlasiyerKodu.Name = "colPlasiyerKodu";
            this.colPlasiyerKodu.OptionsColumn.AllowEdit = false;
            this.colPlasiyerKodu.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colPlasiyerAdi
            // 
            this.colPlasiyerAdi.FieldName = "PlasiyerAdi";
            this.colPlasiyerAdi.Name = "colPlasiyerAdi";
            this.colPlasiyerAdi.OptionsColumn.AllowEdit = false;
            this.colPlasiyerAdi.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colIskontoOrani
            // 
            this.colIskontoOrani.Caption = "İsk Oranı";
            this.colIskontoOrani.DisplayFormat.FormatString = "\'%\'0";
            this.colIskontoOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIskontoOrani.FieldName = "IskontoOrani";
            this.colIskontoOrani.Name = "colIskontoOrani";
            this.colIskontoOrani.OptionsColumn.AllowEdit = false;
            this.colIskontoOrani.Visible = true;
            this.colIskontoOrani.VisibleIndex = 5;
            this.colIskontoOrani.Width = 55;
            // 
            // colIskontoTutar
            // 
            this.colIskontoTutar.Caption = "İsk Tutar";
            this.colIskontoTutar.DisplayFormat.FormatString = "C2";
            this.colIskontoTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIskontoTutar.FieldName = "IskontoTutar";
            this.colIskontoTutar.Name = "colIskontoTutar";
            this.colIskontoTutar.OptionsColumn.AllowEdit = false;
            this.colIskontoTutar.Visible = true;
            this.colIskontoTutar.VisibleIndex = 6;
            this.colIskontoTutar.Width = 61;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Caption = "Toplam Tutar";
            this.colToplamTutar.DisplayFormat.FormatString = "C2";
            this.colToplamTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplamTutar.FieldName = "ToplamTutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.OptionsColumn.AllowEdit = false;
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 8;
            this.colToplamTutar.Width = 84;
            // 
            // colOdenen
            // 
            this.colOdenen.Caption = "Ödenen Tutar";
            this.colOdenen.DisplayFormat.FormatString = "C2";
            this.colOdenen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOdenen.FieldName = "Odenen";
            this.colOdenen.Name = "colOdenen";
            this.colOdenen.OptionsColumn.AllowEdit = false;
            this.colOdenen.Visible = true;
            this.colOdenen.VisibleIndex = 9;
            this.colOdenen.Width = 92;
            // 
            // colKalanTutar
            // 
            this.colKalanTutar.Caption = "Kalan Tutar";
            this.colKalanTutar.DisplayFormat.FormatString = "C2";
            this.colKalanTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKalanTutar.FieldName = "KalanOdeme";
            this.colKalanTutar.Name = "colKalanTutar";
            this.colKalanTutar.OptionsColumn.AllowEdit = false;
            this.colKalanTutar.Visible = true;
            this.colKalanTutar.VisibleIndex = 10;
            this.colKalanTutar.Width = 90;
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
            this.splitContainerControl2.Size = new System.Drawing.Size(1086, 209);
            this.splitContainerControl2.SplitterPosition = 651;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridConFisToplam);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(651, 209);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Fiş Türlerine Göre Toplamlar";
            // 
            // gridConFisToplam
            // 
            this.gridConFisToplam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConFisToplam.Location = new System.Drawing.Point(2, 20);
            this.gridConFisToplam.MainView = this.gridFisToplam;
            this.gridConFisToplam.Name = "gridConFisToplam";
            this.gridConFisToplam.Size = new System.Drawing.Size(647, 187);
            this.gridConFisToplam.TabIndex = 2;
            this.gridConFisToplam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridFisToplam});
            // 
            // gridFisToplam
            // 
            this.gridFisToplam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFisTuruBilgi,
            this.colFisTuruKayitSayisi,
            this.colFisTuruToplamTutar});
            this.gridFisToplam.GridControl = this.gridConFisToplam;
            this.gridFisToplam.Name = "gridFisToplam";
            this.gridFisToplam.OptionsView.ShowGroupPanel = false;
            // 
            // colFisTuruBilgi
            // 
            this.colFisTuruBilgi.Caption = "Bilgi";
            this.colFisTuruBilgi.FieldName = "Bilgi";
            this.colFisTuruBilgi.Name = "colFisTuruBilgi";
            this.colFisTuruBilgi.OptionsColumn.AllowEdit = false;
            this.colFisTuruBilgi.Visible = true;
            this.colFisTuruBilgi.VisibleIndex = 0;
            this.colFisTuruBilgi.Width = 238;
            // 
            // colFisTuruKayitSayisi
            // 
            this.colFisTuruKayitSayisi.Caption = "Kayıt Sayısı";
            this.colFisTuruKayitSayisi.FieldName = "KayitSayisi";
            this.colFisTuruKayitSayisi.Name = "colFisTuruKayitSayisi";
            this.colFisTuruKayitSayisi.OptionsColumn.AllowEdit = false;
            this.colFisTuruKayitSayisi.Visible = true;
            this.colFisTuruKayitSayisi.VisibleIndex = 1;
            this.colFisTuruKayitSayisi.Width = 125;
            // 
            // colFisTuruToplamTutar
            // 
            this.colFisTuruToplamTutar.Caption = "Toplam Tutar";
            this.colFisTuruToplamTutar.DisplayFormat.FormatString = "C2";
            this.colFisTuruToplamTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFisTuruToplamTutar.FieldName = "Tutar";
            this.colFisTuruToplamTutar.Name = "colFisTuruToplamTutar";
            this.colFisTuruToplamTutar.OptionsColumn.AllowEdit = false;
            this.colFisTuruToplamTutar.Visible = true;
            this.colFisTuruToplamTutar.VisibleIndex = 2;
            this.colFisTuruToplamTutar.Width = 127;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridConBakiye);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(430, 209);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Cari Ekstresi";
            // 
            // gridConBakiye
            // 
            this.gridConBakiye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConBakiye.Location = new System.Drawing.Point(2, 20);
            this.gridConBakiye.MainView = this.gridBakiye;
            this.gridConBakiye.Name = "gridConBakiye";
            this.gridConBakiye.Size = new System.Drawing.Size(426, 187);
            this.gridConBakiye.TabIndex = 3;
            this.gridConBakiye.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridBakiye});
            // 
            // gridBakiye
            // 
            this.gridBakiye.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3});
            this.gridBakiye.GridControl = this.gridConBakiye;
            this.gridBakiye.Name = "gridBakiye";
            this.gridBakiye.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Bilgi";
            this.gridColumn1.FieldName = "Bilgi";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 238;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Toplam Tutar";
            this.gridColumn3.DisplayFormat.FormatString = "C2";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "Tutar";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 127;
            // 
            // FrmCariHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 614);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpKontroluMenu);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCariHareket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Hareketler";
            this.Load += new System.EventHandler(this.FrmCariHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpKontroluMenu)).EndInit();
            this.grpKontroluMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridConCariHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCariHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridConFisToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFisToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridConBakiye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBakiye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpKontroluMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridConCariHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridCariHareket;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridConFisToplam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridFisToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colFisTuruBilgi;
        private DevExpress.XtraGrid.Columns.GridColumn colFisTuruKayitSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn colFisTuruToplamTutar;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colFisTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colBelgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colPlasiyerKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colPlasiyerAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colOdenen;
        private DevExpress.XtraGrid.Columns.GridColumn colKalanTutar;
        private DevExpress.XtraGrid.GridControl gridConBakiye;
        private DevExpress.XtraGrid.Views.Grid.GridView gridBakiye;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}