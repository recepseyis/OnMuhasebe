using YemekYemek.Entities.InterFaces;

namespace YemekYemek.Entities.Tables
{
    public class Tanim : IEntity
    {
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public string Turu { get; set; }
        public string Tanimi { get; set; }
    }
}