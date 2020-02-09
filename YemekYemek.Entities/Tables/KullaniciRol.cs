using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekYemek.Entities.InterFaces;

namespace YemekYemek.Entities.Tables
{
    public class KullaniciRol : IEntity
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string FormAdi { get; set; }
        public string KontrolAdi { get; set; }
        public bool Yetki { get; set; }
        public int RootId { get; set; }
        public int ParentId { get; set; }
    }
}
