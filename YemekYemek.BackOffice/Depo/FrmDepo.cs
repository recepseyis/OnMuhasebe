using System;
using System.Windows.Forms;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Depo
{
    public partial class FrmDepo : DevExpress.XtraEditors.XtraForm
    {
        private string secilen = null;
        private string secilenAd = null;
        private DepoDAL depodal = new DepoDAL();
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        public bool saved = false;

        public FrmDepo()
        {
            InitializeComponent();
        }

        private void FrmDepo_Load(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele()
        {
            gridConDepo.DataSource = depodal.GetAll(context);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz.?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                secilen = gridDepo.GetFocusedRowCellValue(colDepoKodu).ToString();
                depodal.Delete(context, c => c.DepoKodu == secilen);
                depodal.Save(context);
            }
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            secilen = gridDepo.GetFocusedRowCellValue(colDepoKodu).ToString();
            Entities.Tables.Depo depoEntity = new Entities.Tables.Depo();
            depoEntity = depodal.GetByFilter(context, c => c.DepoKodu == secilen);
            depoEntity.Id = -1;
            depoEntity.DepoKodu = null;
            FrmDepoIslem frm = new FrmDepoIslem(depoEntity);
            frm.ShowDialog();
            if (frm.saved)
            {
                Listele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmDepoIslem frm = new FrmDepoIslem(new Entities.Tables.Depo());
            frm.ShowDialog();
            if (frm.saved)
            {
                Listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = gridDepo.GetFocusedRowCellValue(colDepoKodu).ToString();
            FrmDepoIslem frm = new FrmDepoIslem(depodal.GetByFilter(context, c => c.DepoKodu == secilen));
            frm.ShowDialog();
            if (frm.saved)
            {
                Listele();
            }
        }

        private void btnStokHareketleri_Click(object sender, EventArgs e)
        {
            secilen = gridDepo.GetFocusedRowCellValue(colDepoKodu).ToString();
            secilenAd = gridDepo.GetFocusedRowCellValue(colDepoKodu).ToString();
            FrmDepoHareket frm = new FrmDepoHareket(secilen, secilenAd);
            frm.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}