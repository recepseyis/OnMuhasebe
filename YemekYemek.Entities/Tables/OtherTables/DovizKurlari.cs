using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekYemek.Entities.Tables.OtherTables
{
    public class DovizKurlari
    {
        public string CurrencyCode { get; set; }
        public string Isim { get; set; }
        public decimal? ForexBuying { get; set; }
        public decimal? ForexSelling { get; set; }
        public decimal? BanknoteBuying { get; set; }
        public decimal? BanknoteSelling { get; set; }
    }
}
