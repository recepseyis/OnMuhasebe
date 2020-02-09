using System.Linq;
using YemekYemek.Entities.Context;
using YemekYemek.Entities.Repositories;
using YemekYemek.Entities.Tables;
using YemekYemek.Entities.Valitadions;

namespace YemekYemek.Entities.DataAccess
{
    public class PersonelDAL : EntityRepositoryBase<YemekYemekContext, Personel, PersonelValidator>
    {
        public object PersonelListele(YemekYemekContext context)
        {
            var result = context.Personeller.GroupJoin(context.Fisler, c => c.PersonelKodu, c => c.PersonelKodu, (personel, fis) => new
            {
                personel.Id,
                personel.PersonelAdi,
                personel.PersonelSoyAdi,
                personel.VergiNo,
                personel.PersonelKodu,
                personel.Unvani,
                personel.TcKimlikNo,
                personel.IseGirisTarihi,
                personel.IstenCikisTarihi,
                personel.PrimOrani,
                personel.Email,
                personel.CepTelefonu,
                personel.Adres,
                personel.Aciklama,
                personel.AylikMaas,
                personel.Calisiyor,
                ToplamSatis = (fis.Where(c => c.FisTuru == "Satış Faturası" && c.PersonelKodu == personel.PersonelKodu).Sum(c => c.ToplamTutar) ?? 0),
                PrimTutari = (fis.Where(c => c.FisTuru == "Satış Faturası" && c.PersonelKodu == personel.PersonelKodu).Sum(c => c.ToplamTutar) ?? 0) / 100 * personel.PrimOrani,
            }).ToList();
            return result;
        }
        public object TariheGorePersonelListele(YemekYemekContext context,int Ay, int Yil)
        {
            var result = context.Personeller.GroupJoin(context.Fisler, c => c.PersonelKodu, c => c.PersonelKodu, (personel, fis) => new
            {
                personel.Id,
                personel.PersonelAdi,
                personel.PersonelSoyAdi,
                personel.VergiNo,
                personel.PersonelKodu,
                personel.Unvani,
                personel.TcKimlikNo,
                personel.IseGirisTarihi,
                personel.IstenCikisTarihi,
                personel.PrimOrani,
                personel.Email,
                personel.CepTelefonu,
                personel.Adres,
                personel.Aciklama,
                personel.AylikMaas,
                personel.Calisiyor,
                ToplamSatis = (fis.Where(c => c.FisTuru == "Satış Faturası" && c.Tarih.Month == Ay && c.Tarih.Year == Yil && c.PersonelKodu == personel.PersonelKodu).Sum(c => c.ToplamTutar) ?? 0),
                PrimTutari = (fis.Where(c => c.FisTuru == "Satış Faturası" && c.Tarih.Month == Ay && c.Tarih.Year == Yil && c.PersonelKodu == personel.PersonelKodu).Sum(c => c.ToplamTutar) ?? 0) / 100 * personel.PrimOrani,
            }).ToList();
            return result;
        }
        public object PersonelFisToplam(YemekYemekContext context, string personelkodu)
        {
            var result = (from c in context.Fisler.Where(c => c.PersonelKodu == personelkodu)
                          group c by new { c.FisTuru } into grp
                          select new
                          {
                              Bilgi = grp.Key.FisTuru,
                              KayitSayisi = grp.Count(),
                              ToplamTutar = grp.Sum(c => c.ToplamTutar)
                          }).ToList();
            return result;
        }
    }
}