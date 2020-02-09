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

namespace YemekYemek.BackOffice.Personel
{
    public partial class FrmPersonelSec : XtraForm
    {
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private PersonelDAL personeldal = new PersonelDAL();
        public List<Entities.Tables.PersonelHareket> _Secilen = new List<Entities.Tables.PersonelHareket>();
        public bool secildi = false;
        private DateTime? _donem;
        public FrmPersonelSec(DateTime? donem,bool cokluSecim = false)
        {
            InitializeComponent();
            gridControl1.DataSource = personeldal.TariheGorePersonelListele(context, donem.Value.Month, donem.Value.Year);
            if (cokluSecim)
            {
                lblUyari.Visible = true;
                gridView1.OptionsSelection.MultiSelect = true;
            }
            _donem = donem;
        }

        private void FrmPersonelSec_Load(object sender, EventArgs e)
        {

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridView1.GetSelectedRows())
                {
                    string personelkodu = gridView1.GetRowCellValue(row, colPersonelKodu).ToString();
                    _Secilen.Add(new Entities.Tables.PersonelHareket
                    {
                        PersonelKodu = gridView1.GetRowCellValue(row, colPersonelKodu).ToString(),
                        PersonelAdi = gridView1.GetRowCellValue(row, colPersonelAdi).ToString(),
                        TcKimlikNo = gridView1.GetRowCellValue(row, colTcKimlikNo).ToString(),
                        Unvani = gridView1.GetRowCellValue(row, colUnvani).ToString(),
                        Donemi = _donem,
                        AylikMaas = Convert.ToDecimal(gridView1.GetRowCellValue(row, colAylikMaas).ToString()),
                        PrimOrani = Convert.ToDecimal(gridView1.GetRowCellValue(row, colPrimOrani).ToString()),
                        ToplamSatis = Convert.ToDecimal(gridView1.GetRowCellValue(row, colToplamSatis).ToString())
                    });
                }
                secildi = true;
                this.Close();
            }
            else
                MessageBox.Show("Seçili Bir Personel Bulunmadı.");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
