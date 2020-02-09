using System;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Depo
{
    public partial class FrmDepoIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Depo _entity;
        private DepoDAL depodal = new DepoDAL();
        public bool saved = false;
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();

        public FrmDepoIslem(Entities.Tables.Depo entity)
        {
            InitializeComponent();
            _entity = entity;
            txtDepoKodu.DataBindings.Add("Text", _entity, "DepoKodu");
            txtDepoAdi.DataBindings.Add("Text", _entity, "DepoAdi");
            txtIl.DataBindings.Add("Text", _entity, "Il");
            txtIlce.DataBindings.Add("Text", _entity, "Ilce");
            txtSemt.DataBindings.Add("Text", _entity, "Semt");
            txtTelefon.DataBindings.Add("Text", _entity, "Telefon");
            txtYetkiliAdi.DataBindings.Add("Text", _entity, "YetkiliAdi");
            txtYetkiliKodu.DataBindings.Add("Text", _entity, "YetkiliKodu");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
            txtAdres.DataBindings.Add("Text", _entity, "Adres");
        }

        private void FrmDepoIslem_Load(object sender, EventArgs e)
        {
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (depodal.AddOrUpdate(context, _entity))
            {
                depodal.Save(context);
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}