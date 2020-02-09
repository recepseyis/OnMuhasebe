using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Kasa
{
    public partial class FrmKasa : DevExpress.XtraEditors.XtraForm
    {
        private KasaDAL kasadal = new KasaDAL();
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        public bool saved = false;
        private string secilen = null;

        public FrmKasa()
        {
            InitializeComponent();
        }

        public void Guncelle()
        {
            gridConKasalar.DataSource = kasadal.KasaListele(context);
        }

        private void FrmKasa_Load(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmKasaIslem frm = new FrmKasaIslem(new Entities.Tables.Kasa());
            frm.ShowDialog();
            if (frm.saved)
            {
                Guncelle();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colKasaKodu).ToString();
            FrmKasaIslem frm = new FrmKasaIslem(kasadal.GetByFilter(context, c => c.KasaKodu == secilen));
            frm.ShowDialog();
            if (frm.saved)
            {
                Guncelle();
            }
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colKasaKodu).ToString();
            Entities.Tables.Kasa kasaEntity = new Entities.Tables.Kasa();
            kasaEntity = kasadal.GetByFilter(context, c => c.KasaKodu == secilen);
            kasaEntity.Id = -1;
            kasaEntity.KasaKodu = null;
            FrmKasaIslem frm = new FrmKasaIslem(kasaEntity);
            frm.ShowDialog();
            if (frm.saved)
            {
                Guncelle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz.?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                secilen = gridView1.GetFocusedRowCellValue(colKasaKodu).ToString();
                kasadal.Delete(context, c => c.KasaKodu == secilen);
                kasadal.Save(context);
            }
        }

        private void btnStokHareketleri_Click(object sender, EventArgs e)
        {
            string secilenAd = gridView1.GetFocusedRowCellValue(colKasaAdi).ToString();
            secilen = gridView1.GetFocusedRowCellValue(colKasaKodu).ToString();
            FrmKasaHareket frm = new FrmKasaHareket(secilen, secilenAd);
            frm.ShowDialog();
        }
    }
}