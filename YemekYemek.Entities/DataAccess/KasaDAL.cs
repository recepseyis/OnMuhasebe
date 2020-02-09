using System.Collections.Generic;
using System.Linq;
using YemekYemek.Entities.Context;
using YemekYemek.Entities.Repositories;
using YemekYemek.Entities.Tables;
using YemekYemek.Entities.Valitadions;

namespace YemekYemek.Entities.DataAccess
{
    public class KasaDAL : EntityRepositoryBase<YemekYemekContext, Kasa, KasaValidator>
    {
        public object KasaListele(YemekYemekContext context)
        {
            var result = context.Kasalar.GroupJoin(context.KasaHareketleri, c => c.KasaKodu, c => c.KasaKodu, (kasa, kasahareket) => new
            {
                kasa.Id,
                kasa.KasaAdi,
                kasa.KasaKodu,
                kasa.YetkiliAdi,
                kasa.YetkiliKodu,
                kasa.Aciklama,
                KasaGiris = (kasahareket.Where(c => c.KasaKodu == kasa.KasaKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                KasaCikis = (kasahareket.Where(c => c.KasaKodu == kasa.KasaKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                Bakiye = (kasahareket.Where(c => c.KasaKodu == kasa.KasaKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0) - (kasahareket.Where(c => c.KasaKodu == kasa.KasaKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0)
            }).ToList();
            return result;
        }

        public object OdemeTuruToplamListele(YemekYemekContext context, string kasakodu)
        {
            var result = (from c in context.KasaHareketleri.Where(c => c.KasaKodu == kasakodu)
                          group c by new { c.OdemeTuruAdi } into grp
                          select new
                          {
                              grp.Key.OdemeTuruAdi,
                              KasaGiris = (grp.Where(c => c.OdemeTuruAdi == grp.Key.OdemeTuruAdi && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                              KasaCikis = (grp.Where(c => c.OdemeTuruAdi == grp.Key.OdemeTuruAdi && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                              Bakiye = (grp.Where(c => c.OdemeTuruAdi == grp.Key.OdemeTuruAdi && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0) - (grp.Where(c => c.OdemeTuruAdi == grp.Key.OdemeTuruAdi && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0)
                          }).ToList();
            return result;
        }

        public object GenelToplamListele(YemekYemekContext context, string kasakodu)
        {
            decimal KasaGiris = (context.KasaHareketleri.Where(c => c.KasaKodu == kasakodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0);
            int KasaGirisKayitSayisi = context.KasaHareketleri.Where(c => c.KasaKodu == kasakodu && c.Hareket == "Kasa Giriş").Count();
            decimal KasaCikis = (context.KasaHareketleri.Where(c => c.KasaKodu == kasakodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0);
            int KasaCikisKayitSayisi = context.KasaHareketleri.Where(c => c.KasaKodu == kasakodu && c.Hareket == "Kasa Çıkış").Count();

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