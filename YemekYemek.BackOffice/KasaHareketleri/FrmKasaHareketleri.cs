using DevExpress.XtraEditors;
using System;
using YemekYemek.BackOffice.Fis;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.KasaHareketleri
{
    public partial class FrmKasaHareketleri : XtraForm
    {
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private KasaHareketDAL kasaHareketdal = new KasaHareketDAL();

        public FrmKasaHareketleri()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            gridConKasaHareket.DataSource = kasaHareketdal.GetAll(context);
        }

        private void FrmKasaHareketleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnDetaylar_Click(object sender, EventArgs e)
        {
            FrmFisIslem frm = new FrmFisIslem(gridKasaHareket.GetFocusedRowCellValue(colFisKodu).ToString(), FrmFisIslem.Nerden.Kasa);
            frm.ShowDialog();
        }
    }
}