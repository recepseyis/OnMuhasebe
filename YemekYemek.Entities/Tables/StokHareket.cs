using System;
using YemekYemek.Entities.InterFaces;

namespace YemekYemek.Entities.Tables
{
    public class StokHareket : IEntity
    {
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public string Fiskodu { get; set; }
        public string Hareket { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string BarkodTuru { get; set; }
        public string Barkod { get; set; }
        public string Birimi { get; set; }
        public Nullable<decimal> Miktari { get; set; }
        public int Kdv { get; set; }
        public Nullable<decimal> BirimFiyati { get; set; }
        public Nullable<decimal> IndirimOrani { get; set; }

        //public Nullable<decimal> IndirimTutari { get; set; }
        //public Nullable<decimal> ToplamTutar { get; set; }
        public string DepoKodu { get; set; }

        public string DepoAdi { get; set; }
        public string SeriNo { get; set; }
        public DateTime? Tarih { get; set; }
    }
}