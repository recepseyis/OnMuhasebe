using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YemekYemek.Entities.Tools;

namespace YemekYemek.Backup
{
    public partial class FrmBackup : DevExpress.XtraEditors.XtraForm
    {
        YemekYemek.Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        public FrmBackup()
        {
            InitializeComponent();
            txtYedekKonum.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.YedeklemeAyarlari_YedeklemeKonumu);
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string tarih = DateTime.Now.ToLongDateString();
            string sqlcumle = $"USE YemekYemek; BACKUP DATABASE YemekYemek TO DISK='{txtYedekKonum.Text + "\\YemekYemek-" + tarih + ".rs"}'";
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlcumle);
        }

        private void txtYedekKonum_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                txtYedekKonum.Text = folder.SelectedPath;
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.YedeklemeAyarlari_YedeklemeKonumu, txtYedekKonum.Text);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "YemekYemek Yedekleme Dosyası *.rs | *.rs";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sqlcumle = $"USE master; ALTER DATABASE YemekYemek SET SINGLE_USER WITH ROLLBACK IMMEDIATE; ALTER DATABASE YemekYemek SET READ_ONLY;RESTORE DATABASE YemekYemek FROM DISK='{openFileDialog.FileName}'; ALTER DATABASE YemekYemek SET MULTI_USER;";
                context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlcumle);
            }
        }
    }
}
