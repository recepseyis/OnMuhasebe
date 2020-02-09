using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YemekYemek.BackOffice.Stok;

namespace YemekYemek.BackOffice.Raporlar
{
    public partial class FrmEtiketOlustur : XtraForm
    {
        private XtraReport rapor = new XtraReport();
        Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        List<Entities.Tables.Stok> stokentity = new List<Entities.Tables.Stok>();
        public FrmEtiketOlustur()
        {
            InitializeComponent();
            gridControl1.DataSource = stokentity;
        }
        private int mmToPixel(int mm)
        {
            return Convert.ToInt32(mm * 3.7795275591);
        }


        private void FrmEtiketOlustur_Load(object sender, EventArgs e)
        {

        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            rapor.DataSource = stokentity;
            rapor.ReportUnit = ReportUnit.TenthsOfAMillimeter;
            rapor.PageHeight = mmToPixel(Convert.ToInt32(txtDikeyUzunluk.Text));
            rapor.PageWidth = mmToPixel(Convert.ToInt32(txtYatayUzunluk.Text));
            rapor.Margins.Top = mmToPixel(Convert.ToInt32(txtMarginUst.Text));
            rapor.Margins.Bottom = mmToPixel(Convert.ToInt32(txtMarginAlt.Text));
            rapor.Margins.Left = mmToPixel(Convert.ToInt32(txtMarginSol.Text));
            rapor.Margins.Right = mmToPixel(Convert.ToInt32(txtMarginSag.Text));
            rapor.RollPaper = chkRulo.Checked;
            DetailBand detail = new DetailBand();
            detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown;
            detail.MultiColumn.Mode = MultiColumnMode.UseColumnWidth;
            detail.MultiColumn.ColumnWidth = mmToPixel(Convert.ToInt32(txtUzunluk.Text));
            detail.HeightF = mmToPixel(Convert.ToInt32(txtGenislik.Text));
            

            detail.MultiColumn.ColumnSpacing = mmToPixel(Convert.ToInt32(txtAraBosluk.Text));
            rapor.Bands.Add(detail);
            FrmRaporDuzenle frm = new FrmRaporDuzenle(rapor);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStokSec frm = new FrmStokSec(true);
            frm.ShowDialog();
            if (frm.secildi)
            {
                foreach (var item in frm._Secilen)
                {
                    stokentity.Add(item);
                }
            }
            gridView1.RefreshData();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
            gridView1.RefreshData();
        }

        private void wizardControl1_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.Page == completionWizardPage1 && e.Direction == DevExpress.XtraWizard.Direction.Forward && gridView1.RowCount == 0)
            {
                MessageBox.Show("Listeye Hiç bir ürün eklenmedi.! Devam Edilemez.");
                e.Cancel = true;
            }

            if (e.Page == wizardPage2 && e.Direction == DevExpress.XtraWizard.Direction.Forward && string.IsNullOrEmpty(txtMarginUst.Text))
            {
                MessageBox.Show("Geçersiz Değer Devam Edilemez.");
                e.Cancel = true;
            }

            if (e.Page == wizardPage3 && e.Direction == DevExpress.XtraWizard.Direction.Forward && string.IsNullOrEmpty(txtGenislik.Text))
            {
                MessageBox.Show("Geçersiz Değer Devam Edilemez.");
                e.Cancel = true;
            }
        }
    }
}
