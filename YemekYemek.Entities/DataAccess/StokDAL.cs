using System.Linq;
using YemekYemek.Entities.Context;
using YemekYemek.Entities.Repositories;
using YemekYemek.Entities.Tables;
using YemekYemek.Entities.Valitadions;

namespace YemekYemek.Entities.DataAccess
{
    public class StokDAL : EntityRepositoryBase<YemekYemekContext, Stok, StokValidator>
    {
        public object StokListele(YemekYemekContext context)
        {
            var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.StokKodu, c => c.StokKodu, (Stoklar, StokHareketleri) =>
            new
            {
                Stoklar.Id,
                Stoklar.StokKodu,
                Stoklar.StokAdi,
                Stoklar.Barkod,
                Stoklar.SatisKdv,
                Stoklar.Durumu,
                Stoklar.Birimi,
                Stoklar.StokGrubu,
                Stoklar.StokAltGrubu,
                Stoklar.Marka,
                Stoklar.Modeli,
                Stoklar.AlisFiyati,
                Stoklar.SatisFiyati,
                Stoklar.UreticiKodu,
                StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktari) ?? 0,
                StokCikis = StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktari) ?? 0,
                MevcutStok = (StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktari) ?? 0) - (StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktari) ?? 0)
            }).ToList();
            return tablo;
        }
    }
}