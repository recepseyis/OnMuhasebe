using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YemekYemek.Reports.Stok;

namespace YemekYemek.BackOffice.Raporlar
{
    public partial class FrmRaporListesi : XtraForm
    {
        private XtraReport rapor;
        public FrmRaporListesi()
        {
            InitializeComponent();
        }

        private void FrmRaporListesi_Load(object sender, EventArgs e)
        {

        }

        private void navBarLink_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            filterControl1.FilterString = null;
            var buton = sender as NavBarItem;
            Type tip = Assembly.Load("YemekYemek.Reports").GetTypes().SingleOrDefault(c => c.Name == buton.Name.Replace("link", null));
            rapor =(XtraReport) Activator.CreateInstance(tip);
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag == null ? txtAciklama.Text = null : buton.Tag.ToString();
            filterControl1.SourceControl = rapor.DataSource;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmRaporGoruntule frm = new FrmRaporGoruntule(rapor);
            rapor.FilterString = filterControl1.FilterString;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
