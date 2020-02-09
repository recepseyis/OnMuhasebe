using System;
using System.Collections.Generic;
using YemekYemek.Entities.InterFaces;

namespace YemekYemek.Entities.Tables
{
    public class PersonelAvans : IEntity
    {
        public int Id { get; set; }
        public Nullable<DateTime> Tarih { get; set; }
        public Nullable<decimal> OdenenTutar { get; set; }
        public string Aciklama { get; set; }
        public virtual List<Personel> Personel { get; set; }
    }
}