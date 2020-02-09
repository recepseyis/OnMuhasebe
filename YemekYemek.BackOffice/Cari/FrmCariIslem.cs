using System;
using YemekYemek.BackOffice.Tanim;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Cari
{
    public partial class FrmCariIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Cari _entity;
        private CariDAL caridal = new CariDAL();
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        public bool saved = false;

        public FrmCariIslem(Entities.Tables.Cari entity)
        {
            InitializeComponent();
            _entity = entity;
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu");
            txtCariAdi.DataBindings.Add("Text", _entity, "CariAdi");
            txtCariKodu.DataBindings.Add("Text", _entity, "CariKodu");
            txtCariTuru.DataBindings.Add("Text", _entity, "CariTuru");
            txtYetkiliKisi.DataBindings.Add("Text", _entity, "YetkiliKisi");
            txtFaturaUnvani.DataBindings.Add("Text", _entity, "FaturaUnvani");
            txtCepTelefonu.DataBindings.Add("Text", _entity, "CepTelefonu");
            txtSabitTelefon.DataBindings.Add("Text", _entity, "Telefon");
            txtFax.DataBindings.Add("Text", _entity, "Fax");
            txtEmail.DataBindings.Add("Text", _entity, "Email");
            txtWeb.DataBindings.Add("Text", _entity, "Web");
            txtil.DataBindings.Add("Text", _entity, "Il");
            txtilce.DataBindings.Add("Text", _entity, "Ilce");
            txtSemt.DataBindings.Add("Text", _entity, "Semt");
            txtAdres.DataBindings.Add("Text", _entity, "Adres");
            btnCariGrubu.DataBindings.Add("Text", _entity, "CariGrubu");
            btnCariAltGrubu.DataBindings.Add("Text", _entity, "CariAltGrubu");
            btnOzelKod1.DataBindings.Add("Text", _entity, "OzelKod");
            btnOzelKod2.DataBindings.Add("Text", _entity, "OzelKod1");
            btnOzelKod3.DataBindings.Add("Text", _entity, "OzelKod2");
            btnOzelKod4.DataBindings.Add("Text", _entity, "OzelKod3");
            txtVergiDairesi.DataBindings.Add("Text", _entity, "VergiDairesi");
            txtVergiNumarasi.DataBindings.Add("Text", _entity, "VergiNumarasi");
            txtiskontoOrani.DataBindings.Add("Text", _entity, "IskontoOrani");
            txtRiskLimiti.DataBindings.Add("Text", _entity, "RiskLimiti");
            txtAlisFiyati.DataBindings.Add("Text", _entity, "AlisOzelFiyati");
            txtSatisFiyati.DataBindings.Add("Text", _entity, "SatisOzelFiyati");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCariIslem_Load(object sender, EventArgs e)
        {
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (caridal.AddOrUpdate(context, _entity))
            {
                caridal.Save(context);
                saved = true;
                this.Close();
            }
        }

        private void btnCariGrubu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim frm = new FrmTanim(FrmTanim.TanimTuru.CariGrubu);
                    frm.ShowDialog();
                    if (frm.Secildi)
                        btnCariGrubu.Text = frm._entity.Tanimi;
                    break;
                    //case 1:
                    //    btnCariGrubu.Text = null;
                    //    break;
            }
        }

        private void btnOzelKod1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim frm = new FrmTanim(FrmTanim.TanimTuru.CariOzelKod1);
                    frm.ShowDialog();
                    if (frm.Secildi)
                        btnOzelKod1.Text = frm._entity.Tanimi;
                    break;
                    //case 1:
                    //    btnCariGrubu.Text = null;
                    //    break;
            }
        }

        private void txtCariTuru_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim frm = new FrmTanim(FrmTanim.TanimTuru.CariTuru);
            frm.ShowDialog();
            if (frm.Secildi)
                txtCariTuru.Text = frm._entity.Tanimi;
        }
    }
}