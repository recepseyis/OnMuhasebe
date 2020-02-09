using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekYemek.Entities.Context;
using YemekYemek.Entities.Repositories;
using YemekYemek.Entities.Tables;
using YemekYemek.Entities.Valitadions;

namespace YemekYemek.Entities.DataAccess
{
    public  class PersonelHareketDAL : EntityRepositoryBase<YemekYemekContext, PersonelHareket, PersonelHareketValidator>
    {
    }
}
