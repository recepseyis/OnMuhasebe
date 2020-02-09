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

namespace YemekYemek.BackOffice.Indirim
{
    public partial class FrmIndirimIslem : XtraForm
    {
        Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        IndirimDAL indirimdal = new IndirimDAL();
        public FrmIndirimIslem()
        {
            InitializeComponent();
            gridControl1.DataSource = context.Indirimler.Local.ToBindingList();
        }

        private void FrmIndirimIslem_Load(object sender, EventArgs e)
        {

        }

        private Entities.Tables.Indirim StokEkle(Entities.Tables.Stok entity)
        {
            Entities.Tables.Indirim _entity = new Entities.Tables.Indirim();
            _entity.StokKodu = entity.StokKodu;
            _entity.Barkod = entity.Barkod;
            _entity.StokAdi = entity.StokAdi;
            
            return _entity;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStokSec frm = new FrmStokSec(true);
            frm.ShowDialog();
            if (frm.secildi)
            {
                foreach (var item in frm._Secilen)
                {
                    Entities.Tables.Indirim _entity = new Entities.Tables.Indirim();
                    _entity = StokEkle(item);
                    var count = context.Indirimler.Count(c => c.StokKodu == item.StokKodu);
                    if (count != 0)
                    {
                        if (MessageBox.Show("Seçili Ürüne Daha Önceden Eklenmiş İndirim Bulunmaktadır. Var olan İndirimi Güncellemek İstermisiniz.?","Uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
                        {
                            var secilenId = context.Indirimler.SingleOrDefault(c => c.StokKodu == item.StokKodu);
                            _entity.Id = secilenId.Id;
                            indirimdal.AddOrUpdate(context, _entity);
                        }
                    }
                    else
                    {
                        indirimdal.AddOrUpdate(context, _entity);
                    }
                }
            }
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            foreach (var item in context.Indirimler.Local.ToList())
            {
                item.Durumu = true;
                item.Aciklama = txtAciklama.Text;
                if (btnSuresiz.Checked)
                {
                    item.IndirimTuru = "Süresiz";
                }
                else
                {
                    item.IndirimTuru = "Tarihler Arası";
                    item.BaslangicTarihi = dateBaslangic.DateTime;
                    item.BitisTarihi = dateBitis.DateTime;
                }
            }
            indirimdal.Save(context);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Listeden Çıkarılacaktır.","Uyarı",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var secilenStokkodu = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
                var secilen = indirimdal.GetByFilter(context, c => c.StokKodu == secilenStokkodu);
                context.Entry(secilen).State = EntityState.Detached;
            }
        }
    }
}
