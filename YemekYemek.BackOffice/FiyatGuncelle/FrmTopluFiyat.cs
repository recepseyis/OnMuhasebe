using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YemekYemek.BackOffice.Stok;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.FiyatGuncelle
{
    public partial class FrmTopluFiyat : XtraForm
    {
        Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        StokDAL stokdal = new StokDAL();
        public FrmTopluFiyat()
        {
            InitializeComponent();
            Listele();
        }
        private void Listele()
        {
            gridControl1.DataSource = context.Stoklar.Local.ToBindingList();
        }

        private void FrmTopluFiyat_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStokSec frm = new FrmStokSec(true);
            frm.ShowDialog();
            if (frm.secildi)
            {
                foreach (var itemstok in frm._Secilen)
                {
                    stokdal.AddOrUpdate(context, itemstok);
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            stokdal.Save(context);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            var result = stokdal.GetByFilter(context, c => c.StokKodu == secilen);
            context.Entry(result).State = EntityState.Detached;
        }

        private void btnFiyatDegistir_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                MessageBox.Show("Seçilen Bir Stok Bulunamadı. Stok Seçmek İstermisiniz.","Bilgi");
                return;
            }
            FrmFiyatDegistir frm = new FrmFiyatDegistir();
            frm.ShowDialog();
            if (frm.secildi)
            {
                foreach (var itemDegistir in frm.list.Where(c => c.Degistir = true))
                {
                    //if (itemDegistir.Degistir)
                    //{

                    //}
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        decimal kolondeger = 0;
                        decimal degisen = 0;
                        kolondeger = Convert.ToDecimal(gridView1.GetRowCellValue(i, itemDegistir.KolonAdi));
                        if (itemDegistir.DegisimTuru == "Yüzde")
                        {
                            degisen = itemDegistir.DegisimYonu == "Arttır"
                                ? kolondeger + kolondeger / 100 * itemDegistir.Degeri
                                : kolondeger - kolondeger / 100 * itemDegistir.Degeri;
                        }
                        else
                        {
                           degisen = itemDegistir.DegisimYonu == "Arttır"
                                ? kolondeger + itemDegistir.Degeri
                                : kolondeger - itemDegistir.Degeri;
                        }

                        gridView1.SetRowCellValue(i, itemDegistir.KolonAdi, degisen);
                    }
                }
            }
        }
    }
}
