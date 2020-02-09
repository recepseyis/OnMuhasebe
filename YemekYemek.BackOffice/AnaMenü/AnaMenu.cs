using DevExpress.XtraBars.Helpers;
using DevExpress.XtraReports.UI;
using System;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using YemekYemek.Admin;
using YemekYemek.BackOffice.Ajanda;
using YemekYemek.BackOffice.AnaMenü;
using YemekYemek.BackOffice.Ayarlar;
using YemekYemek.BackOffice.Cari;
using YemekYemek.BackOffice.Depo;
using YemekYemek.BackOffice.DovizKuru;
using YemekYemek.BackOffice.Fis;
using YemekYemek.BackOffice.FiyatGuncelle;
using YemekYemek.BackOffice.Indirim;
using YemekYemek.BackOffice.Kasa;
using YemekYemek.BackOffice.KasaHareketleri;
using YemekYemek.BackOffice.OdemeTuru;
using YemekYemek.BackOffice.Personel;
using YemekYemek.BackOffice.Raporlar;
using YemekYemek.BackOffice.Sms;
using YemekYemek.BackOffice.Stok;
using YemekYemek.BackOffice.StokHareketleri;
using YemekYemek.Backup;
using YemekYemek.Entities.Tools;

using YemekYemek.Reports.FaturaFis;
using YemekYemek.Reports.Stok;
using YemekYemek.Update;

namespace YemekYemek.BackOffice
{
    public partial class BackOffices : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public BackOffices()
        {
            InitializeComponent();
            FrmKullaniciGiris frm = new FrmKullaniciGiris();
            frm.ShowDialog();
            WebClient indir = new WebClient();
            string programVersiyon = Assembly.Load("YemekYemek.BackOffice").GetName().Version.ToString();
            string guncelVersiyon = indir.DownloadString("http://www.rsyazilim.com/downloads/version.txt").Substring(0, 7);

            if (programVersiyon != guncelVersiyon)
            {
                if (Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.GenelAyarlar_GuncellemeKontrol)))
                {
                    if (MessageBox.Show("Programın yeni bir sürümü mevcut, güncellemek istermisiniz.!", "Bilgi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Process.Start($"{Application.StartupPath}\\YemekYemek.Update.exe");
                    }
                }
            }

            //using (var context = new YemekYemek.Entities.Context.YemekYemekContext())
            //{
            //    context.Database.CreateIfNotExists();
            //}
        }

        private void BackOffices_Load(object sender, EventArgs e)
        {


            FrmAnaMenuBilgi form = new FrmAnaMenuBilgi();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStok form = new FrmStok();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCari form = new FrmCari();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKasa form = new FrmKasa();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDepo form = new FrmDepo();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOdemeTuru form = new FrmOdemeTuru();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //FrmTanim form = new FrmTanim();
            //form.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFis form = new FrmFis();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonel form = new FrmPersonel();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStokHareketleri frm = new FrmStokHareketleri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKasaHareketleri frm = new FrmKasaHareketleri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDepo frm = new FrmDepo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOdemeTuru frm = new FrmOdemeTuru();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKasa frm = new FrmKasa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisIslem frm = new FrmFisIslem(null,FrmFisIslem.Nerden.Stok, e.Item.Caption);
            frm.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTopluFiyat frm = new FrmTopluFiyat();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmIndirim frm = new FrmIndirim();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmRaporListesi frm = new FrmRaporListesi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraReport rapor = new XtraReport();
            FrmRaporDuzenle frm = new FrmRaporDuzenle(rapor);
            frm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            frm.Show();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmEtiketOlustur frm = new FrmEtiketOlustur();
            frm.ShowDialog();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOzgunRaporHazirla frm = new FrmOzgunRaporHazirla();
            frm.ShowDialog();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAjanda frm = new FrmAjanda();
            frm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            frm.Show();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSms frm = new FrmSms();
            frm.ShowDialog();
        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDovizKurlari frm = new FrmDovizKurlari();
            frm.ShowDialog();
        }

        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAyarlar frm = new FrmAyarlar();
            frm.ShowDialog();
        }

        private void barButtonItem37_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBackup frm = new FrmBackup();
            frm.ShowDialog();
        }

        private void barButtonItem38_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WebClient indir = new WebClient();

            string programVersiyon = Assembly.Load("YemekYemek.BackOffice").GetName().Version.ToString();
            string guncelVersiyon = indir.DownloadString("http://www.rsyazilim.com/downloads/version.txt").Replace("\n", "");
            if (programVersiyon != guncelVersiyon)
            {
                MessageBox.Show("Güncelleme Mevcut İndiriliyor.");
                Process.Start($"{Application.StartupPath}\\YemekYemek.Update.exe");
            }
            else
            {
                MessageBox.Show("Programınız zaten Güncel");
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}