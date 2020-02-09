using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Cari
{
    public partial class FrmCariSec : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private CariDAL caridal = new CariDAL();
        public List<Entities.Tables.Cari> _Secilen = new List<Entities.Tables.Cari>();
        public bool secildi = false;

        public FrmCariSec(bool cokluSecim = false)
        {
            InitializeComponent();
            gridControl1.DataSource = caridal.GetCariler(context);
            if (cokluSecim)
            {
                lblUyari.Visible = true;
                gridView1.OptionsSelection.MultiSelect = true;
            }
        }

        private void FrmCariSec_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridView1.GetSelectedRows())
                {
                    string carikodu = gridView1.GetRowCellValue(row, colCariKodu).ToString();
                    _Secilen.Add(context.Cariler.SingleOrDefault(c => c.CariKodu == carikodu));
                }
                secildi = true;
                this.Close();
            }
            else
                MessageBox.Show("Seçili Bir Cari Bulunmadı.");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}