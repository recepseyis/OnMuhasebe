using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekYemek.Entities.Tools
{
    public static class SettingsTool
    {
        static FileIniDataParser parser = new FileIniDataParser();
        static IniData data;
        static string dosyaadi = "Settings.ini";

        static SettingsTool()
        {
            if (File.Exists(Application.StartupPath + "\\" + dosyaadi) == true)
            {
               data = parser.ReadFile(dosyaadi);
            }
            else
            {
                using (File.Create(Application.StartupPath + "\\" + dosyaadi))
                {
                    
                }
                data = parser.ReadFile(dosyaadi);
            }
        }

        public enum Ayarlar
        {
            SmsAyarları_KullanıcıAdı,
            SmsAyarları_Parola,
            SatisAyarlari_VarsayilanDepo,
            SatisAyarlari_VarsayilanKasa,
            YedeklemeAyarlari_YedeklemeKonumu,
            GenelAyarlar_GuncellemeKontrol
        }

        public static void AyarDegistir(Ayarlar ayar, string value)
        {
            string[] gelenAyar = ayar.ToString().Split(Convert.ToChar("_"));
            if (data != null)
            {
                if (data.Sections.Count(c=> c.SectionName == gelenAyar[0])==0)
                {
                    data.Sections.AddSection(gelenAyar[0]);
                    data[gelenAyar[0]].AddKey(gelenAyar[1]);
                }
                else
                {
                    data[gelenAyar[0]].AddKey(gelenAyar[1]);
                }
                data[gelenAyar[0]][gelenAyar[1]] = value;
                Save();
            }
        }
        public static string AyarOku(Ayarlar ayar)
        {
            string[] gelenAyar = ayar.ToString().Split(Convert.ToChar("_"));
            return data[gelenAyar[0]][gelenAyar[1]];
        }
        public static void Save()
        {
            parser.WriteFile(dosyaadi, data);
        }
    }
}
