using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class FrmRaporDuzenle : XtraForm
    {
        public FrmRaporDuzenle(XtraReport rapor = null)
        {
            InitializeComponent();
            if (rapor != null)
            {
                YeniRapor(rapor);
            }
            else
            {
                reportDesigner1.OpenReport(rapor);
            }
            
        }

        private void FrmRaporDuzenle_Load(object sender, EventArgs e)
        {

        }
        private void YeniRapor(XtraReport rapor1)
        {
            ReportDesignTool designTool = new ReportDesignTool(rapor1);
            //designTool.ShowDesignerDialog();
        }
    }
}
