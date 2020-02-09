using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using YemekYemek.Entities.DataAccess;
using DevExpress.DataAccess.ObjectBinding;

namespace YemekYemek.Reports.Stok
{
    public partial class RptStokHareketleri : DevExpress.XtraReports.UI.XtraReport
    {
        public RptStokHareketleri()
        {
            InitializeComponent();
            Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
            StokHareketDAL stokHareketdal = new StokHareketDAL();
            ObjectDataSource dataSource = new ObjectDataSource { DataSource = stokHareketdal.GetAll(context) };
            this.DataSource = dataSource;
            colFisKodu.DataBindings.Add("Text", this.DataSource, "FisKodu");
            colBirimFiyat.DataBindings.Add("Text", this.DataSource, "BirimFiyati","{0:C2}");
            colBirimi.DataBindings.Add("Text", this.DataSource, "Birimi");
            colKdv.DataBindings.Add("Text", this.DataSource, "Kdv","{0:'%'0}");
            colMiktar.DataBindings.Add("Text", this.DataSource, "Miktari");
            colIndirimOrani.DataBindings.Add("Text", this.DataSource, "IndirimOrani", "{0:'%'0}");

            CalculatedField calcindirimtutari = new CalculatedField();
            this.CalculatedFields.Add(calcindirimtutari);
            calcindirimtutari.Name = "IndirimliTutari";
            calcindirimtutari.FieldType = FieldType.Decimal;
            calcindirimtutari.Expression = "([BirimFiyati] * [Miktari]) / 100 * [IndirimOrani]";

            CalculatedField calctutar = new CalculatedField();
            this.CalculatedFields.Add(calctutar);
            calctutar.FieldType = FieldType.Decimal;
            calctutar.Name = "Tutar";
            calctutar.Expression = "([BirimFiyati] * [Miktari]) - [IndirimliTutari]";

            colIndirimTutar.DataBindings.Add("Text", null, "IndirimliTutari", "{0:C2}");
            colToplamTutar.DataBindings.Add("Text", null, "Tutar", "{0:C2}");

            XRSummary sumindirimtutari = new XRSummary();
            sumindirimtutari.Func = SummaryFunc.Sum;
            sumindirimtutari.Running = SummaryRunning.Group;
            sumindirimtutari.FormatString = "{0:C2}";

            XRSummary sumtoplamtutar = new XRSummary();
            sumtoplamtutar.Func = SummaryFunc.Sum;
            sumtoplamtutar.Running = SummaryRunning.Group;
            sumtoplamtutar.FormatString = "{0:C2}";

            lblIndirimTutar.Summary = sumindirimtutari;
            lblToplamTutar.Summary = sumtoplamtutar;

            lblIndirimTutar.DataBindings.Add("Text", this.DataSource, "IndirimliTutari", "{0:C2}");
            lblToplamTutar.DataBindings.Add("Text", this.DataSource, "Tutar", "{0:C2}");

            // Sayfa Toplamı
            XRSummary sumindirimtutariSayfa = new XRSummary();
            sumindirimtutariSayfa.Func = SummaryFunc.Sum;
            sumindirimtutariSayfa.Running = SummaryRunning.Report;
            sumindirimtutariSayfa.FormatString = "{0:C2}";

            XRSummary sumtoplamtutarSAyfa = new XRSummary();
            sumtoplamtutarSAyfa.Func = SummaryFunc.Sum;
            sumtoplamtutarSAyfa.Running = SummaryRunning.Report;
            sumtoplamtutarSAyfa.FormatString = "{0:C2}";

            lblSayfaIndirimTutar.Summary = sumindirimtutariSayfa;
            lblSayfaToplamTutar.Summary = sumtoplamtutarSAyfa;

            lblSayfaIndirimTutar.DataBindings.Add("Text", this.DataSource, "IndirimliTutari", "{0:C2}");
            lblSayfaToplamTutar.DataBindings.Add("Text", this.DataSource, "Tutar", "{0:C2}");
            //

        }

    }
}
