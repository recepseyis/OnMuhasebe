using DevExpress.XtraEditors;
using System;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Personel
{
    public partial class FrmPersonelHareket : XtraForm
    {
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private PersonelDAL personeldal = new PersonelDAL();
        private FisDAL fisdal = new FisDAL();
        private string _personelKodu;

        public FrmPersonelHareket(string personelkodu, string personeladi, string personelsoyadi)
        {
            InitializeComponent();
            _personelKodu = personelkodu;
            lblBaslik.Text = personelkodu + " - " + personeladi + " - " + personelsoyadi + "- Hareketleri";
        }

        private void FrmPersonelHareket_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listele()
        {
            gridConPersonelHareket.DataSource = fisdal.GetAll(context, c => c.PersonelKodu == _personelKodu);
            gridConFisToplam.DataSource = personeldal.PersonelFisToplam(context, _personelKodu);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}