using DevExpress.XtraEditors;
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
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Raporlar
{
    public partial class FrmOzgunRaporHazirla : XtraForm
    {
        Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private List<object> veriListesi = new List<object>();

        public FrmOzgunRaporHazirla()
        {
            InitializeComponent();
        }

        private void FrmOzgunRaporHazirla_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBoxControl1.Items.Where(c=> c.CheckState == CheckState.Checked).ToList())
            {
                Type tip = Assembly.Load("YemekYemek.Entities").GetTypes().SingleOrDefault(c => c.Name == item.Value.ToString());
                object veri = Activator.CreateInstance(tip);
                MethodInfo info = tip.GetMethod(item.Tag.ToString());
                try
                {
                    veriListesi.Add(info.Invoke(veri, new object[] { context }));
                }
                catch (Exception)
                {
                    veriListesi.Add(info.Invoke(veri, new object[] { context ,null }));
                }
            }
            FrmOzgunRaporlar frm = new FrmOzgunRaporlar(veriListesi);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
