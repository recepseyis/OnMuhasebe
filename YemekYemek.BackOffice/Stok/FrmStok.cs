using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using YemekYemek.Entities.DataAccess;
using YemekYemek.Entities.Tools;

namespace YemekYemek.BackOffice.Stok
{
    public partial class FrmStok : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private StokDAL stokdal = new StokDAL();
        private string secilen;
        private string secilenAd;

        public FrmStok()
        {
            InitializeComponent();
            RolTool.RolleriYukle(this);
        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
            GetAll();
        }

        public void GetAll()
        {
            gridControl1.DataSource = stokdal.StokListele(context);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz.?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
                stokdal.Delete(context, c => c.StokKodu == secilen);
                stokdal.Save(context);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStokIslem frm = new FrmStokIslem(new Entities.Tables.Stok());
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            FrmStokIslem frm = new FrmStokIslem(stokdal.GetByFilter(context, c => c.StokKodu == secilen));
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            Entities.Tables.Stok stokEntity = new Entities.Tables.Stok();
            stokEntity = stokdal.GetByFilter(context, c => c.StokKodu == secilen);
            stokEntity.Id = -1;
            stokEntity.StokKodu = null;
            FrmStokIslem frm = new FrmStokIslem(stokEntity);
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }

        private void btnStokHareketleri_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            secilenAd = gridView1.GetFocusedRowCellValue(colStokAdı).ToString();
            FrmStokHareket form = new FrmStokHareket(secilen, secilenAd);
            form.ShowDialog();
        }
    }
}