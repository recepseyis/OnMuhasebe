using System;
using YemekYemek.Entities.InterFaces;

namespace YemekYemek.Entities.Tables
{
    public class Personel : IEntity
    {
        public int Id { get; set; }
        public bool Calisiyor { get; set; }
        public string Unvani { get; set; }
        public string PersonelKodu { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyAdi { get; set; }
        public string TcKimlikNo { get; set; }
        public string VergiNo { get; set; }
        public DateTime? IseGirisTarihi { get; set; }
        public DateTime? IstenCikisTarihi { get; set; }
        public string CepTelefonu { get; set; }
        public string Email { get; set; }
        public string Aciklama { get; set; }
        public string Adres { get; set; }
        public Nullable<decimal> PrimOrani { get; set; }
        public Nullable<decimal> AylikMaas { get; set; }
        public virtual PersonelAvans PersonelAvans { get; set; }
    }
}