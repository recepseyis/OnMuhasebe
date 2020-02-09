using System;
using YemekYemek.Entities.InterFaces;

namespace YemekYemek.Entities.Tables
{
    public class Indirim : IEntity
    {
        public int Id { get; set; }
        public bool Durumu { get; set; }
        public string StokKodu { get; set; }
        public string Barkod { get; set; }
        public string StokAdi { get; set; }
        public string IndirimTuru { get; set; }
        public DateTime? BaslangicTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public decimal IndirimOrani { get; set; }
        public string Aciklama { get; set; }
    }
}
