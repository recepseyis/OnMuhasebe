using YemekYemek.Entities.Context;
using YemekYemek.Entities.Repositories;
using YemekYemek.Entities.Tables;
using YemekYemek.Entities.Valitadions;

namespace YemekYemek.Entities.DataAccess
{
    public class TanimDAL : EntityRepositoryBase<YemekYemekContext, Tanim, TanimValidator>
    {
    }
}