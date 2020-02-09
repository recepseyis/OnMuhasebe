using System;
using YemekYemek.Entities.InterFaces;

namespace YemekYemek.Entities.Tables
{
    public class Fis : IEntity
    {
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public string FisKodu { get; set; }
        public string FisTuru { get; set; }
        public string CariTuru { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public string BelgeNo { get; set; }
        public DateTime Tarih { get; set; }
        public string PersonelKodu { get; set; }
        public string PersonelAdi { get; set; }
        public Nullable<decimal> IskontoOrani { get; set; }
        public Nullable<decimal> IskontoTutar { get; set; }
        public Nullable<decimal> ToplamTutar { get; set; }
        public string FaturaUnvani { get; set; }
        public string CepTelefonu { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string Adres { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
    }
}