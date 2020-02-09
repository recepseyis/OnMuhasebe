using System;
using System.Collections.Generic;
using System.Linq;
using YemekYemek.Entities.Context;
using YemekYemek.Entities.Repositories;
using YemekYemek.Entities.Tables;
using YemekYemek.Entities.Valitadions;

namespace YemekYemek.Entities.DataAccess
{
    public class CariDAL : EntityRepositoryBase<YemekYemekContext, Cari, CariValidator>
    {
        public object GetCariler(YemekYemekContext context)
        {
            var result = context.Cariler.GroupJoin(context.Fisler, c => c.CariKodu, c => c.CariKodu, (cariler, fisler) => new
            {
                cariler.Id,
                cariler.CariKodu,
                cariler.CariAdi,
                cariler.CariTuru,
                cariler.YetkiliKisi,
                cariler.FaturaUnvani,
                cariler.CepTelefonu,
                cariler.Durumu,
                cariler.Email,
                cariler.VergiNumarasi,
                AlisToplam = fisler.Where(c => c.FisTuru == "Alış Fişi").Sum(c => c.ToplamTutar) ?? 0,
                SatisToplam = fisler.Where(c => c.FisTuru == "Perakende Satış Fişi").Sum(c => c.ToplamTutar) ?? 0,
            }).GroupJoin(context.KasaHareketleri, c => c.CariKodu, c => c.CariKodu, (cariler, kasahareket) => new
            {
                cariler.Id,
                cariler.CariKodu,
                cariler.CariAdi,
                cariler.CariTuru,
                cariler.YetkiliKisi,
                cariler.FaturaUnvani,
                cariler.CepTelefonu,
                cariler.Durumu,
                cariler.Email,
                cariler.VergiNumarasi,
                Alacak = cariler.AlisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                Borc = cariler.SatisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                Bakiye = (cariler.AlisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0)) - (cariler.SatisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0))
            }).ToList();

            return result;
        }

        public object CariFisAyrinti(YemekYemekContext context, string cariKodu)
        {
            var result = context.Fisler.Where(c => c.CariKodu == cariKodu).GroupJoin(context.KasaHareketleri.Where(c => c.CariKodu == cariKodu), c => c.CariKodu, c => c.CariKodu, (fisler, kasahareket) => new
            {
                fisler.Id,
                fisler.CariTuru,
                fisler.FisKodu,
                fisler.FisTuru,
                //fisler.PersonelAdi,
                fisler.PersonelKodu,
                fisler.BelgeNo,
                fisler.Tarih,
                fisler.IskontoOrani,
                fisler.IskontoTutar,
                fisler.Aciklama,
                fisler.ToplamTutar,
                Odenen = context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).Sum(c => c.Tutar) ?? 0,
                KalanOdeme = fisler.ToplamTutar - (context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).Sum(c => c.Tutar) ?? 0)
            }).ToList();
            return result;
        }

        public object CariFisGenelToplam(YemekYemekContext context, string cariKodu)
        {
            var result = (from c in context.Fisler.Where(c => c.CariKodu == cariKodu)
                          group c by new { c.FisTuru } into grp
                          select new
                          {
                              Bilgi = grp.Key.FisTuru,
                              KayitSayisi = grp.Count(),
                              Tutar = grp.Sum(c => c.ToplamTutar)
                          }).ToList();
            return result;
        }

        public object CariGenelToplam(YemekYemekContext context, string cariKodu)
        {
            decimal alacak = (context.Fisler.Where(c => c.CariKodu == cariKodu && c.FisTuru == "Alış Faturası").Sum(c => c.ToplamTutar) ?? 0) +
                (context.KasaHareketleri.Where(c => c.CariKodu == cariKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0);
            decimal borc = (context.Fisler.Where(c => c.CariKodu == cariKodu && c.FisTuru == "Perakende Satış Faturası").Sum(c => c.ToplamTutar) ?? 0) +
    (context.KasaHareketleri.Where(c => c.CariKodu == cariKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0);
            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                    Bilgi = "Alacak",
                    Tutar = alacak
                },
                new GenelToplam
                {
                    Bilgi = "Borç",
                    Tutar = borc
                },
                new GenelToplam
                {
                    Bilgi = "Bakiye",
                    Tutar = (alacak) - (borc)
                }
            };
            return genelToplamlar;
        }

        public CariBakiye CariBakiyesi(YemekYemekContext context, string carikodu)
        {
            decimal alacak = (context.Fisler.Where(c => c.CariKodu == carikodu && c.FisTuru == "Alış Faturası").Sum(c => c.ToplamTutar) ?? 0) +
    (context.KasaHareketleri.Where(c => c.CariKodu == carikodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0);
            decimal borc = (context.Fisler.Where(c => c.CariKodu == carikodu && c.FisTuru == "Satış Faturası").Sum(c => c.ToplamTutar) ?? 0) +
    (context.KasaHareketleri.Where(c => c.CariKodu == carikodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0);
            CariBakiye entity = new CariBakiye
            {
                RiskLimiti = Convert.ToDecimal(context.Cariler.Where(c => c.CariKodu == carikodu).SingleOrDefault().RiskLimiti),
                CariKodu = carikodu,
                Alacak = alacak,
                Borc = borc,
                Bakiye = alacak - borc
            };
            return entity;
        }

        public object CariTelefonlari(YemekYemekContext context)
        {
            var result = (from c in context.Cariler select new
            {
                c.CariKodu,
                c.CariAdi,
                c.CepTelefonu
            }).ToList();
            return result;
        }
    }
}