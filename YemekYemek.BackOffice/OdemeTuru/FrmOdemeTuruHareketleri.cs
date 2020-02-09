using System;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.OdemeTuru
{
    public partial class FrmOdemeTuruHareketleri : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private OdemeTuruDAL odemeturudal = new OdemeTuruDAL();
        private string _odemeturukodu;

        public FrmOdemeTuruHareketleri(string odemeturukodu, string odemeturuadi)
        {
            InitializeComponent();
            _odemeturukodu = odemeturukodu;
        }

        private void FrmOdemeTuruHareketleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            gridConOdemeTuruHareket.DataSource = odemeturudal.GetAll(context, c => c.OdemeTuruKodu == _odemeturukodu);
            gridConFisToplam.DataSource = odemeturudal.KasaToplamListele(context, _odemeturukodu);
            gridConBakiye.DataSource = odemeturudal.GenelToplamListele(context, _odemeturukodu);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}