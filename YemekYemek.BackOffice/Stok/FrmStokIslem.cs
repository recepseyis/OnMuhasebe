using DevExpress.XtraEditors;
using System;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Stok
{
    public partial class FrmStokIslem : XtraForm
    {
        private Entities.Tables.Stok _entity;
        private StokDAL stokdal = new StokDAL();
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        public bool saved = false;

        public FrmStokIslem(Entities.Tables.Stok entity)//depency injetcion
        {
            InitializeComponent();
            _entity = entity;
            txtStokKodu.DataBindings.Add("Text", _entity, "StokKodu");
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu");
            txtStokAdi.DataBindings.Add("Text", _entity, "StokAdi");
            txtUreticiKodu.DataBindings.Add("Text", _entity, "UreticiKodu");
            txtBirimi.DataBindings.Add("Text", _entity, "Birimi");
            txtBarkod.DataBindings.Add("Text", _entity, "Barkod");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
            txtMinStokMiktari.DataBindings.Add("Text", _entity, "MinStokMiktari");
            txtMinStokMiktari.DataBindings[0].FormattingEnabled = true;
            txtMinStokMiktari.DataBindings[0].FormatString = "N3";
            txtMaxStokMiktari.DataBindings.Add("Text", _entity, "MaxStokMiktari");
            txtMaxStokMiktari.DataBindings[0].FormattingEnabled = true;
            txtMaxStokMiktari.DataBindings[0].FormatString = "N3";
            btnStokGrubu.DataBindings.Add("Text", _entity, "StokGrubu");
            btnStokAltGrubu.DataBindings.Add("Text", _entity, "StokAltGrubu");
            btnMarka.DataBindings.Add("Text", _entity, "Marka");
            btnModel.DataBindings.Add("Text", _entity, "Modeli");
            btnOzelKod1.DataBindings.Add("Text", _entity, "OzelKod1");
            btnOzelKod2.DataBindings.Add("Text", _entity, "OzelKod2");
            btnOzelKod3.DataBindings.Add("Text", _entity, "OzelKod3");
            btnOzelKod4.DataBindings.Add("Text", _entity, "OzelKod4");
            cmbAlisKdv.DataBindings.Add("Text", _entity, "AlisKdv");
            cmbSatisKdv.DataBindings.Add("Text", _entity, "SatisKdv");
            txtAlisFiyati.DataBindings.Add("Text", _entity, "AlisFiyati");
            txtAlisFiyati.DataBindings[0].FormattingEnabled = true;
            txtAlisFiyati.DataBindings[0].FormatString = "C3";
            txtAlisFiyat2.DataBindings.Add("Text", _entity, "AlisFiyati2");
            txtAlisFiyat2.DataBindings[0].FormattingEnabled = true;
            txtAlisFiyat2.DataBindings[0].FormatString = "C3";
            txtAlisFiyat3.DataBindings.Add("Text", _entity, "AlisFiyati3");
            txtAlisFiyat3.DataBindings[0].FormattingEnabled = true;
            txtAlisFiyat3.DataBindings[0].FormatString = "C3";
            txtSatisFiyati.DataBindings.Add("Text", _entity, "SatisFiyati");
            txtSatisFiyati.DataBindings[0].FormattingEnabled = true;
            txtSatisFiyati.DataBindings[0].FormatString = "C3";
            txtSatisFiyat2.DataBindings.Add("Text", _entity, "SatisFiyati2");
            txtSatisFiyat2.DataBindings[0].FormattingEnabled = true;
            txtSatisFiyat2.DataBindings[0].FormatString = "C3";
            txtSatisFiyat3.DataBindings.Add("Text", _entity, "SatisFiyati3");
            txtSatisFiyat3.DataBindings[0].FormattingEnabled = true;
            txtSatisFiyat3.DataBindings[0].FormatString = "C3";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStokIslem_Load(object sender, EventArgs e)
        {
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (stokdal.AddOrUpdate(context, _entity))
            {
                stokdal.Save(context);
                saved = true;
                this.Close();
            }
        }
    }
}