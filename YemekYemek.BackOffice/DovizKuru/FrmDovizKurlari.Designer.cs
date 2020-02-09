namespace YemekYemek.BackOffice.DovizKuru
{
    partial class FrmDovizKurlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDovizKurlari));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpKontroluMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSembol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colForexBuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colForexSell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankNoteBuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankNoteSell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblUyari = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpKontroluMenu)).BeginInit();
            this.grpKontroluMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Image = global::YemekYemek.BackOffice.Properties.Resources.currency_32x321;
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
            this.lblBaslik.Size = new System.Drawing.Size(550, 41);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Döviz Kurları";
            // 
            // grpKontroluMenu
            // 
            this.grpKontroluMenu.Controls.Add(this.lblUyari);
            this.grpKontroluMenu.Controls.Add(this.btnKapat);
            this.grpKontroluMenu.Controls.Add(this.btnKaydet);
            this.grpKontroluMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpKontroluMenu.Location = new System.Drawing.Point(0, 288);
            this.grpKontroluMenu.Name = "grpKontroluMenu";
            this.grpKontroluMenu.Size = new System.Drawing.Size(550, 70);
            this.grpKontroluMenu.TabIndex = 4;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.close_32x32;
            this.btnKapat.Location = new System.Drawing.Point(461, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 40);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.Image = global::YemekYemek.BackOffice.Properties.Resources.refresh_32x32;
            this.btnKaydet.Location = new System.Drawing.Point(360, 23);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(95, 40);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Güncelle";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(550, 247);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsim,
            this.colSembol,
            this.colForexBuy,
            this.colForexSell,
            this.colBankNoteBuy,
            this.colBankNoteSell});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIsim
            // 
            this.colIsim.Caption = "Döviz";
            this.colIsim.FieldName = "Isim";
            this.colIsim.Name = "colIsim";
            this.colIsim.OptionsColumn.AllowEdit = false;
            this.colIsim.Visible = true;
            this.colIsim.VisibleIndex = 0;
            this.colIsim.Width = 99;
            // 
            // colSembol
            // 
            this.colSembol.Caption = "Sembol";
            this.colSembol.FieldName = "CurrencyCode";
            this.colSembol.Name = "colSembol";
            this.colSembol.OptionsColumn.AllowEdit = false;
            this.colSembol.Visible = true;
            this.colSembol.VisibleIndex = 1;
            this.colSembol.Width = 59;
            // 
            // colForexBuy
            // 
            this.colForexBuy.Caption = "F - Alış";
            this.colForexBuy.DisplayFormat.FormatString = "C2";
            this.colForexBuy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colForexBuy.FieldName = "ForexBuying";
            this.colForexBuy.Name = "colForexBuy";
            this.colForexBuy.OptionsColumn.AllowEdit = false;
            this.colForexBuy.Visible = true;
            this.colForexBuy.VisibleIndex = 2;
            this.colForexBuy.Width = 96;
            // 
            // colForexSell
            // 
            this.colForexSell.Caption = "F - Satış";
            this.colForexSell.DisplayFormat.FormatString = "C2";
            this.colForexSell.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colForexSell.FieldName = "ForexSelling";
            this.colForexSell.Name = "colForexSell";
            this.colForexSell.OptionsColumn.AllowEdit = false;
            this.colForexSell.Visible = true;
            this.colForexSell.VisibleIndex = 3;
            this.colForexSell.Width = 67;
            // 
            // colBankNoteBuy
            // 
            this.colBankNoteBuy.Caption = "B - Alış";
            this.colBankNoteBuy.DisplayFormat.FormatString = "C2";
            this.colBankNoteBuy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBankNoteBuy.FieldName = "BanknoteBuying";
            this.colBankNoteBuy.Name = "colBankNoteBuy";
            this.colBankNoteBuy.OptionsColumn.AllowEdit = false;
            this.colBankNoteBuy.Visible = true;
            this.colBankNoteBuy.VisibleIndex = 4;
            this.colBankNoteBuy.Width = 43;
            // 
            // colBankNoteSell
            // 
            this.colBankNoteSell.Caption = "B - Satış";
            this.colBankNoteSell.DisplayFormat.FormatString = "C2";
            this.colBankNoteSell.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBankNoteSell.FieldName = "BanknoteSelling";
            this.colBankNoteSell.Name = "colBankNoteSell";
            this.colBankNoteSell.OptionsColumn.AllowEdit = false;
            this.colBankNoteSell.Visible = true;
            this.colBankNoteSell.VisibleIndex = 5;
            this.colBankNoteSell.Width = 41;
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
            this.lblUyari.TabIndex = 4;
            // 
            // FrmDovizKurlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 358);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.grpKontroluMenu);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDovizKurlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merkez Bankası Döviz Kurları";
            this.Load += new System.EventHandler(this.FrmDovizKurlari_Load);
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
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsim;
        private DevExpress.XtraGrid.Columns.GridColumn colSembol;
        private DevExpress.XtraGrid.Columns.GridColumn colForexBuy;
        private DevExpress.XtraGrid.Columns.GridColumn colForexSell;
        private DevExpress.XtraGrid.Columns.GridColumn colBankNoteBuy;
        private DevExpress.XtraGrid.Columns.GridColumn colBankNoteSell;
        private DevExpress.XtraEditors.LabelControl lblUyari;
    }
}