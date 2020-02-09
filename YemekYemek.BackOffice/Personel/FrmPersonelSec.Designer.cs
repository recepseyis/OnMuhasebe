namespace YemekYemek.BackOffice.Personel
{
    partial class FrmPersonelSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelSec));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpKontroluMenu = new DevExpress.XtraEditors.GroupControl();
            this.lblUyari = new DevExpress.XtraEditors.LabelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.grpKontroluMenu)).BeginInit();
            this.grpKontroluMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslik.Appearance.Image")));
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
            this.lblBaslik.Size = new System.Drawing.Size(931, 41);
            this.lblBaslik.TabIndex = 4;
            this.lblBaslik.Text = "Personel Seçim Ekranı";
            // 
            // grpKontroluMenu
            // 
            this.grpKontroluMenu.Controls.Add(this.lblUyari);
            this.grpKontroluMenu.Controls.Add(this.btnKapat);
            this.grpKontroluMenu.Controls.Add(this.btnSec);
            this.grpKontroluMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpKontroluMenu.Location = new System.Drawing.Point(0, 244);
            this.grpKontroluMenu.Name = "grpKontroluMenu";
            this.grpKontroluMenu.Size = new System.Drawing.Size(931, 70);
            this.grpKontroluMenu.TabIndex = 5;
            this.grpKontroluMenu.Text = "Menü";
            // 
            // lblUyari
            // 
            this.lblUyari.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyari.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("lblUyari.Appearance.Image")));
            this.lblUyari.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUyari.Appearance.Options.UseFont = true;
            this.lblUyari.Appearance.Options.UseImage = true;
            this.lblUyari.Appearance.Options.UseImageAlign = true;
            this.lblUyari.Appearance.Options.UseTextOptions = true;
            this.lblUyari.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblUyari.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUyari.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblUyari.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUyari.Location = new System.Drawing.Point(2, 20);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(328, 48);
            this.lblUyari.TabIndex = 3;
            this.lblUyari.Text = "Çoklu Seçim İçin CTRL Tuşuna Basılı Tutun ve Seçin";
            this.lblUyari.Visible = false;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.close_32x32;
            this.btnKapat.Location = new System.Drawing.Point(844, 27);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 40);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSec
            // 
            this.btnSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSec.ImageOptions.Image")));
            this.btnSec.Location = new System.Drawing.Point(763, 27);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(75, 40);
            this.btnSec.TabIndex = 1;
            this.btnSec.Text = "Seç";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(931, 203);
            this.gridControl1.TabIndex = 6;
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
            this.colUnvani.VisibleIndex = 2;
            // 
            // colPersonelKodu
            // 
            this.colPersonelKodu.Caption = "Personel Kodu";
            this.colPersonelKodu.FieldName = "PersonelKodu";
            this.colPersonelKodu.Name = "colPersonelKodu";
            this.colPersonelKodu.OptionsColumn.AllowEdit = false;
            this.colPersonelKodu.Visible = true;
            this.colPersonelKodu.VisibleIndex = 1;
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
            // 
            // colAylikMaas
            // 
            this.colAylikMaas.Caption = "Aylık Maaş";
            this.colAylikMaas.DisplayFormat.FormatString = "C2";
            this.colAylikMaas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAylikMaas.FieldName = "AylikMaas";
            this.colAylikMaas.Name = "colAylikMaas";
            this.colAylikMaas.OptionsColumn.AllowEdit = false;
            // 
            // colPersonelAvans
            // 
            this.colPersonelAvans.Caption = "Avans";
            this.colPersonelAvans.FieldName = "PersonelAvans";
            this.colPersonelAvans.Name = "colPersonelAvans";
            this.colPersonelAvans.OptionsColumn.AllowEdit = false;
            // 
            // colToplamSatis
            // 
            this.colToplamSatis.Caption = "Toplam Satış";
            this.colToplamSatis.DisplayFormat.FormatString = "C2";
            this.colToplamSatis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplamSatis.FieldName = "ToplamSatis";
            this.colToplamSatis.Name = "colToplamSatis";
            this.colToplamSatis.OptionsColumn.AllowEdit = false;
            // 
            // colPrimTutari
            // 
            this.colPrimTutari.Caption = "Prim Tutarı";
            this.colPrimTutari.DisplayFormat.FormatString = "C2";
            this.colPrimTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrimTutari.FieldName = "PrimTutari";
            this.colPrimTutari.Name = "colPrimTutari";
            this.colPrimTutari.OptionsColumn.AllowEdit = false;
            // 
            // FrmPersonelSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 314);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.grpKontroluMenu);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPersonelSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Seç";
            this.Load += new System.EventHandler(this.FrmPersonelSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpKontroluMenu)).EndInit();
            this.grpKontroluMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpKontroluMenu;
        private DevExpress.XtraEditors.LabelControl lblUyari;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCalisiyor;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvani;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTcKimlikNo;
        private DevExpress.XtraGrid.Columns.GridColumn colIseGirisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colCepTelefonu;
        private DevExpress.XtraGrid.Columns.GridColumn colPrimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colAylikMaas;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelAvans;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamSatis;
        private DevExpress.XtraGrid.Columns.GridColumn colPrimTutari;
    }
}