using System.Collections.Generic;
using System.Linq;
using YemekYemek.Entities.Context;
using YemekYemek.Entities.Repositories;
using YemekYemek.Entities.Tables;
using YemekYemek.Entities.Valitadions;

namespace YemekYemek.Entities.DataAccess
{
    public class StokHareketDAL : EntityRepositoryBase<YemekYemekContext, StokHareket, StokHareketValidator>
    {
        public object GetGenelStok(YemekYemekContext context, string stokkodu)
        {
            var result = (from c in context.StokHareketleri.Where(c => c.StokKodu == stokkodu)
                          group c by new
                          { c.Hareket }
            into g
                          select new
                          {
                              Bilgi = g.Key.Hareket,
                              KayitSayisi = g.Count(),
                              Toplam = g.Sum(c => c.Miktari)
                          }).ToList();
            return result;
        }

        public object GetDepoStok(YemekYemekContext context, string stokkodu)
        {
            var result = context.Depolar.GroupJoin(context.StokHareketleri.Where(c => c.StokKodu == stokkodu), c => c.DepoKodu, c => c.DepoKodu, (depolar, stokhareketleri) => new
            {
                depolar.DepoKodu,
                depolar.DepoAdi,
                StokGiris = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktari) ?? 0,
                StokCikis = stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktari) ?? 0,
                MevcutStok = (stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktari) ?? 0) - (stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktari) ?? 0)
            }).ToList();
            return result;
        }

        public object DepoStokListele(YemekYemekContext context, string _depokodu)
        {
            var tablo = context.Stoklar.GroupJoin(context.StokHareketleri.Where(c => c.DepoKodu == _depokodu), c => c.StokKodu, c => c.StokKodu, (Stoklar, StokHareketleri) =>
             new
             {
                 Stoklar.StokKodu,
                 Stoklar.StokAdi,
                 StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktari) ?? 0,
                 StokCikis = StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktari) ?? 0,
                 MevcutStok = (StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktari) ?? 0) -
                 (StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktari) ?? 0)
             }).ToList();
            return tablo;
        }

        public object DepoIstatistikListele(YemekYemekContext context, string depokodu)
        {
            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                    Bilgi = "Stok Giriş",
                    Tutar = context.StokHareketleri.Where(c=> c.DepoKodu == depokodu && c.Hareket == "Stok Giriş").Sum(c=> c.Miktari) ?? 0,
                    KayitSayisi = context.StokHareketleri.Where(c=> c.DepoKodu == depokodu && c.Hareket == "Stok Giriş").Count()
                },
                new GenelToplam
                {
                    Bilgi = "Stok Çıkış",
                    Tutar = context.StokHareketleri.Where(c=> c.DepoKodu == depokodu && c.Hareket == "Stok Çıkış").Sum(c=> c.Miktari) ?? 0,
                    KayitSayisi = context.StokHareketleri.Where(c=> c.DepoKodu == depokodu && c.Hareket == "Stok Çıkış").Count()
                }
            };
            return genelToplamlar;
        }
    }
}