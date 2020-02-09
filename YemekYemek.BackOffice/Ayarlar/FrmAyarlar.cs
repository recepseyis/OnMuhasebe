using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YemekYemek.Entities.DataAccess;
using YemekYemek.Entities.Tools;

namespace YemekYemek.BackOffice.Ayarlar
{
    public partial class FrmAyarlar : XtraForm
    {
        Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        DepoDAL depodal = new DepoDAL();
        KasaDAL kasadal = new KasaDAL();
        public FrmAyarlar()
        {
            InitializeComponent();
            lookKasa.Properties.DataSource = kasadal.GetAll(context);
            lookDepo.Properties.DataSource = depodal.GetAll(context);
            lookDepo.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo);
            lookKasa.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa);
            toggleGuncelle.IsOn = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.GenelAyarlar_GuncellemeKontrol));
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo, lookDepo.EditValue.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa, lookKasa.EditValue.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.GenelAyarlar_GuncellemeKontrol, toggleGuncelle.IsOn.ToString());
        }

        private void navigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
