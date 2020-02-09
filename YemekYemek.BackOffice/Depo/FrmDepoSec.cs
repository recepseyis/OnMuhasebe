using System;
using System.Linq;
using System.Windows.Forms;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Depo
{
    public partial class FrmDepoSec : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private DepoDAL depodal = new DepoDAL();
        public Entities.Tables.Depo entity;
        private string _stokkodu;
        public bool secildi = false;

        public FrmDepoSec(string stokkodu)
        {
            InitializeComponent();
            _stokkodu = stokkodu;
        }

        private void FrmDepoSec_Load(object sender, EventArgs e)
        {
            gridConDepolar.DataSource = depodal.DepoBazindaStokListele(context, _stokkodu);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount != 0)
            {
                string depokodu = gridView1.GetFocusedRowCellValue(colDepoKodu).ToString();
                entity = context.Depolar.SingleOrDefault(c => c.DepoKodu == depokodu);
                secildi = true;
                this.Close();
            }
            else
                MessageBox.Show("Depo Seçimi Yapılmadı");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}