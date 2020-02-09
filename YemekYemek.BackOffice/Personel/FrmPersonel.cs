using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using YemekYemek.BackOffice.Fis;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Personel
{
    public partial class FrmPersonel : XtraForm
    {
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private PersonelDAL personeldal = new PersonelDAL();

        public FrmPersonel()
        {
            InitializeComponent();
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmPersonelIslem frm = new FrmPersonelIslem(new Entities.Tables.Personel());
            frm.ShowDialog();
            if (frm.saved)
            {
                Listele();
            }
        }

        private void Listele()
        {
            gridControl1.DataSource = personeldal.PersonelListele(context);
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
                string secilen = gridView1.GetFocusedRowCellValue(colPersonelKodu).ToString();
                personeldal.Delete(context, c => c.PersonelKodu == secilen);
                personeldal.Save(context);
                Listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            string secilen = gridView1.GetFocusedRowCellValue(colPersonelKodu).ToString();
            FrmPersonelIslem frm = new FrmPersonelIslem(personeldal.GetByFilter(context, c => c.PersonelKodu == secilen));
            frm.ShowDialog();
            if (frm.saved)
            {
                Listele();
            }
        }

        private void btnStokHareketleri_Click(object sender, EventArgs e)
        {
            string secilen = gridView1.GetFocusedRowCellValue(colPersonelKodu).ToString();
            string secilenAd = gridView1.GetFocusedRowCellValue(colPersonelAdi).ToString();
            string secilensoyAd = gridView1.GetFocusedRowCellValue(colPersonelSoyad).ToString();
            FrmPersonelHareket frm = new FrmPersonelHareket(secilen, secilenAd, secilensoyAd);
            frm.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmFisIslem frm = new FrmFisIslem(null, FrmFisIslem.Nerden.Personel, "Hakediş Fişi");
            
            frm.ShowDialog();
        }
    }
}