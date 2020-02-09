using System;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.OdemeTuru
{
    public partial class FrmOdemeTuruIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private OdemeTuruDAL odemeturudal = new OdemeTuruDAL();
        private Entities.Tables.OdemeTuru _entity;

        public FrmOdemeTuruIslem(Entities.Tables.OdemeTuru entity)
        {
            InitializeComponent();
            _entity = entity;
            txtOdemeAdi.DataBindings.Add("Text", _entity, "OdemeTuruAdi");
            txtOdemeKodu.DataBindings.Add("Text", _entity, "OdemeTuruKodu");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void FrmOdemeTuruIslem_Load(object sender, EventArgs e)
        {
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (odemeturudal.AddOrUpdate(context, _entity))
            {
                odemeturudal.Save(context);
                this.Close();
            }
        }
    }
}