using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Indirim
{
    public partial class FrmIndirim : XtraForm
    {
        Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        IndirimDAL indirimdal = new IndirimDAL();
        public FrmIndirim()
        {
            InitializeComponent();
            Listele();
        }

        private void FrmIndirim_Load(object sender, EventArgs e)
        {
        }
        private void Listele()
        {
            gridControl1.DataSource = indirimdal.IndirimListele(context);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmIndirimIslem frm = new FrmIndirimIslem();
            frm.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Veriyi Silmek İstediğinize Eminmisiniz.?","Uyarı",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                var secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
                indirimdal.Delete(context, c => c.StokKodu == secilen);
                indirimdal.Save(context);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
            Listele();
        }

        private void btnDurum_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(gridView1.GetFocusedRowCellValue(colDurumu)) == true)
            {
                gridView1.SetFocusedRowCellValue(colDurumu, false);
                btnDurum.Text = "Pasif";
                indirimdal.Save(context);
            }
            else
            {
                gridView1.SetFocusedRowCellValue(colDurumu, true);
                btnDurum.Text = "Aktif";
                indirimdal.Save(context);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (Convert.ToBoolean(gridView1.GetFocusedRowCellValue(colDurumu)) == true)
            {
                btnDurum.Text = "Pasif";
            }
            else
            {
                btnDurum.Text = "Aktif";
            }
        }
    }
}
