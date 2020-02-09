using System.Linq;
using YemekYemek.Entities.Repositories;
using YemekYemek.Entities.Tables;
using YemekYemek.Entities.Valitadions;

namespace YemekYemek.Entities.DataAccess
{
    public class DepoDAL : EntityRepositoryBase<Context.YemekYemekContext, Depo, DepoValidator>
    {
        public object DepoBazindaStokListele(Context.YemekYemekContext context, string stokkodu)
        {
            var result = context.Depolar.GroupJoin(context.StokHareketleri.Where(c => c.StokKodu == stokkodu), c => c.DepoKodu, c => c.DepoKodu, (depolar, stokhareketleri) => new
            {
                depolar.DepoKodu,
                depolar.DepoAdi,
                depolar.YetkiliAdi,
                depolar.YetkiliKodu,
                depolar.Aciklama,
                depolar.Telefon,
                StokGiris = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktari) ?? 0,
                StokCikis = stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktari) ?? 0,
                MevcutStok = (stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktari) ?? 0) - (stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktari) ?? 0)
            }).ToList();
            return result;
        }
    }
}