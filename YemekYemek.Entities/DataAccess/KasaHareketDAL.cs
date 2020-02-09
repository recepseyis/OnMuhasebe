using YemekYemek.Entities.Context;
using YemekYemek.Entities.Repositories;
using YemekYemek.Entities.Tables;
using YemekYemek.Entities.Valitadions;

namespace YemekYemek.Entities.DataAccess
{
    public class KasaHareketDAL : EntityRepositoryBase<YemekYemekContext, KasaHareket, KasaHareketValidator>
    {
    }
}