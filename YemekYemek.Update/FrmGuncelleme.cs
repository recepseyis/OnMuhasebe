using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace YemekYemek.Update
{
    public partial class frm : DevExpress.XtraEditors.XtraForm
    {

        WebClient indir = new WebClient();
        public static bool IsRunning(string ProgramAdi)
        {
            return Process.GetProcessesByName(ProgramAdi).Length > 0;
        }
        public frm()
        {
            InitializeComponent();
            if (IsRunning("YemekYemek.BackOffice"))
            {
                if (MessageBox.Show("Güncelleme işleminden önce açık olan uygulamanızın kapatılması gerekiyor. Onaylıyormusunuz.?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (var item in Process.GetProcessesByName("YemekYemek.BackOffice"))
                    {
                        item.CloseMainWindow();
                        item.Kill();
                    }
                }

            }
        }

        private void btnIndir_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            lblindirilenVeri.Visible = true;
            if (!Directory.Exists(Application.StartupPath + "\\temp"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\temp");
                Directory.CreateDirectory(Application.StartupPath + "\\Raporlar");
            }
            //if (!Directory.Exists(Application.StartupPath + "\\Raporlar"))
            //{
            //    Directory.CreateDirectory(Application.StartupPath + "\\Raporlar");
            //}
            indir.DownloadProgressChanged += (DownloadProgressChangedEventHandler)IndirmeDurumu;
            indir.DownloadFileCompleted += (AsyncCompletedEventHandler)IndirmeBitti;
            indir.DownloadFileAsync(new Uri("http://www.rsyazilim.com/downloads/Update.zip"), Application.StartupPath + "\\temp\\Update.zip");

        }

        private void IndirmeBitti(object sender, AsyncCompletedEventArgs e)
        {
            lblindirilenVeri.Visible = true;
            ZipFile.ExtractToDirectory(Application.StartupPath + "\\temp\\Update.zip", Application.StartupPath + "\\temp");
            XElement Dosyalar = XElement.Load(Application.StartupPath + "\\Liste.xml");
            foreach (var item in Dosyalar.Elements().ToList())
            {
                if (File.Exists(Application.StartupPath + item.Element("YuklenecegiKonum").Value))
                {
                    File.Delete(Application.StartupPath + item.Element("YuklenecegiKonum").Value);
                }
                File.Copy(Application.StartupPath + "\\temp\\" + item.Element("DosyaAdi").Value, Application.StartupPath + item.Element("YuklenecegiKonum").Value);
            }
            Directory.Delete(Application.StartupPath + "\\temp", true);
            
            this.Close();
        }

        public void IndirmeDurumu(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarControl1.Properties.PercentView = true;
            progressBarControl1.Properties.Maximum = (int)e.TotalBytesToReceive;
            progressBarControl1.Text = Convert.ToString(e.BytesReceived);
            lblindirilenVeri.Text = $"{(Convert.ToDecimal(e.BytesReceived) / 1024 / 1024).ToString("N2")}MB\\{(Convert.ToDecimal(e.TotalBytesToReceive) / 1024 / 1024).ToString("N2")}MB";
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            if (progressBarControl1.Position == 99)
            {
                lblindirilenVeri.Text = "Uygulanıyor...";
            }
        }

        private void FrmGuncelleme_Load(object sender, EventArgs e)
        {

        }
    }
}
