namespace YemekYemek.BackOffice.Personel
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpKontroluMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnStokHareketleri = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKopyala = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCalisiyor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnvani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTcKimlikNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIseGirisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCepTelefonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAylikMaas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelAvans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamSatis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrimTutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grpKontroluMenu)).BeginInit();
            this.grpKontroluMenu.SuspendLayout();
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
            this.lblBaslik.Size = new System.Drawing.Size(1177, 41);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Personel Kartları";
            // 
            // grpKontroluMenu
            // 
            this.grpKontroluMenu.Controls.Add(this.btnKapat);
            this.grpKontroluMenu.Controls.Add(this.btnStokHareketleri);
            this.grpKontroluMenu.Controls.Add(this.simpleButton1);
            this.grpKontroluMenu.Controls.Add(this.btnGuncelle);
            this.grpKontroluMenu.Controls.Add(this.btnKopyala);
            this.grpKontroluMenu.Controls.Add(this.btnSil);
            this.grpKontroluMenu.Controls.Add(this.btnDuzenle);
            this.grpKontroluMenu.Controls.Add(this.btnEkle);
            this.grpKontroluMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpKontroluMenu.Location = new System.Drawing.Point(0, 555);
            this.grpKontroluMenu.Name = "grpKontroluMenu";
            this.grpKontroluMenu.Size = new System.Drawing.Size(1177, 70);
            this.grpKontroluMenu.TabIndex = 3;
            this.grpKontroluMenu.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.close_32x32;
            this.btnKapat.Location = new System.Drawing.Point(842, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 40);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnStokHareketleri
            // 
            this.btnStokHareketleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStokHareketleri.ImageOptions.Image")));
            this.btnStokHareketleri.Location = new System.Drawing.Point(667, 23);
            this.btnStokHareketleri.Name = "btnStokHareketleri";
            this.btnStokHareketleri.Size = new System.Drawing.Size(169, 40);
            this.btnStokHareketleri.TabIndex = 1;
            this.btnStokHareketleri.Text = "Personel  Hareketleri";
            this.btnStokHareketleri.Click += new System.EventHandler(this.btnStokHareketleri_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.updatetableofcontents_32x32;
            this.btnGuncelle.Location = new System.Drawing.Point(379, 23);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(107, 40);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.copy_32x32;
            this.btnKopyala.Location = new System.Drawing.Point(276, 23);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(97, 40);
            this.btnKopyala.TabIndex = 1;
            this.btnKopyala.Text = "Kopyala";
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
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1177, 514);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCalisiyor,
            this.colUnvani,
            this.colPersonelKodu,
            this.colPersonelSoyad,
            this.colPersonelAdi,
            this.colTcKimlikNo,
            this.colIseGirisTarihi,
            this.colCepTelefonu,
            this.colPrimOrani,
            this.colAylikMaas,
            this.colPersonelAvans,
            this.colToplamSatis,
            this.colPrimTutari});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCalisiyor
            // 
            this.colCalisiyor.Caption = "Çalışma Durumu";
            this.colCalisiyor.FieldName = "Calisiyor";
            this.colCalisiyor.Name = "colCalisiyor";
            this.colCalisiyor.OptionsColumn.AllowEdit = false;
            this.colCalisiyor.Visible = true;
            this.colCalisiyor.VisibleIndex = 0;
            // 
            // colUnvani
            // 
            this.colUnvani.Caption = "Ünvanı";
            this.colUnvani.FieldName = "Unvani";
            this.colUnvani.Name = "colUnvani";
            this.colUnvani.OptionsColumn.AllowEdit = false;
            this.colUnvani.Visible = true;
            this.colUnvani.VisibleIndex = 1;
            // 
            // colPersonelKodu
            // 
            this.colPersonelKodu.Caption = "Personel Kodu";
            this.colPersonelKodu.FieldName = "PersonelKodu";
            this.colPersonelKodu.Name = "colPersonelKodu";
            this.colPersonelKodu.OptionsColumn.AllowEdit = false;
            this.colPersonelKodu.Visible = true;
            this.colPersonelKodu.VisibleIndex = 2;
            // 
            // colPersonelSoyad
            // 
            this.colPersonelSoyad.Caption = "Soyad";
            this.colPersonelSoyad.FieldName = "PersonelSoyAdi";
            this.colPersonelSoyad.Name = "colPersonelSoyad";
            this.colPersonelSoyad.OptionsColumn.AllowEdit = false;
            this.colPersonelSoyad.Visible = true;
            this.colPersonelSoyad.VisibleIndex = 4;
            // 
            // colPersonelAdi
            // 
            this.colPersonelAdi.Caption = "Adı";
            this.colPersonelAdi.FieldName = "PersonelAdi";
            this.colPersonelAdi.Name = "colPersonelAdi";
            this.colPersonelAdi.OptionsColumn.AllowEdit = false;
            this.colPersonelAdi.Visible = true;
            this.colPersonelAdi.VisibleIndex = 3;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.Caption = "T.C Kimlik";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.VisibleIndex = 5;
            // 
            // colIseGirisTarihi
            // 
            this.colIseGirisTarihi.Caption = "İşe Giriş Tarihi";
            this.colIseGirisTarihi.FieldName = "IseGirisTarihi";
            this.colIseGirisTarihi.Name = "colIseGirisTarihi";
            this.colIseGirisTarihi.OptionsColumn.AllowEdit = false;
            this.colIseGirisTarihi.Visible = true;
            this.colIseGirisTarihi.VisibleIndex = 6;
            // 
            // colCepTelefonu
            // 
            this.colCepTelefonu.Caption = "Cep Telefon";
            this.colCepTelefonu.FieldName = "CepTelefonu";
            this.colCepTelefonu.Name = "colCepTelefonu";
            this.colCepTelefonu.OptionsColumn.AllowEdit = false;
            this.colCepTelefonu.Visible = true;
            this.colCepTelefonu.VisibleIndex = 7;
            // 
            // colPrimOrani
            // 
            this.colPrimOrani.Caption = "Prim Oranı";
            this.colPrimOrani.DisplayFormat.FormatString = "\'%\'0";
            this.colPrimOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrimOrani.FieldName = "PrimOrani";
            this.colPrimOrani.Name = "colPrimOrani";
            this.colPrimOrani.OptionsColumn.AllowEdit = false;
            this.colPrimOrani.Visible = true;
            this.colPrimOrani.VisibleIndex = 10;
            // 
            // colAylikMaas
            // 
            this.colAylikMaas.Caption = "Aylık Maaş";
            this.colAylikMaas.DisplayFormat.FormatString = "C2";
            this.colAylikMaas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAylikMaas.FieldName = "AylikMaas";
            this.colAylikMaas.Name = "colAylikMaas";
            this.colAylikMaas.OptionsColumn.AllowEdit = false;
            this.colAylikMaas.Visible = true;
            this.colAylikMaas.VisibleIndex = 8;
            // 
            // colPersonelAvans
            // 
            this.colPersonelAvans.Caption = "Avans";
            this.colPersonelAvans.FieldName = "PersonelAvans";
            this.colPersonelAvans.Name = "colPersonelAvans";
            this.colPersonelAvans.OptionsColumn.AllowEdit = false;
            this.colPersonelAvans.Visible = true;
            this.colPersonelAvans.VisibleIndex = 9;
            // 
            // colToplamSatis
            // 
            this.colToplamSatis.Caption = "Toplam Satış";
            this.colToplamSatis.DisplayFormat.FormatString = "C2";
            this.colToplamSatis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplamSatis.FieldName = "ToplamSatis";
            this.colToplamSatis.Name = "colToplamSatis";
            this.colToplamSatis.OptionsColumn.AllowEdit = false;
            this.colToplamSatis.Visible = true;
            this.colToplamSatis.VisibleIndex = 11;
            // 
            // colPrimTutari
            // 
            this.colPrimTutari.Caption = "Prim Tutarı";
            this.colPrimTutari.DisplayFormat.FormatString = "C2";
            this.colPrimTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrimTutari.FieldName = "PrimTutari";
            this.colPrimTutari.Name = "colPrimTutari";
            this.colPrimTutari.OptionsColumn.AllowEdit = false;
            this.colPrimTutari.Visible = true;
            this.colPrimTutari.VisibleIndex = 12;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.updatetableofcontents_32x32;
            this.simpleButton1.Location = new System.Drawing.Point(492, 23);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(107, 40);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Güncelle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 625);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.grpKontroluMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmPersonel";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpKontroluMenu)).EndInit();
            this.grpKontroluMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpKontroluMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnStokHareketleri;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnKopyala;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCalisiyor;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvani;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTcKimlikNo;
        private DevExpress.XtraGrid.Columns.GridColumn colIseGirisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colCepTelefonu;
        private DevExpress.XtraGrid.Columns.GridColumn colPrimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colAylikMaas;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelAvans;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamSatis;
        private DevExpress.XtraGrid.Columns.GridColumn colPrimTutari;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelSoyad;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}