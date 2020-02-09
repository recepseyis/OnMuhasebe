using System;
using System.Linq;
using System.Windows.Forms;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Kasa
{
    public partial class FrmKasaSec : DevExpress.XtraEditors.XtraForm
    {
        private YemekYemek.Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        public Entities.Tables.Kasa entity = new Entities.Tables.Kasa();
        private KasaDAL kasadal = new KasaDAL();
        public bool secildi = false;

        public FrmKasaSec()
        {
            InitializeComponent();
        }

        private void FrmKasaSec_Load(object sender, EventArgs e)
        {
            gridConKasalar.DataSource = kasadal.KasaListele(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            //string kasakodu = gridView1.GetFocusedRowCellValue(colKasaKodu).ToString();
            //entity =  context.Kasalar.SingleOrDefault(c => c.KasaKodu == kasakodu);
            //secildi = true;
            //this.Close();
            if (gridView1.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridView1.GetSelectedRows())
                {
                    string kasakodu = gridView1.GetFocusedRowCellValue(colKasaKodu).ToString();
                    entity = context.Kasalar.SingleOrDefault(c => c.KasaKodu == kasakodu);
                }
                secildi = true;
                this.Close();
            }
            else
                MessageBox.Show("Seçili Bir Kasa Bulunmadı.");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}