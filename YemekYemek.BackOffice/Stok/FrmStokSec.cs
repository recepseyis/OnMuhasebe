using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Stok
{
    public partial class FrmStokSec : DevExpress.XtraEditors.XtraForm
    {
        private StokDAL stokdal = new StokDAL();
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        public List<Entities.Tables.Stok> _Secilen = new List<Entities.Tables.Stok>();
        public bool secildi = false;

        public FrmStokSec(bool cokluSecim = false)
        {
            InitializeComponent();
            if (cokluSecim)
            {
                lblUyari.Visible = true;
                gridStoklar.OptionsSelection.MultiSelect = true;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStokSec_Load(object sender, EventArgs e)
        {
            gridConStoklar.DataSource = stokdal.StokListele(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridStoklar.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridStoklar.GetSelectedRows())
                {
                    string stokkodu = gridStoklar.GetRowCellValue(row, colStokKodu).ToString();
                    _Secilen.Add(context.Stoklar.SingleOrDefault(c => c.StokKodu == stokkodu));
                }
                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen Ürün Bulunamadı");
            }
        }
    }
}