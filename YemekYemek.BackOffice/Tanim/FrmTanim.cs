using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Tanim
{
    public partial class FrmTanim : XtraForm
    {
        private TanimTuru _tanimturu;
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        public Entities.Tables.Tanim _entity;
        private int secilen;
        private TanimDAL tanimdal = new TanimDAL();
        public bool Secildi = false;

        public FrmTanim(TanimTuru tanimturu)
        {
            InitializeComponent();
            _tanimturu = tanimturu;
        }

        public enum TanimTuru
        {
            CariGrubu,
            CariAltGrubu,
            CariOzelKod1,
            CariOzelKod2,
            CariOzelKod3,
            CariOzelKod4,
            PersonelUnvan,
            CariTuru
        }

        private void FrmTanim_Load(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPage1;
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KayitAc()
        {
            btnSec.Enabled = false;
            btnEkle.Enabled = false;
            btnDuzenle.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            navigationFrame1.SelectedPage = navigationPage2;
            txtTanim.DataBindings.Add("Text", _entity, "Tanimi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void KayitKapat()
        {
            btnSec.Enabled = true;
            btnEkle.Enabled = true;
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            navigationFrame1.SelectedPage = navigationPage1;
            txtAciklama.DataBindings.Clear();
            txtTanim.DataBindings.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _entity = new Entities.Tables.Tanim();
            KayitAc();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridView2.GetFocusedRowCellValue(colId));
            _entity = context.Tanimlar.Where(c => c.Id == secilen).SingleOrDefault();
            KayitAc();
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz.?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                secilen = Convert.ToInt32(gridView2.GetFocusedRowCellValue(colId));
                tanimdal.Delete(context, c => c.Id == secilen);
                tanimdal.Save(context);
                Listele();
            }
        }

        private void Listele()
        {
            gridControl2.DataSource = tanimdal.GetAll(context, c => c.Turu == _tanimturu.ToString());
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _entity.Turu = _tanimturu.ToString();
            if (tanimdal.AddOrUpdate(context, _entity))
            {
                tanimdal.Save(context);
                KayitKapat();
                navigationFrame1.SelectedPage = navigationPage1;
                Listele();
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridView2.GetFocusedRowCellValue(colId));
            _entity = context.Tanimlar.Where(c => c.Id == secilen).SingleOrDefault();
            Secildi = true;
            this.Close();
        }
    }
}