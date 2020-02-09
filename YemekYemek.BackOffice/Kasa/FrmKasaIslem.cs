using System;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Kasa
{
    public partial class FrmKasaIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private KasaDAL kasadal = new KasaDAL();
        private Entities.Tables.Kasa _entity;
        public bool saved = false;

        public FrmKasaIslem(Entities.Tables.Kasa entity)
        {
            InitializeComponent();
            _entity = entity;
            txtKasaKodu.DataBindings.Add("text", _entity, "KasaKodu");
            txtKasaAdi.DataBindings.Add("text", _entity, "KasaAdi");
            txtYetkiliAdi.DataBindings.Add("text", _entity, "YetkiliAdi");
            txtYetkiliKodu.DataBindings.Add("text", _entity, "YetkiliKodu");
            txtAciklama.DataBindings.Add("text", _entity, "Aciklama");
        }

        private void FrmKasaIslem_Load(object sender, EventArgs e)
        {
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (kasadal.AddOrUpdate(context, _entity))
            {
                kasadal.Save(context);
                saved = true;
                this.Close();
            }
        }
    }
}