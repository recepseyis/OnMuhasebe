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
using DevExpress.XtraScheduler;
using System.Data.Entity;

namespace YemekYemek.BackOffice.Ajanda
{
    public partial class FrmAjanda : XtraForm
    {
        Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        public FrmAjanda()
        {
            InitializeComponent();
            context.EFAppointments.Load();
            context.EFResources.Load();
            schedulerControl1.DataStorage.Appointments.DataSource = context.EFAppointments.Local.ToBindingList();
            schedulerControl1.DataStorage.Resources.DataSource = context.EFResources.Local.ToBindingList();
        }

        private void FrmAjanda_Load(object sender, EventArgs e)
        {

        }

        private void FrmAjanda_FormClosing(object sender, FormClosingEventArgs e)
        {
            context.SaveChanges();
            base.OnClosing(e);
            this.context.Dispose();
        }
    }
}
