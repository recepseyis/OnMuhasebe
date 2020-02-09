using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using YemekYemek.BackOffice.Tanim;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Personel
{
    public partial class FrmPersonelIslem : XtraForm
    {
        private Entities.Tables.Personel _entity;
        private PersonelDAL personeldal = new PersonelDAL();
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        public bool saved = false;

        public FrmPersonelIslem(Entities.Tables.Personel entity)
        {
            InitializeComponent();
            _entity = entity;
            txtAylikMaas.DataBindings.Add("Value", _entity, "AylikMaas", true, DataSourceUpdateMode.OnPropertyChanged, 0, "C2");
            txtPrimOrani.DataBindings.Add("Value", _entity, "PrimOrani", true, DataSourceUpdateMode.OnPropertyChanged, 0, "'%'0");
            txtIseGiris.DataBindings.Add("EditValue", _entity, "IseGirisTarihi", true, DataSourceUpdateMode.OnPropertyChanged, null, "F");
            txtIstenCikis.DataBindings.Add("EditValue", _entity, "IstenCikisTarihi", true, DataSourceUpdateMode.OnPropertyChanged, null, "F");
            txtSoyadi.DataBindings.Add("Text", _entity, "PersonelSoyAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelKodu.DataBindings.Add("Text", _entity, "PersonelKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNo.DataBindings.Add("Text", _entity, "VergiNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Calisiyor", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdi.DataBindings.Add("Text", _entity, "PersonelAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUnvani.DataBindings.Add("Text", _entity, "Unvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTcKimlik.DataBindings.Add("Text", _entity, "TcKimlikNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _entity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCepTelefonu.DataBindings.Add("Text", _entity, "CepTelefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add("Text", _entity, "Email", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void FrmPersonelIslem_Load(object sender, EventArgs e)
        {
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (personeldal.AddOrUpdate(context, _entity))
            {
                personeldal.Save(context);
                saved = true;
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void txtUnvani_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{
        //    FrmTanim frm = new FrmTanim(FrmTanim.TanimTuru.PersonelUnvan);
        //    frm.ShowDialog();
        //    if (frm.Secildi)
        //        txtUnvani.Text = frm._entity.Tanimi;
        //}

        private void txtUnvani_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim frm = new FrmTanim(FrmTanim.TanimTuru.PersonelUnvan);
            frm.ShowDialog();
            if (frm.Secildi)
                txtUnvani.Text = frm._entity.Tanimi;
        }
    }
}