using System;
using System.Windows.Forms;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.OdemeTuru
{
    public partial class FrmOdemeTuru : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private OdemeTuruDAL odemeturudal = new OdemeTuruDAL();
        private string secilen = null;

        public FrmOdemeTuru()
        {
            InitializeComponent();
        }

        private void FrmOdemeTuru_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {
            gridConOdemeTuru.DataSource = odemeturudal.OdemeTuruListele(context);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz.?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                secilen = gridOdemeTuru.GetFocusedRowCellValue(colOdemeTuruKodu).ToString();
                odemeturudal.Delete(context, c => c.OdemeTuruKodu == secilen);
                odemeturudal.Save(context);
                listele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmOdemeTuruIslem frm = new FrmOdemeTuruIslem(new Entities.Tables.OdemeTuru());
            frm.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            string secilen = gridOdemeTuru.GetFocusedRowCellValue(colOdemeTuruKodu).ToString();
            FrmOdemeTuruIslem frm = new FrmOdemeTuruIslem(odemeturudal.GetByFilter(context, c => c.OdemeTuruKodu == secilen));
            frm.ShowDialog();
        }
    }
}