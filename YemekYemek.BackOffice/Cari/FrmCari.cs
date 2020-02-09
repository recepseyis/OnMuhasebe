using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Threading;
using System.Windows.Forms;
using YemekYemek.BackOffice.Genel;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Cari
{
    public partial class FrmCari : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private CariDAL caridal = new CariDAL();
        private string secilen = null;
        private string secilenAd = null;

        public FrmCari()
        {
            InitializeComponent();
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

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        public void GetAll()
        {
            gridControl1.DataSource = caridal.GetCariler(context);
        }

        private void FrmCari_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            try
            {
                Thread.Sleep(1000);
                GetAll();
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz.?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
                caridal.Delete(context, c => c.CariKodu == secilen);
                caridal.Save(context);
                GetAll();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmCariIslem frm = new FrmCariIslem(new Entities.Tables.Cari());
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            FrmCariIslem frm = new FrmCariIslem(caridal.GetByFilter(context, c => c.CariKodu == secilen));
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            Entities.Tables.Cari cariEntity = new Entities.Tables.Cari();
            cariEntity = caridal.GetByFilter(context, c => c.CariKodu == secilen);
            cariEntity.Id = -1;
            cariEntity.CariKodu = null;
            FrmCariIslem frm = new FrmCariIslem(cariEntity);
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }

        private void btnStokHareketleri_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            secilenAd = gridView1.GetFocusedRowCellValue(colCariAdi).ToString();
            FrmCariHareket frm = new FrmCariHareket(secilen, secilenAd);
            frm.ShowDialog();
        }
    }
}