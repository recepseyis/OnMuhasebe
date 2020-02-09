using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YemekYemek.Entities.DataAccess;
using YemekYemek.Entities.Tools;

namespace YemekYemek.BackOffice.Sms
{
    public partial class FrmSms : XtraForm
    {
        Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        CariDAL caridal = new CariDAL();
        List<Entities.Tables.Cari> carilist = new List<Entities.Tables.Cari>();
        public FrmSms()
        {
            InitializeComponent();
            gridControl1.DataSource = caridal.CariTelefonlari(context);
            gridControl2.DataSource = carilist;
        }

        private void FrmSms_Load(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(colListeTelefon) != null)
            {
                carilist.Add(new Entities.Tables.Cari
                {
                    CariKodu = gridView1.GetFocusedRowCellValue(colCariKodu).ToString(),
                    CariAdi = gridView1.GetFocusedRowCellValue(colCariAdi).ToString(),
                    CepTelefonu = gridView1.GetFocusedRowCellValue(colTelefon).ToString()
                });
                gridView2.RefreshData();
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gridView2.DeleteSelectedRows();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void memoEdit1_TextChanged(object sender, EventArgs e)
        {
            lblKarakterSayisi.Text = "Karakter Sayısı : " + memoEdit1.Text.Length + " / " + (memoEdit1.Text.Length / 160 + 1) + " Sms";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string gonderileceknumaralar = null;

            for (int i = 0; i < gridView2.RowCount; i++)
            {
                gonderileceknumaralar += gridView2.GetRowCellValue(i, colListeTelefon).ToString() + ",";
            }
            gonderileceknumaralar = gonderileceknumaralar.Substring(0, gonderileceknumaralar.Length - 1);
            //$"<alicilar>{gonderileceknumaralar}<alicilar>";
            MessageBox.Show(gonderileceknumaralar);

            //BURDAN
            //kno.Text= MÜŞTERİ NUMARASI
            //kad.Text= KULLANICI ADI
            //ksifre.Text= ŞİFRE
            //orjinator.Text= ORJİNATÖR (ONAYLI VE TAM DOĞRU OLMALIDIR)

            //xml içerisinde aşağıdaki gibi değerleri gönderebilirsiniz..
            //<zaman>2014-04-17 08:30:00</zaman>//sms gitmeye başlama zamanı 
            //<zamanasimi>2014-04-17 10:30:00</zamanasimi>//son gönderim deneme zamanı 
            string tur = "Normal";
            if (checkTurkce.Checked == true) tur = "Turkce";
            string smsNN = "data=<sms><kno>" + "35544" + "</kno><kulad>" + "05309168995" + "</kulad><sifre>" + "T9JPSJPG" + "</sifre>" +
            "<gonderen>" + "" + "</gonderen>" +
            "<telmesajlar>" +
            "<telmesaj><tel>" + "05309168995" + "</tel><mesaj>" + "SDASDAS" + "</mesaj></telmesaj>" +
            "<telmesaj><tel>" + "05454505671" + "</tel><mesaj>" + "WEW" + "</mesaj></telmesaj>" +
            "</telmesajlar>" +
            "<tur>" + tur + "</tur></sms>";
            lblcevap.Text = XmlPost("http://panel.vatansms.com/panel/smsgonderNNpost.php", smsNN);
            //BURAYA
        }
        private string XmlPost(string PostAddress, string xmlData)
        {
            using (WebClient wUpload = new WebClient())
            {
                wUpload.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                Byte[] bPostArray = Encoding.UTF8.GetBytes(xmlData);
                Byte[] bResponse = wUpload.UploadData(PostAddress, "POST", bPostArray);
                Char[] sReturnChars = Encoding.UTF8.GetChars(bResponse);
                string sWebPage = new string(sReturnChars);
                return sWebPage;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SmsAyarları_KullanıcıAdı, "Kullanici adıymış bu");
            MessageBox.Show(SettingsTool.AyarOku(SettingsTool.Ayarlar.SmsAyarları_KullanıcıAdı));
        }
    }
}
