using System;
using System.Linq;
using YemekYemek.Entities.Context;
using YemekYemek.Entities.Repositories;
using YemekYemek.Entities.Tables;
using YemekYemek.Entities.Valitadions;

namespace YemekYemek.Entities.DataAccess
{
    public class IndirimDAL : EntityRepositoryBase<YemekYemekContext, Indirim, IndirimValidator>
    {

        public object IndirimListele(YemekYemekContext context)
        {
            var result = (from c in context.Indirimler select c).AsEnumerable().Select(c => new
            {
                c.Id,
                IndirimAktif = Aktif(c.IndirimTuru, Convert.ToDateTime(c.BitisTarihi), c.Durumu),
                c.Durumu,
                c.StokKodu,
                c.Barkod,
                c.StokAdi,
                c.IndirimTuru,
                c.BaslangicTarihi,
                c.BitisTarihi,
                c.Aciklama,
                c.IndirimOrani,
            }).ToList();
            return result;
        }

        public decimal StokIndirimi(YemekYemekContext context, string stokKodu)
        {
            decimal sonuc = 0;
            var result = (from c in context.Indirimler.Where(c => c.StokKodu == stokKodu) select c).AsEnumerable().Select(c => new
            {
                IndirimAktif = Aktif(c.IndirimTuru, Convert.ToDateTime(c.BitisTarihi), c.Durumu),
                c.IndirimOrani,
            }).SingleOrDefault();
            if (result != null && result.IndirimAktif == true)
            {
                sonuc = result.IndirimOrani;
            }
            return sonuc;
        }

        bool Aktif(string IndirimTuru, DateTime BitisTarihi, bool Durum)
        {
            bool result = false;
            if (Durum)
            {
                if (IndirimTuru == "Süresiz")
                {
                    result = true;
                }
                else
                {
                    if (DateTime.Now <= BitisTarihi)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}
