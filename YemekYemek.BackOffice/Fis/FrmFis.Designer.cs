namespace YemekYemek.BackOffice.Fis
{
    partial class FrmFis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFis));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpKontroluMenu = new DevExpress.XtraEditors.GroupControl();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barAlisFatura = new DevExpress.XtraBars.BarButtonItem();
            this.barSatisFatura = new DevExpress.XtraBars.BarButtonItem();
            this.barToptanSatisFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.barAlisIadeFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.barSatisİadeFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.barTahsilatFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barOdemeFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barCariDevirFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barStokDevirFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barSayimEksigiFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barSayimFazlasiFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpKontroluMenu)).BeginInit();
            this.grpKontroluMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(1268, 41);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Fiş ve Faturalar";
            // 
            // grpKontroluMenu
            // 
            this.grpKontroluMenu.Controls.Add(this.dropDownButton1);
            this.grpKontroluMenu.Controls.Add(this.btnKapat);
            this.grpKontroluMenu.Controls.Add(this.btnGuncelle);
            this.grpKontroluMenu.Controls.Add(this.btnSil);
            this.grpKontroluMenu.Controls.Add(this.btnDuzenle);
            this.grpKontroluMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpKontroluMenu.Location = new System.Drawing.Point(0, 489);
            this.grpKontroluMenu.Name = "grpKontroluMenu";
            this.grpKontroluMenu.Size = new System.Drawing.Size(1268, 70);
            this.grpKontroluMenu.TabIndex = 3;
            this.grpKontroluMenu.Text = "Menü";
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.dropDownButton1.DropDownControl = this.popupMenu1;
            this.dropDownButton1.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.add_32x321;
            this.dropDownButton1.Location = new System.Drawing.Point(12, 25);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(93, 40);
            this.dropDownButton1.TabIndex = 2;
            this.dropDownButton1.Text = "Ekle";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barAlisFatura),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSatisFatura),
            new DevExpress.XtraBars.LinkPersistInfo(this.barToptanSatisFaturasi, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barAlisIadeFaturasi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSatisİadeFaturasi, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barTahsilatFisi, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barOdemeFisi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1, true)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barAlisFatura
            // 
            this.barAlisFatura.Caption = "Alış Faturası";
            this.barAlisFatura.Id = 0;
            this.barAlisFatura.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barAlisFatura.ImageOptions.Image")));
            this.barAlisFatura.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A));
            this.barAlisFatura.Name = "barAlisFatura";
            this.barAlisFatura.ShortcutKeyDisplayString = "Ctrl + A";
            this.barAlisFatura.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.barAlisFatura.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barSatisFatura
            // 
            this.barSatisFatura.Caption = "Satış Faturası";
            this.barSatisFatura.Id = 1;
            this.barSatisFatura.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSatisFatura.ImageOptions.Image")));
            this.barSatisFatura.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.barSatisFatura.Name = "barSatisFatura";
            this.barSatisFatura.ShortcutKeyDisplayString = "Ctrl + S";
            this.barSatisFatura.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barToptanSatisFaturasi
            // 
            this.barToptanSatisFaturasi.Caption = "Toptan Satış Faturası";
            this.barToptanSatisFaturasi.Id = 2;
            this.barToptanSatisFaturasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barToptanSatisFaturasi.ImageOptions.Image")));
            this.barToptanSatisFaturasi.Name = "barToptanSatisFaturasi";
            this.barToptanSatisFaturasi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barAlisIadeFaturasi
            // 
            this.barAlisIadeFaturasi.Caption = "Alış İade Faturası";
            this.barAlisIadeFaturasi.Id = 3;
            this.barAlisIadeFaturasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barAlisIadeFaturasi.ImageOptions.Image")));
            this.barAlisIadeFaturasi.Name = "barAlisIadeFaturasi";
            this.barAlisIadeFaturasi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barSatisİadeFaturasi
            // 
            this.barSatisİadeFaturasi.Caption = "Satış İade Faturası";
            this.barSatisİadeFaturasi.Id = 4;
            this.barSatisİadeFaturasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSatisİadeFaturasi.ImageOptions.Image")));
            this.barSatisİadeFaturasi.Name = "barSatisİadeFaturasi";
            this.barSatisİadeFaturasi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barTahsilatFisi
            // 
            this.barTahsilatFisi.Caption = "Tahsilat Fişi";
            this.barTahsilatFisi.Id = 5;
            this.barTahsilatFisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barTahsilatFisi.ImageOptions.Image")));
            this.barTahsilatFisi.Name = "barTahsilatFisi";
            // 
            // barOdemeFisi
            // 
            this.barOdemeFisi.Caption = "Ödeme Fişi";
            this.barOdemeFisi.Id = 6;
            this.barOdemeFisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barOdemeFisi.ImageOptions.Image")));
            this.barOdemeFisi.Name = "barOdemeFisi";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Sayım ve Devir";
            this.barSubItem1.Id = 11;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barCariDevirFisi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStokDevirFisi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSayimEksigiFisi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSayimFazlasiFisi)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barCariDevirFisi
            // 
            this.barCariDevirFisi.Caption = "Cari Devir Fişi";
            this.barCariDevirFisi.Id = 7;
            this.barCariDevirFisi.Name = "barCariDevirFisi";
            this.barCariDevirFisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barStokDevirFisi
            // 
            this.barStokDevirFisi.Caption = "Stok Devir Fişi";
            this.barStokDevirFisi.Id = 10;
            this.barStokDevirFisi.Name = "barStokDevirFisi";
            this.barStokDevirFisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barSayimEksigiFisi
            // 
            this.barSayimEksigiFisi.Caption = "Sayım Eksiği Fişi";
            this.barSayimEksigiFisi.Id = 9;
            this.barSayimEksigiFisi.Name = "barSayimEksigiFisi";
            this.barSayimEksigiFisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barSayimFazlasiFisi
            // 
            this.barSayimFazlasiFisi.Caption = "Sayım Fazlası Fişi";
            this.barSayimFazlasiFisi.Id = 8;
            this.barSayimFazlasiFisi.Name = "barSayimFazlasiFisi";
            this.barSayimFazlasiFisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barAlisFatura,
            this.barSatisFatura,
            this.barToptanSatisFaturasi,
            this.barAlisIadeFaturasi,
            this.barSatisİadeFaturasi,
            this.barTahsilatFisi,
            this.barOdemeFisi,
            this.barCariDevirFisi,
            this.barSayimFazlasiFisi,
            this.barSayimEksigiFisi,
            this.barStokDevirFisi,
            this.barSubItem1});
            this.barManager1.MaxItemId = 12;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1268, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 559);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1268, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 559);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1268, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 559);
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.close_32x32;
            this.btnKapat.Location = new System.Drawing.Point(405, 25);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 40);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.updatetableofcontents_32x32;
            this.btnGuncelle.Location = new System.Drawing.Point(292, 25);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(107, 40);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.deletedatasource_32x32;
            this.btnSil.Location = new System.Drawing.Point(213, 25);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 40);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.editdatasource_32x32;
            this.btnDuzenle.Location = new System.Drawing.Point(111, 25);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(96, 40);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1268, 448);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAciklama,
            this.colFisKodu,
            this.colFisTuru,
            this.colCariTuru,
            this.colCariKodu,
            this.colCariAdi,
            this.colBelgeNo,
            this.colTarih,
            this.colPersonelKodu,
            this.colPersonelAdi,
            this.colIskontoOrani,
            this.colIskontoTutar,
            this.colToplamTutar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 0;
            // 
            // colFisKodu
            // 
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.OptionsColumn.AllowEdit = false;
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 1;
            // 
            // colFisTuru
            // 
            this.colFisTuru.FieldName = "FisTuru";
            this.colFisTuru.Name = "colFisTuru";
            this.colFisTuru.OptionsColumn.AllowEdit = false;
            this.colFisTuru.Visible = true;
            this.colFisTuru.VisibleIndex = 2;
            // 
            // colCariTuru
            // 
            this.colCariTuru.FieldName = "CariTuru";
            this.colCariTuru.Name = "colCariTuru";
            this.colCariTuru.OptionsColumn.AllowEdit = false;
            this.colCariTuru.Visible = true;
            this.colCariTuru.VisibleIndex = 3;
            // 
            // colCariKodu
            // 
            this.colCariKodu.FieldName = "CariKodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.OptionsColumn.AllowEdit = false;
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 4;
            // 
            // colCariAdi
            // 
            this.colCariAdi.FieldName = "CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.OptionsColumn.AllowEdit = false;
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 5;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.OptionsColumn.AllowEdit = false;
            this.colBelgeNo.Visible = true;
            this.colBelgeNo.VisibleIndex = 6;
            // 
            // colTarih
            // 
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 7;
            // 
            // colPersonelKodu
            // 
            this.colPersonelKodu.Caption = "Personel Kodu";
            this.colPersonelKodu.FieldName = "PersonelKodu";
            this.colPersonelKodu.Name = "colPersonelKodu";
            this.colPersonelKodu.OptionsColumn.AllowEdit = false;
            this.colPersonelKodu.Visible = true;
            this.colPersonelKodu.VisibleIndex = 8;
            // 
            // colPersonelAdi
            // 
            this.colPersonelAdi.Caption = "Personel Adı";
            this.colPersonelAdi.FieldName = "PersonelAdi";
            this.colPersonelAdi.Name = "colPersonelAdi";
            this.colPersonelAdi.OptionsColumn.AllowEdit = false;
            this.colPersonelAdi.Visible = true;
            this.colPersonelAdi.VisibleIndex = 9;
            // 
            // colIskontoOrani
            // 
            this.colIskontoOrani.FieldName = "IskontoOrani";
            this.colIskontoOrani.Name = "colIskontoOrani";
            this.colIskontoOrani.OptionsColumn.AllowEdit = false;
            this.colIskontoOrani.Visible = true;
            this.colIskontoOrani.VisibleIndex = 10;
            // 
            // colIskontoTutar
            // 
            this.colIskontoTutar.FieldName = "IskontoTutar";
            this.colIskontoTutar.Name = "colIskontoTutar";
            this.colIskontoTutar.OptionsColumn.AllowEdit = false;
            this.colIskontoTutar.Visible = true;
            this.colIskontoTutar.VisibleIndex = 11;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.FieldName = "ToplamTutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.OptionsColumn.AllowEdit = false;
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 12;
            // 
            // FrmFis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 559);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.grpKontroluMenu);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmFis";
            this.barManager1.SetPopupContextMenu(this, this.popupMenu1);
            this.Text = "Fiş ve Faturalar";
            this.Load += new System.EventHandler(this.FrmFis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpKontroluMenu)).EndInit();
            this.grpKontroluMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpKontroluMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colFisTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colCariTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBelgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barAlisFatura;
        private DevExpress.XtraBars.BarButtonItem barSatisFatura;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barToptanSatisFaturasi;
        private DevExpress.XtraBars.BarButtonItem barAlisIadeFaturasi;
        private DevExpress.XtraBars.BarButtonItem barSatisİadeFaturasi;
        private DevExpress.XtraBars.BarButtonItem barTahsilatFisi;
        private DevExpress.XtraBars.BarButtonItem barOdemeFisi;
        private DevExpress.XtraBars.BarButtonItem barCariDevirFisi;
        private DevExpress.XtraBars.BarButtonItem barSayimFazlasiFisi;
        private DevExpress.XtraBars.BarButtonItem barSayimEksigiFisi;
        private DevExpress.XtraBars.BarButtonItem barStokDevirFisi;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
    }
}