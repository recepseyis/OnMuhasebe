namespace YemekYemek.Entities.Tools
{
    public static class RsTools
    {
        public enum FaturaTipi
        {
            SatisFaturasi = 0,
            AlisFaturasi=1,
            ToptanSatisFaturasi=2,
            AlisIadeFaturasi=3,
            SatisIadeFaturasi=4
        }
        public static string ToFaturaTipi(this FaturaTipi enumValue)
        {
            switch (enumValue)
            {
                case FaturaTipi.AlisFaturasi:
                    return "Alış Faturası";
                case FaturaTipi.SatisFaturasi:
                    return "Satış Faturası";
                default:
                    return null;
            }
        }
        public static class FaturaTipiCons
        {
            public const string SatisFaturasi = "Satış Faturası1";
            public const string AlisFaturasi = "Alış Faturası ";
            public const string ToptanSatisFaturasi = "Toptan Satış Faturası1";
            public const string AlisIadeFaturasi = "Alış İade Faturası1";
            public const string SatisIadeFaturasi = "Satış İade Faturası1";
        }
    }
}
