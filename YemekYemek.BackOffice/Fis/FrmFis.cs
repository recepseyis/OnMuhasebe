using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Fis
{
    public partial class FrmFis : XtraForm
    {
        private string secilen = null;
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private FisDAL fisdal = new FisDAL();
        private KasaHareketDAL kasahareket = new KasaHareketDAL();
        private StokHareketDAL stokhareket = new StokHareketDAL();

        public FrmFis()
        {
            InitializeComponent();
        }

        private void FrmFis_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
            gridControl1.DataSource = fisdal.GetAll(context);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz.?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                secilen = gridView1.GetFocusedRowCellValue(colFisKodu).ToString();
                fisdal.Delete(context, c => c.FisKodu == secilen);
                kasahareket.Delete(context, c => c.FisKodu == secilen);
                stokhareket.Delete(context, c => c.Fiskodu == secilen);
                fisdal.Save(context);
                Listele();
            }
        }

        //private void barAlisFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    FrmFisIslem form = new FrmFisIslem(null,FrmFisIslem.Nerden.Stok,"Alış Faturası");
        //    form.ShowDialog();
        //}

        //private void dropDownButton1_Click(object sender, EventArgs e)
        //{
        //}

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            string secilen = gridView1.GetFocusedRowCellValue(colFisKodu).ToString();
            FrmFisIslem form = new FrmFisIslem(secilen);
            form.ShowDialog();
        }

        //private void barSatisFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    FrmFisIslem form = new FrmFisIslem(null, FrmFisIslem.Nerden.Stok, "Satış Faturası");
        //    form.ShowDialog();
        //}

        private void FisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(null, FrmFisIslem.Nerden.Stok, e.Item.Caption);
            form.ShowDialog();
            if (form.saved)
            {
                Listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            //personel işlem
            string secilen = gridView1.GetFocusedRowCellValue(colFisKodu).ToString();
            FrmFisIslem form = new FrmFisIslem(secilen,FrmFisIslem.Nerden.Personel,"Hakediş Fişi");
            form.ShowDialog();
        }
    }
}