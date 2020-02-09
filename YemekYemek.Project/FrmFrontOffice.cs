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
using YemekYemek.BackOffice.Stok;
using YemekYemek.Entities.Context;
using YemekYemek.Entities.DataAccess;
using YemekYemek.Entities.Tables;
using YemekYemek.Entities.Tables.OtherTables;
using YemekYemek.Entities.Tools;

namespace YemekYemek.Project
{
    public partial class FrmFrontOffice : XtraForm
    {
        public bool saved = false;
        private YemekYemekContext context = new YemekYemekContext();
        private FisDAL fisdal = new FisDAL();
        private StokHareketDAL stokhareketdal = new StokHareketDAL();
        private KasaHareketDAL kasahareketdal = new KasaHareketDAL();
        private Entities.Tables.Fis _fisentity = new Entities.Tables.Fis();
        private CariDAL caridal = new CariDAL();
        private CariBakiye entitybakiye = new CariBakiye();
        FisAyarlari ayarlar = new FisAyarlari();

        public FrmFrontOffice()
        {
            InitializeComponent();
        }

        private void FrmFrontOffice_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmStokSec frm = new FrmStokSec();
            frm.ShowDialog();
            if (frm.secildi)
                stokhareketdal.AddOrUpdate(context, StokSec(frm._Secilen.First()));
            //toplamlar();
        }

        //private void toplamlar()
        //{
        //    gridView1.UpdateSummary();
        //    gridView1.UpdateTotalSummary();
        //    txtIskontoTutari.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) / 100 * txtIskontoOrani.Value;
        //    txtToplam.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) - txtIskontoTutari.Value;
        //    txtKdvToplam.Value = Convert.ToDecimal(colToplamKdv.SummaryItem.SummaryValue);
        //    txtIndirimToplam.Value = Convert.ToDecimal(colIndirimTutar.SummaryItem.SummaryValue);
        //    txtOdenmesiGereken.Value = txtToplam.Value - txtOdenenTutar.Value;
        //}

        private StokHareket StokSec(Entities.Tables.Stok entity)
        {
            StokHareket stokhareket = new StokHareket();
            IndirimDAL indirimdal = new IndirimDAL();
            stokhareket.StokKodu = entity.StokKodu;
            stokhareket.StokAdi = entity.StokAdi;
            stokhareket.Barkod = entity.Barkod;
            stokhareket.BarkodTuru = entity.BarkodTuru;
            stokhareket.DepoKodu = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo);
            stokhareket.DepoAdi = context.Depolar.SingleOrDefault(c => c.DepoKodu == stokhareket.DepoKodu).DepoAdi;
            stokhareket.BirimFiyati = _fisentity.FisTuru == "Alış Faturası" ? entity.AlisFiyati : entity.SatisFiyati;
            stokhareket.Birimi = entity.Birimi;
            stokhareket.Kdv = entity.SatisKdv;
            stokhareket.Miktari = txtMiktar.Value;
            stokhareket.IndirimOrani = indirimdal.StokIndirimi(context, entity.StokKodu);
            return stokhareket;
        }
    }
}
