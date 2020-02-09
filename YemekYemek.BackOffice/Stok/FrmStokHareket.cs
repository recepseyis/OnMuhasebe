using DevExpress.XtraEditors;
using System;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Stok
{
    public partial class FrmStokHareket : XtraForm
    {
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private StokHareketDAL stokhareketdal = new StokHareketDAL();
        private string _stokkodu;

        public FrmStokHareket(string stokkodu, string stokadi)
        {
            InitializeComponent();
            _stokkodu = stokkodu;
            lblBaslik.Text = _stokkodu + " " + stokadi + " " + "Hareketleri";
        }

        private void FrmStokHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            gridConGenelStok.DataSource = stokhareketdal.GetGenelStok(context, _stokkodu);
            gridConDepoStok.DataSource = stokhareketdal.GetDepoStok(context, _stokkodu);
            gridConStokHareket.DataSource = stokhareketdal.GetAll(context, c => c.StokKodu == _stokkodu);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridStokHareket.OptionsView.ShowAutoFilterRow == true)
                gridStokHareket.OptionsView.ShowAutoFilterRow = false;
            else
                gridStokHareket.OptionsView.ShowAutoFilterRow = true;
        }
    }
}