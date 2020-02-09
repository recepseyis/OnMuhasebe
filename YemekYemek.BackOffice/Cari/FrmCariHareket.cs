using DevExpress.XtraSplashScreen;
using System;
using System.Threading;
using YemekYemek.BackOffice.Genel;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Cari
{
    public partial class FrmCariHareket : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private CariDAL caridal = new CariDAL();
        private string _cariKodu = null;
        private string _cariAdi = null;

        public FrmCariHareket(string cariKodu, string cariAdi)
        {
            InitializeComponent();
            _cariKodu = cariKodu;
            _cariAdi = cariAdi;
            lblBaslik.Text = _cariKodu + " " + cariAdi + " " + "Hareketleri";
        }

        private void FrmCariHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            gridConFisToplam.DataSource = caridal.CariFisGenelToplam(context, _cariKodu);
            gridConBakiye.DataSource = caridal.CariGenelToplam(context, _cariKodu);
            gridConCariHareket.DataSource = caridal.CariFisAyrinti(context, _cariKodu);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            try
            {
                Thread.Sleep(1000);
                Guncelle();
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridCariHareket.OptionsView.ShowAutoFilterRow == true)
                gridCariHareket.OptionsView.ShowAutoFilterRow = false;
            else
                gridCariHareket.OptionsView.ShowAutoFilterRow = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}