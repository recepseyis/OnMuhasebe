using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using YemekYemek.Entities.DataAccess;
using DevExpress.DataAccess.ObjectBinding;

namespace YemekYemek.Reports.FaturaFis
{
    public partial class RptFatura : DevExpress.XtraReports.UI.XtraReport
    {
        public RptFatura(string fiskodu)
        {
            InitializeComponent();
            Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
            StokHareketDAL stokHareketdal = new StokHareketDAL();
            FisDAL fisdal = new FisDAL();

            Entities.Tables.Fis fisbilgi = fisdal.GetByFilter(context, c => c.FisKodu == fiskodu);

            ObjectDataSource stokdataSource = new ObjectDataSource { DataSource = stokHareketdal.GetAll(context,c=> c.Fiskodu == fiskodu) };
            this.DataSource = stokdataSource;
            lblCariAdi.Text = fisbilgi.CariAdi;
            lbladres.Text = fisbilgi.Adres;
            lblFaturaTarihi.Text = fisbilgi.Tarih.ToShortDateString();
            lblIkametkah.Text = fisbilgi.Il + " / " + fisbilgi.Ilce;

            colStokAdi.DataBindings.Add("Text", this.DataSource, "StokAdi");
            colMiktar.DataBindings.Add("Text", this.DataSource, "Miktari", "{0:N}");
            colBirimFiyat.DataBindings.Add("Text", this.DataSource, "BirimFiyati");
            colKdv.DataBindings.Add("Text", this.DataSource, "Kdv", "{0:'%'0}");

            CalculatedField calcindirimtutari = new CalculatedField();
            this.CalculatedFields.Add(calcindirimtutari);
            calcindirimtutari.Name = "IndirimliTutari";
            calcindirimtutari.Expression = "([BirimFiyati] * [Miktari]) / 100 * [IndirimOrani]";

            CalculatedField calckdvtutari = new CalculatedField();
            this.CalculatedFields.Add(calckdvtutari);
            calckdvtutari.Name = "KdvTutari";
            calckdvtutari.Expression = "([BirimFiyati] * [Miktari] - [IndirimOrani]) / 100 * [Kdv]";


            CalculatedField calctutar = new CalculatedField();
            this.CalculatedFields.Add(calctutar);
            calctutar.Name = "Tutar";
            calctutar.Expression = "([BirimFiyati] * [Miktari]) - [KdvTutari] - [IndirimliTutari]";

            CalculatedField calckdvlitutar = new CalculatedField();
            this.CalculatedFields.Add(calckdvlitutar);
            calckdvlitutar.Name = "KdvDahil";
            calckdvlitutar.Expression = "([BirimFiyati] * [Miktari]) - [IndirimliTutari]";

            colToplamTutar.DataBindings.Add("Text", null, "Tutar","{0:C2}");

            XRSummary sumAraToplam = new XRSummary();
            sumAraToplam.Func = SummaryFunc.Sum;
            sumAraToplam.Running = SummaryRunning.Page;
            sumAraToplam.FormatString = "{0:C2}";

            XRSummary sumkdvtoplam = new XRSummary();
            sumkdvtoplam.Func = SummaryFunc.Sum;
            sumkdvtoplam.Running = SummaryRunning.Page;
            sumkdvtoplam.FormatString = "{0:C2}";

            XRSummary sumgeneltoplam = new XRSummary();
            sumgeneltoplam.Func = SummaryFunc.Sum;
            sumgeneltoplam.Running = SummaryRunning.Page;
            sumgeneltoplam.FormatString = "{0:C2}";

            lblAraToplam.Summary = sumAraToplam;
            lblKdvToplam.Summary = sumkdvtoplam;
            lblGenelToplam.Summary = sumgeneltoplam;

            lblAraToplam.DataBindings.Add("Text", null, "Tutar");
            lblKdvToplam.DataBindings.Add("Text", null, "KdvTutari");
            lblGenelToplam.DataBindings.Add("Text", null, "KdvDahil");



        }

    }
}
