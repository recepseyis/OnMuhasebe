namespace YemekYemek.BackOffice.Stok
{
    partial class FrmStokSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokSec));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpKontroluMenu = new DevExpress.XtraEditors.GroupControl();
            this.lblUyari = new DevExpress.XtraEditors.LabelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.gridConStoklar = new DevExpress.XtraGrid.GridControl();
            this.gridStoklar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokGrubu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAltGrubu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModeli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpKontroluMenu)).BeginInit();
            this.grpKontroluMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConStoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStoklar)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(1008, 41);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Stok Seçim Ekranı";
            // 
            // grpKontroluMenu
            // 
            this.grpKontroluMenu.Controls.Add(this.lblUyari);
            this.grpKontroluMenu.Controls.Add(this.btnKapat);
            this.grpKontroluMenu.Controls.Add(this.btnSec);
            this.grpKontroluMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpKontroluMenu.Location = new System.Drawing.Point(0, 209);
            this.grpKontroluMenu.Name = "grpKontroluMenu";
            this.grpKontroluMenu.Size = new System.Drawing.Size(1008, 70);
            this.grpKontroluMenu.TabIndex = 3;
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
            this.btnKapat.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.close_32x32;
            this.btnKapat.Location = new System.Drawing.Point(778, 27);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 40);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSec
            // 
            this.btnSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSec.ImageOptions.Image")));
            this.btnSec.Location = new System.Drawing.Point(697, 27);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(75, 40);
            this.btnSec.TabIndex = 1;
            this.btnSec.Text = "Seç";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // gridConStoklar
            // 
            this.gridConStoklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConStoklar.Location = new System.Drawing.Point(0, 41);
            this.gridConStoklar.MainView = this.gridStoklar;
            this.gridConStoklar.Name = "gridConStoklar";
            this.gridConStoklar.Size = new System.Drawing.Size(1008, 168);
            this.gridConStoklar.TabIndex = 4;
            this.gridConStoklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridStoklar});
            // 
            // gridStoklar
            // 
            this.gridStoklar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDurumu,
            this.colStokKodu,
            this.colStokAdı,
            this.colBarkod,
            this.colBirimi,
            this.colStokGrubu,
            this.colStokAltGrubu,
            this.colMarka,
            this.colModeli,
            this.colSatisKdv,
            this.colAlisFiyati,
            this.colSatisFiyati,
            this.gridColumn3});
            this.gridStoklar.GridControl = this.gridConStoklar;
            this.gridStoklar.Name = "gridStoklar";
            this.gridStoklar.OptionsView.ShowAutoFilterRow = true;
            this.gridStoklar.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Width = 41;
            // 
            // colDurumu
            // 
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.OptionsColumn.AllowEdit = false;
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 0;
            this.colDurumu.Width = 59;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Stok Kodu";
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 1;
            this.colStokKodu.Width = 94;
            // 
            // colStokAdı
            // 
            this.colStokAdı.Caption = "Stok Adı";
            this.colStokAdı.FieldName = "StokAdi";
            this.colStokAdı.Name = "colStokAdı";
            this.colStokAdı.OptionsColumn.AllowEdit = false;
            this.colStokAdı.Visible = true;
            this.colStokAdı.VisibleIndex = 2;
            this.colStokAdı.Width = 129;
            // 
            // colBarkod
            // 
            this.colBarkod.Caption = "Barkod";
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 3;
            this.colBarkod.Width = 90;
            // 
            // colBirimi
            // 
            this.colBirimi.Caption = "Birimi";
            this.colBirimi.FieldName = "Birimi";
            this.colBirimi.Name = "colBirimi";
            this.colBirimi.OptionsColumn.AllowEdit = false;
            this.colBirimi.Visible = true;
            this.colBirimi.VisibleIndex = 4;
            this.colBirimi.Width = 90;
            // 
            // colStokGrubu
            // 
            this.colStokGrubu.Caption = "Stok Grubu";
            this.colStokGrubu.FieldName = "StokGrubu";
            this.colStokGrubu.Name = "colStokGrubu";
            this.colStokGrubu.OptionsColumn.AllowEdit = false;
            this.colStokGrubu.Visible = true;
            this.colStokGrubu.VisibleIndex = 5;
            this.colStokGrubu.Width = 108;
            // 
            // colStokAltGrubu
            // 
            this.colStokAltGrubu.Caption = "Stok Alt Grup";
            this.colStokAltGrubu.FieldName = "StokAltGrubu";
            this.colStokAltGrubu.Name = "colStokAltGrubu";
            this.colStokAltGrubu.OptionsColumn.AllowEdit = false;
            this.colStokAltGrubu.Visible = true;
            this.colStokAltGrubu.VisibleIndex = 6;
            this.colStokAltGrubu.Width = 87;
            // 
            // colMarka
            // 
            this.colMarka.FieldName = "Marka";
            this.colMarka.Name = "colMarka";
            this.colMarka.OptionsColumn.AllowEdit = false;
            this.colMarka.Width = 87;
            // 
            // colModeli
            // 
            this.colModeli.FieldName = "Modeli";
            this.colModeli.Name = "colModeli";
            this.colModeli.OptionsColumn.AllowEdit = false;
            this.colModeli.Width = 87;
            // 
            // colSatisKdv
            // 
            this.colSatisKdv.Caption = "Satiş Kdv";
            this.colSatisKdv.FieldName = "SatisKdv";
            this.colSatisKdv.Name = "colSatisKdv";
            this.colSatisKdv.OptionsColumn.AllowEdit = false;
            this.colSatisKdv.Visible = true;
            this.colSatisKdv.VisibleIndex = 7;
            this.colSatisKdv.Width = 87;
            // 
            // colAlisFiyati
            // 
            this.colAlisFiyati.Caption = "Alış Fiyatı";
            this.colAlisFiyati.FieldName = "AlisFiyati";
            this.colAlisFiyati.Name = "colAlisFiyati";
            this.colAlisFiyati.OptionsColumn.AllowEdit = false;
            this.colAlisFiyati.Visible = true;
            this.colAlisFiyati.VisibleIndex = 8;
            this.colAlisFiyati.Width = 87;
            // 
            // colSatisFiyati
            // 
            this.colSatisFiyati.Caption = "Satış Fiyatı";
            this.colSatisFiyati.FieldName = "SatisFiyati";
            this.colSatisFiyati.Name = "colSatisFiyati";
            this.colSatisFiyati.OptionsColumn.AllowEdit = false;
            this.colSatisFiyati.Visible = true;
            this.colSatisFiyati.VisibleIndex = 9;
            this.colSatisFiyati.Width = 113;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mevcut Stok";
            this.gridColumn3.FieldName = "MevcutStok";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 10;
            // 
            // FrmStokSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 279);
            this.ControlBox = false;
            this.Controls.Add(this.gridConStoklar);
            this.Controls.Add(this.grpKontroluMenu);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStokSec";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Seç";
            this.Load += new System.EventHandler(this.FrmStokSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpKontroluMenu)).EndInit();
            this.grpKontroluMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridConStoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStoklar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpKontroluMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private DevExpress.XtraGrid.GridControl gridConStoklar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridStoklar;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdı;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokGrubu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAltGrubu;
        private DevExpress.XtraGrid.Columns.GridColumn colMarka;
        private DevExpress.XtraGrid.Columns.GridColumn colModeli;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl lblUyari;
    }
}