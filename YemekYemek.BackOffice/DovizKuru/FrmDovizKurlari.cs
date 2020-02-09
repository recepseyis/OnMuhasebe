using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


using YemekYemek.Entities.Tables.OtherTables;

namespace YemekYemek.BackOffice.DovizKuru
{
    public partial class FrmDovizKurlari : XtraForm
    {
        public FrmDovizKurlari()
        {
            InitializeComponent();
            FileInfo info = new FileInfo(Application.StartupPath + "\\Kurlar.xml");
            lblUyari.Text = "Son Güncelleme Tarihi : " + info.LastWriteTime.ToString();
        }

        private void FrmDovizKurlari_Load(object sender, EventArgs e)
        {
            Guncelle(false);
        }
        private void Guncelle(bool indir = true)
        {
            if (indir)
            {
                using (System.Net.WebClient kurindir = new System.Net.WebClient())
                {
                    kurindir.DownloadFile("https://www.tcmb.gov.tr/kurlar/today.xml", Application.StartupPath + "\\Kurlar.xml");
                }
                lblUyari.Text = "Son Güncelleme Tarihi : " + DateTime.Now.ToString();
            }

            XElement kurlar = XElement.Load(Application.StartupPath + "\\Kurlar.xml");
            List <DovizKurlari> listKurlar = new List<DovizKurlari>();
            string ondalikKarakter = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator.ToString();
            foreach (var item in kurlar.Elements().ToList().Take(10))
            {
                listKurlar.Add(new DovizKurlari
                {
                    CurrencyCode = item.Attribute("CurrencyCode").Value,
                    Isim = item.Element("Isim").Value,
                    ForexBuying = Convert.ToDecimal(item.Element("ForexBuying").Value.Replace(".",ondalikKarakter)),
                    ForexSelling = Convert.ToDecimal(item.Element("ForexSelling").Value.Replace(".", ondalikKarakter)),
                    BanknoteBuying = Convert.ToDecimal(item.Element("BanknoteBuying").Value.Replace(".", ondalikKarakter)),
                    BanknoteSelling = Convert.ToDecimal(item.Element("BanknoteSelling").Value.Replace(".", ondalikKarakter))
                });
            }
            
            gridControl1.DataSource = listKurlar;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
