using System;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Kasa
{
    public partial class FrmKasaHareket : DevExpress.XtraEditors.XtraForm
    {
        private YemekYemek.Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private KasaDAL kasadal = new KasaDAL();
        private KasaHareketDAL kasahareketdal = new KasaHareketDAL();
        private string _kasakodu = null;

        public FrmKasaHareket(string kasakodu, string kasaadi)
        {
            InitializeComponent();
            _kasakodu = kasakodu;
            lblBaslik.Text = _kasakodu + " " + kasaadi + " " + "Hareketleri";
        }

        private void FrmKasaHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        public void Guncelle()
        {
            gridConKasaHareket.DataSource = kasahareketdal.GetAll(context, c => c.KasaKodu == _kasakodu);
            gridConOdemeTuruToplam.DataSource = kasadal.OdemeTuruToplamListele(context, _kasakodu);
            gridConGenelToplam.DataSource = kasadal.GenelToplamListele(context, _kasakodu);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridKasaHareket.OptionsView.ShowAutoFilterRow == true)
                gridKasaHareket.OptionsView.ShowAutoFilterRow = false;
            else
                gridKasaHareket.OptionsView.ShowAutoFilterRow = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}