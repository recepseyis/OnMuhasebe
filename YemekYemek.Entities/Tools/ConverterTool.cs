using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekYemek.Entities.DataAccess;
using YemekYemek.Entities.Tables;
using YemekYemek.Entities.Context;

namespace YemekYemek.Entities.Tools
{

    public class ConverterTool
    {
        private StokHareket StokToStokHareket(Stok entity, YemekYemekContext context, decimal miktar)
        {
            StokHareket stokhareket = new StokHareket();
            IndirimDAL indirimdal = new IndirimDAL();
            stokhareket.StokKodu = entity.StokKodu;
            stokhareket.StokAdi = entity.StokAdi;
            stokhareket.Barkod = entity.Barkod;
            stokhareket.BarkodTuru = entity.BarkodTuru;
            stokhareket.DepoKodu = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo);
            stokhareket.DepoAdi = context.Depolar.SingleOrDefault(c => c.DepoKodu == stokhareket.DepoKodu).DepoAdi;
            //stokhareket.BirimFiyati = txtFisTuru.Text == "Alış Faturası" ? entity.AlisFiyati : entity.SatisFiyati;
            stokhareket.Birimi = entity.Birimi;
            stokhareket.Kdv = entity.SatisKdv;
            stokhareket.Miktari = miktar;
            stokhareket.IndirimOrani = indirimdal.StokIndirimi(context, entity.StokKodu);
            return stokhareket;
        }
    }
}
