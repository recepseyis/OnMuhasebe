namespace YemekYemek.BackOffice.StokHareketleri
{
    partial class FrmStokHareketleri
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions5 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions6 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions7 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions8 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpKontroluMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.gridConStokHareket = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoSeriNO = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colBirimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoBirimFiyatSec = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colIndirimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoDepoSec = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoSil = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnara = new DevExpress.XtraEditors.SimpleButton();
            this.tarih2 = new DevExpress.XtraEditors.DateEdit();
            this.tarih1 = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grpKontroluMenu)).BeginInit();
            this.grpKontroluMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConStokHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSeriNO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBirimFiyatSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoDepoSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarih2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih1.Properties)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(1194, 41);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Stok Hareketleri";
            // 
            // grpKontroluMenu
            // 
            this.grpKontroluMenu.Controls.Add(this.btnKapat);
            this.grpKontroluMenu.Controls.Add(this.simpleButton1);
            this.grpKontroluMenu.Controls.Add(this.btnGuncelle);
            this.grpKontroluMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpKontroluMenu.Location = new System.Drawing.Point(0, 393);
            this.grpKontroluMenu.Name = "grpKontroluMenu";
            this.grpKontroluMenu.Size = new System.Drawing.Size(1194, 70);
            this.grpKontroluMenu.TabIndex = 3;
            this.grpKontroluMenu.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.close_32x32;
            this.btnKapat.Location = new System.Drawing.Point(237, 25);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 40);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.switchrowcolumn_32x32;
            this.simpleButton1.Location = new System.Drawing.Point(12, 25);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(107, 40);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Detaylar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.updatetableofcontents_32x32;
            this.btnGuncelle.Location = new System.Drawing.Point(124, 25);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(107, 40);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // gridConStokHareket
            // 
            this.gridConStokHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConStokHareket.Location = new System.Drawing.Point(0, 41);
            this.gridConStokHareket.MainView = this.gridView1;
            this.gridConStokHareket.Name = "gridConStokHareket";
            this.gridConStokHareket.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoSil,
            this.repoBirimFiyatSec,
            this.repoDepoSec,
            this.repoSeriNO});
            this.gridConStokHareket.Size = new System.Drawing.Size(1194, 268);
            this.gridConStokHareket.TabIndex = 4;
            this.gridConStokHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridConStokHareket.DoubleClick += new System.EventHandler(this.gridConStokHareket_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStokKodu,
            this.colStokAdi,
            this.colBarkod,
            this.colMiktari,
            this.colSeriNo,
            this.colBirimFiyati,
            this.colIndirimOrani,
            this.colDepoKodu,
            this.colDepoAdi,
            this.colToplamTutar,
            this.colIndirimTutar,
            this.colKdv,
            this.colToplamKdv,
            this.colHareket,
            this.colTarih,
            this.colBirimi,
            this.colFisKodu});
            this.gridView1.GridControl = this.gridConStokHareket;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Stok Kodu";
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 3;
            this.colStokKodu.Width = 58;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Ürün Adı";
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 4;
            this.colStokAdi.Width = 144;
            // 
            // colBarkod
            // 
            this.colBarkod.Caption = "Barkod";
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 13;
            this.colBarkod.Width = 55;
            // 
            // colMiktari
            // 
            this.colMiktari.Caption = "Miktar";
            this.colMiktari.DisplayFormat.FormatString = "N3";
            this.colMiktari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMiktari.FieldName = "Miktari";
            this.colMiktari.Name = "colMiktari";
            this.colMiktari.OptionsColumn.AllowEdit = false;
            this.colMiktari.Visible = true;
            this.colMiktari.VisibleIndex = 5;
            this.colMiktari.Width = 61;
            // 
            // colSeriNo
            // 
            this.colSeriNo.Caption = "Seri No";
            this.colSeriNo.ColumnEdit = this.repoSeriNO;
            this.colSeriNo.FieldName = "SeriNo";
            this.colSeriNo.Name = "colSeriNo";
            this.colSeriNo.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colSeriNo.Visible = true;
            this.colSeriNo.VisibleIndex = 14;
            this.colSeriNo.Width = 38;
            // 
            // repoSeriNO
            // 
            this.repoSeriNO.AutoHeight = false;
            editorButtonImageOptions5.Image = global::YemekYemek.BackOffice.Properties.Resources.number_16x16;
            this.repoSeriNO.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions5, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.repoSeriNO.Name = "repoSeriNO";
            this.repoSeriNO.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repoSeriNO.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repoSeriNO_ButtonClick_1);
            // 
            // colBirimFiyati
            // 
            this.colBirimFiyati.Caption = "Birim Fiyat";
            this.colBirimFiyati.ColumnEdit = this.repoBirimFiyatSec;
            this.colBirimFiyati.DisplayFormat.FormatString = "C2";
            this.colBirimFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBirimFiyati.FieldName = "BirimFiyati";
            this.colBirimFiyati.Name = "colBirimFiyati";
            this.colBirimFiyati.OptionsColumn.AllowEdit = false;
            this.colBirimFiyati.Visible = true;
            this.colBirimFiyati.VisibleIndex = 7;
            this.colBirimFiyati.Width = 69;
            // 
            // repoBirimFiyatSec
            // 
            this.repoBirimFiyatSec.AutoHeight = false;
            editorButtonImageOptions6.Image = global::YemekYemek.BackOffice.Properties.Resources.selectdata_16x16;
            this.repoBirimFiyatSec.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions6, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.repoBirimFiyatSec.Name = "repoBirimFiyatSec";
            this.repoBirimFiyatSec.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colIndirimOrani
            // 
            this.colIndirimOrani.Caption = "İnd Oran";
            this.colIndirimOrani.DisplayFormat.FormatString = "\'%\'0";
            this.colIndirimOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndirimOrani.FieldName = "IndirimOrani";
            this.colIndirimOrani.Name = "colIndirimOrani";
            this.colIndirimOrani.OptionsColumn.AllowEdit = false;
            this.colIndirimOrani.Visible = true;
            this.colIndirimOrani.VisibleIndex = 10;
            this.colIndirimOrani.Width = 56;
            // 
            // colDepoKodu
            // 
            this.colDepoKodu.Caption = "Depo Kodu";
            this.colDepoKodu.FieldName = "DepoKodu";
            this.colDepoKodu.Name = "colDepoKodu";
            this.colDepoKodu.OptionsColumn.AllowEdit = false;
            this.colDepoKodu.Visible = true;
            this.colDepoKodu.VisibleIndex = 15;
            this.colDepoKodu.Width = 66;
            // 
            // colDepoAdi
            // 
            this.colDepoAdi.Caption = "Depo Adı";
            this.colDepoAdi.ColumnEdit = this.repoDepoSec;
            this.colDepoAdi.FieldName = "DepoAdi";
            this.colDepoAdi.Name = "colDepoAdi";
            this.colDepoAdi.OptionsColumn.AllowEdit = false;
            this.colDepoAdi.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colDepoAdi.Visible = true;
            this.colDepoAdi.VisibleIndex = 16;
            this.colDepoAdi.Width = 133;
            // 
            // repoDepoSec
            // 
            this.repoDepoSec.AutoHeight = false;
            editorButtonImageOptions7.Image = global::YemekYemek.BackOffice.Properties.Resources.boreport2_16x16;
            this.repoDepoSec.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions7, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.repoDepoSec.Name = "repoDepoSec";
            this.repoDepoSec.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Caption = "Toplam Tutar";
            this.colToplamTutar.DisplayFormat.FormatString = "C2";
            this.colToplamTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplamTutar.FieldName = "colToplamTutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.OptionsColumn.AllowEdit = false;
            this.colToplamTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colToplamTutar", "SUM={0:0.##}")});
            this.colToplamTutar.UnboundExpression = "[BirimFiyati] * [Miktari] - [BirimFiyati] * [Miktari] / 100 * [IndirimOrani]";
            this.colToplamTutar.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 12;
            this.colToplamTutar.Width = 111;
            // 
            // colIndirimTutar
            // 
            this.colIndirimTutar.Caption = "İndirim Tutar";
            this.colIndirimTutar.DisplayFormat.FormatString = "C2";
            this.colIndirimTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndirimTutar.FieldName = "colIndirimTutar";
            this.colIndirimTutar.Name = "colIndirimTutar";
            this.colIndirimTutar.OptionsColumn.AllowEdit = false;
            this.colIndirimTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colIndirimTutar", "SUM={0:0.##}")});
            this.colIndirimTutar.UnboundExpression = "[colToplamTutar] / 100 * [IndirimOrani]";
            this.colIndirimTutar.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colIndirimTutar.Visible = true;
            this.colIndirimTutar.VisibleIndex = 11;
            this.colIndirimTutar.Width = 78;
            // 
            // colKdv
            // 
            this.colKdv.Caption = "Kdv";
            this.colKdv.DisplayFormat.FormatString = "\'%\'0";
            this.colKdv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKdv.FieldName = "Kdv";
            this.colKdv.Name = "colKdv";
            this.colKdv.OptionsColumn.AllowEdit = false;
            this.colKdv.Visible = true;
            this.colKdv.VisibleIndex = 8;
            this.colKdv.Width = 36;
            // 
            // colToplamKdv
            // 
            this.colToplamKdv.Caption = "Toplam Kdv";
            this.colToplamKdv.DisplayFormat.FormatString = "C2";
            this.colToplamKdv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplamKdv.FieldName = "colToplamKdv";
            this.colToplamKdv.Name = "colToplamKdv";
            this.colToplamKdv.OptionsColumn.AllowEdit = false;
            this.colToplamKdv.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colToplamKdv", "SUM={0:0.##}")});
            this.colToplamKdv.UnboundExpression = "[colToplamTutar] / 100 * [Kdv]";
            this.colToplamKdv.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colToplamKdv.Visible = true;
            this.colToplamKdv.VisibleIndex = 9;
            this.colToplamKdv.Width = 86;
            // 
            // colHareket
            // 
            this.colHareket.Caption = "Hareket";
            this.colHareket.FieldName = "Hareket";
            this.colHareket.Name = "colHareket";
            this.colHareket.OptionsColumn.AllowEdit = false;
            this.colHareket.Visible = true;
            this.colHareket.VisibleIndex = 2;
            this.colHareket.Width = 58;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 0;
            this.colTarih.Width = 59;
            // 
            // colBirimi
            // 
            this.colBirimi.Caption = "Birimi";
            this.colBirimi.FieldName = "Birimi";
            this.colBirimi.Name = "colBirimi";
            this.colBirimi.OptionsColumn.AllowEdit = false;
            this.colBirimi.Visible = true;
            this.colBirimi.VisibleIndex = 6;
            this.colBirimi.Width = 68;
            // 
            // colFisKodu
            // 
            this.colFisKodu.Caption = "Fiş Kodu";
            this.colFisKodu.FieldName = "Fiskodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 1;
            // 
            // repoSil
            // 
            this.repoSil.AutoHeight = false;
            editorButtonImageOptions8.Image = global::YemekYemek.BackOffice.Properties.Resources.removepivotfield_16x16;
            this.repoSil.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions8, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.repoSil.Name = "repoSil";
            this.repoSil.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 309);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1194, 84);
            this.panelControl1.TabIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.btnara);
            this.groupControl1.Controls.Add(this.tarih2);
            this.groupControl1.Controls.Add(this.tarih1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(292, 80);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tarihler Arası";
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(10, 52);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(100, 23);
            this.btnara.TabIndex = 2;
            this.btnara.Text = "Tarihler Arası";
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // tarih2
            // 
            this.tarih2.EditValue = null;
            this.tarih2.Location = new System.Drawing.Point(122, 23);
            this.tarih2.Name = "tarih2";
            this.tarih2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tarih2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tarih2.Size = new System.Drawing.Size(100, 20);
            this.tarih2.TabIndex = 1;
            // 
            // tarih1
            // 
            this.tarih1.EditValue = new System.DateTime(2019, 5, 10, 23, 15, 24, 64);
            this.tarih1.Location = new System.Drawing.Point(10, 23);
            this.tarih1.Name = "tarih1";
            this.tarih1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tarih1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tarih1.Size = new System.Drawing.Size(100, 20);
            this.tarih1.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(122, 52);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(100, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Bugün";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // FrmStokHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 463);
            this.Controls.Add(this.gridConStokHareket);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.grpKontroluMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmStokHareketleri";
            this.Text = "FrmStokHareketleri";
            this.Load += new System.EventHandler(this.FrmStokHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpKontroluMenu)).EndInit();
            this.grpKontroluMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridConStokHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSeriNO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBirimFiyatSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoDepoSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tarih2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpKontroluMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridConStokHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoSeriNO;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoBirimFiyatSec;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoDepoSec;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoSil;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit tarih2;
        private DevExpress.XtraEditors.DateEdit tarih1;
        private DevExpress.XtraEditors.SimpleButton btnara;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}