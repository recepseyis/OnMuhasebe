using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using YemekYemek.BackOffice.Fis;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.StokHareketleri
{
    public partial class FrmStokHareketleri : XtraForm
    {
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private StokHareketDAL stokHareketdal = new StokHareketDAL();

        public FrmStokHareketleri()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            gridConStokHareket.DataSource = stokHareketdal.GetAll(context);
        }

        private void FrmStokHareketleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void repoSeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
        }

        private void repoSeriNO_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri = Convert.ToString(gridView1.GetFocusedRowCellValue(colSeriNo));
            FrmSeriNoGir frm = new FrmSeriNoGir(veri);
            frm.kilitli = true;
            frm.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmFisIslem frm = new FrmFisIslem(gridView1.GetFocusedRowCellValue(colFisKodu).ToString());
            frm.ShowDialog();
        }

        private void gridConStokHareket_DoubleClick(object sender, EventArgs e)
        {
            FrmFisIslem frm = new FrmFisIslem(gridView1.GetFocusedRowCellValue(colFisKodu).ToString(), FrmFisIslem.Nerden.Stok);
            frm.ShowDialog();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            gridConStokHareket.DataSource = context.StokHareketleri.Where(c => c.Tarih == Convert.ToDateTime("2019-05-09 00:00:00.000"));
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridConStokHareket.DataSource = context.StokHareketleri.Where(c => c.Tarih == Convert.ToDateTime(DateTime.Now.ToString("MM.dd.yyyy")));
        }
    }
}