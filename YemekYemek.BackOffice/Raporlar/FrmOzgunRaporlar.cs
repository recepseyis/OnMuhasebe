using DevExpress.DashboardCommon;
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

namespace YemekYemek.BackOffice.Raporlar
{
    public partial class FrmOzgunRaporlar : XtraForm
    {
        public FrmOzgunRaporlar(List<object> verilistesi = null)
        {
            InitializeComponent();
            if (verilistesi != null)
            {
                foreach (var item in verilistesi)
                {
                    DashboardObjectDataSource datasource = new DashboardObjectDataSource();
                    datasource.DataSource = item;
                    datasource.Fill();
                    dashboardDesigner1.Dashboard.DataSources.Add(datasource);
                }
            }
        }

        private void FrmOzgunRaporlar_Load(object sender, EventArgs e)
        {

        }
    }
}
