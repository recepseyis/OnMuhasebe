using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.ObjectBinding;
using YemekYemek.Entities.Context;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.Reports.Stok
{
    public partial class RptStokDurumu : DevExpress.XtraReports.UI.XtraReport
    {
        public RptStokDurumu()
        {
            InitializeComponent();
            YemekYemekContext context = new YemekYemekContext();
            StokDAL stokdal = new StokDAL();
            ObjectDataSource stokdataSource = new ObjectDataSource { DataSource = stokdal.StokListele(context)};
            this.DataSource = stokdataSource;
            colStokAdi.DataBindings.Add("Text", this.DataSource, "StokAdi");
            colStokKodu.DataBindings.Add("Text", this.DataSource, "StokKodu");
            colBarkod.DataBindings.Add("Text", this.DataSource, "Barkod");
            colBirimi.DataBindings.Add("Text", this.DataSource, "Birimi");
            colStokGrubu.DataBindings.Add("Text", this.DataSource, "StokGrubu");
            colStokAltGrubu.DataBindings.Add("Text", this.DataSource, "StokAltGrubu");
            colStokGiris.DataBindings.Add("Text", this.DataSource, "StokGiris");
            colStokCikis.DataBindings.Add("Text", this.DataSource, "StokCikis");
            colMevcutStok.DataBindings.Add("Text", this.DataSource, "MevcutStok");
            colSatisKdv.DataBindings.Add("Text", this.DataSource, "SatisKdv");
        }

    }
}
