namespace YemekYemek.Reports.FaturaFis
{
    partial class RptFatura
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.colStokAdi = new DevExpress.XtraReports.UI.XRTableCell();
            this.colMiktar = new DevExpress.XtraReports.UI.XRTableCell();
            this.colBirimFiyat = new DevExpress.XtraReports.UI.XRTableCell();
            this.colToplamTutar = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.lblFaturaTarihi = new DevExpress.XtraReports.UI.XRLabel();
            this.lblIkametkah = new DevExpress.XtraReports.UI.XRLabel();
            this.lbladres = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCariAdi = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.lblGenelToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.lblKdvToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAraToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.colKdv = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 63.5F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTable1.Dpi = 254F;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(48.44439F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(1954.389F, 63.5F);
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.colStokAdi,
            this.colMiktar,
            this.colBirimFiyat,
            this.colKdv,
            this.colToplamTutar});
            this.xrTableRow1.Dpi = 254F;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Dpi = 254F;
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.Text = "colStokAdi";
            this.colStokAdi.Weight = 1.4669733917893437D;
            // 
            // colMiktar
            // 
            this.colMiktar.Dpi = 254F;
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.Text = "colMiktar";
            this.colMiktar.Weight = 0.90077591472073149D;
            // 
            // colBirimFiyat
            // 
            this.colBirimFiyat.Dpi = 254F;
            this.colBirimFiyat.Name = "colBirimFiyat";
            this.colBirimFiyat.Text = "colBirimFiyat";
            this.colBirimFiyat.Weight = 0.81112880937304377D;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Dpi = 254F;
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.Text = "colToplamTutar";
            this.colToplamTutar.Weight = 0.96119154264805928D;
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 254F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 254F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblFaturaTarihi,
            this.lblIkametkah,
            this.lbladres,
            this.lblCariAdi});
            this.PageHeader.Dpi = 254F;
            this.PageHeader.HeightF = 407.4583F;
            this.PageHeader.Name = "PageHeader";
            // 
            // lblFaturaTarihi
            // 
            this.lblFaturaTarihi.Dpi = 254F;
            this.lblFaturaTarihi.LocationFloat = new DevExpress.Utils.PointFloat(1627.125F, 25.00001F);
            this.lblFaturaTarihi.Name = "lblFaturaTarihi";
            this.lblFaturaTarihi.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblFaturaTarihi.SizeF = new System.Drawing.SizeF(375.7084F, 58.42F);
            this.lblFaturaTarihi.Text = "Fatura Tarihi";
            // 
            // lblIkametkah
            // 
            this.lblIkametkah.Dpi = 254F;
            this.lblIkametkah.LocationFloat = new DevExpress.Utils.PointFloat(1627.125F, 202.2708F);
            this.lblIkametkah.Name = "lblIkametkah";
            this.lblIkametkah.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblIkametkah.SizeF = new System.Drawing.SizeF(375.7084F, 58.41997F);
            this.lblIkametkah.Text = "il";
            // 
            // lbladres
            // 
            this.lbladres.Dpi = 254F;
            this.lbladres.LocationFloat = new DevExpress.Utils.PointFloat(1627.125F, 273.7083F);
            this.lbladres.Name = "lbladres";
            this.lbladres.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lbladres.SizeF = new System.Drawing.SizeF(375.7084F, 129.8575F);
            this.lbladres.Text = "Adres";
            // 
            // lblCariAdi
            // 
            this.lblCariAdi.Dpi = 254F;
            this.lblCariAdi.LocationFloat = new DevExpress.Utils.PointFloat(1627.125F, 130.8333F);
            this.lblCariAdi.Name = "lblCariAdi";
            this.lblCariAdi.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblCariAdi.SizeF = new System.Drawing.SizeF(375.7084F, 58.42F);
            this.lblCariAdi.Text = "CariAdi";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblGenelToplam,
            this.lblKdvToplam,
            this.lblAraToplam});
            this.PageFooter.Dpi = 254F;
            this.PageFooter.HeightF = 236.8784F;
            this.PageFooter.Name = "PageFooter";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.Dpi = 254F;
            this.lblGenelToplam.LocationFloat = new DevExpress.Utils.PointFloat(1627.125F, 178.4584F);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblGenelToplam.SizeF = new System.Drawing.SizeF(375.7084F, 58.42F);
            this.lblGenelToplam.Text = "GenelToplam";
            // 
            // lblKdvToplam
            // 
            this.lblKdvToplam.Dpi = 254F;
            this.lblKdvToplam.LocationFloat = new DevExpress.Utils.PointFloat(1627.125F, 99.08342F);
            this.lblKdvToplam.Name = "lblKdvToplam";
            this.lblKdvToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblKdvToplam.SizeF = new System.Drawing.SizeF(375.7084F, 58.42F);
            this.lblKdvToplam.Text = "Kdv Roplam";
            // 
            // lblAraToplam
            // 
            this.lblAraToplam.Dpi = 254F;
            this.lblAraToplam.LocationFloat = new DevExpress.Utils.PointFloat(1627.125F, 25.00001F);
            this.lblAraToplam.Name = "lblAraToplam";
            this.lblAraToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblAraToplam.SizeF = new System.Drawing.SizeF(375.7084F, 58.42F);
            this.lblAraToplam.Text = "Ara Toplam";
            // 
            // colKdv
            // 
            this.colKdv.Dpi = 254F;
            this.colKdv.Name = "colKdv";
            this.colKdv.Text = "colKdv";
            this.colKdv.Weight = 0.85993034146882175D;
            // 
            // RptFatura
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.PageFooter});
            this.Dpi = 254F;
            this.Margins = new System.Drawing.Printing.Margins(8, 21, 254, 254);
            this.PageHeight = 2794;
            this.PageWidth = 2159;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 25F;
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel lblFaturaTarihi;
        private DevExpress.XtraReports.UI.XRLabel lblIkametkah;
        private DevExpress.XtraReports.UI.XRLabel lbladres;
        private DevExpress.XtraReports.UI.XRLabel lblCariAdi;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell colStokAdi;
        private DevExpress.XtraReports.UI.XRTableCell colMiktar;
        private DevExpress.XtraReports.UI.XRTableCell colBirimFiyat;
        private DevExpress.XtraReports.UI.XRTableCell colToplamTutar;
        private DevExpress.XtraReports.UI.XRLabel lblGenelToplam;
        private DevExpress.XtraReports.UI.XRLabel lblKdvToplam;
        private DevExpress.XtraReports.UI.XRLabel lblAraToplam;
        private DevExpress.XtraReports.UI.XRTableCell colKdv;
    }
}
