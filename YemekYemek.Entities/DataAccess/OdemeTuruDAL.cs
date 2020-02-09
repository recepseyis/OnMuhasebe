using System.Collections.Generic;
using System.Linq;
using YemekYemek.Entities.Context;
using YemekYemek.Entities.Repositories;
using YemekYemek.Entities.Tables;
using YemekYemek.Entities.Valitadions;

namespace YemekYemek.Entities.DataAccess
{
    public class OdemeTuruDAL : EntityRepositoryBase<YemekYemekContext, OdemeTuru, OdemeTuruValidator>
    {
        public object OdemeTuruListele(YemekYemekContext context)
        {
            var result = context.OdemeTurleri.GroupJoin(context.KasaHareketleri, c => c.OdemeTuruKodu, c => c.OdemeTuruKodu, (odemeturu, kasahareket) => new
            {
                odemeturu.Aciklama,
                odemeturu.OdemeTuruAdi,
                odemeturu.OdemeTuruKodu,
                KasaGiris = (kasahareket.Where(c => c.OdemeTuruKodu == odemeturu.OdemeTuruKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                KasaCikis = (kasahareket.Where(c => c.OdemeTuruKodu == odemeturu.OdemeTuruKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                Bakiye = (kasahareket.Where(c => c.OdemeTuruKodu == odemeturu.OdemeTuruKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0) - (kasahareket.Where(c => c.OdemeTuruKodu == odemeturu.OdemeTuruKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0)
            }).ToList();
            return result;
        }

        public object KasaToplamListele(YemekYemekContext context, string odemeturukodu)
        {
            var result = (from c in context.KasaHareketleri.Where(c => c.OdemeTuruKodu == odemeturukodu)
                          group c by new { c.KasaKodu, c.KasaAdi } into grp
                          select new
                          {
                              grp.Key.KasaKodu,
                              grp.Key.KasaAdi,
                              KasaGiris = (grp.Where(c => c.KasaKodu == grp.Key.KasaKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                              KasaCikis = (grp.Where(c => c.KasaKodu == grp.Key.KasaKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                              Bakiye = (grp.Where(c => c.KasaKodu == grp.Key.KasaKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0) - (grp.Where(c => c.KasaKodu == grp.Key.KasaKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0)
                          }).ToList();
            return result;
        }

        public object GenelToplamListele(YemekYemekContext context, string odemeturukodu)
        {
            decimal KasaGiris = (context.KasaHareketleri.Where(c => c.OdemeTuruKodu == odemeturukodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0);
            int KasaGirisKayitSayisi = context.KasaHareketleri.Where(c => c.OdemeTuruKodu == odemeturukodu && c.Hareket == "Kasa Giriş").Count();
            decimal KasaCikis = (context.KasaHareketleri.Where(c => c.OdemeTuruKodu == odemeturukodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0);
            int KasaCikisKayitSayisi = context.KasaHareketleri.Where(c => c.OdemeTuruKodu == odemeturukodu && c.Hareket == "Kasa Çıkış").Count();

            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                    Bilgi = "Kasa Giriş",
                    KayitSayisi = KasaGirisKayitSayisi,
                    Tutar = KasaGiris
                },
                new GenelToplam
                {
                    Bilgi = "Kasa Çıkış",
                    KayitSayisi = KasaCikisKayitSayisi,
                    Tutar = KasaCikis
                },
                new GenelToplam
                {
                    Bilgi = "Bakiye",
                    KayitSayisi = KasaGirisKayitSayisi + KasaCikisKayitSayisi,
                    Tutar = (KasaGiris) - (KasaCikis)
                }
            };
            return genelToplamlar;
        }
    }
}