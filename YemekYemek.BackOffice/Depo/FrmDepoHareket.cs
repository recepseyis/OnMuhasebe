using System;
using System.Drawing;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.BackOffice.Depo
{
    public partial class FrmDepoHareket : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private StokHareketDAL stokHareketdal = new StokHareketDAL();
        private string _depoKodu = null;
        private string _depoAdi = null;

        public FrmDepoHareket(string depoKodu, string depoAdi)
        {
            InitializeComponent();
            _depoKodu = depoKodu;
            _depoAdi = depoAdi;
            lblBaslik.Text = _depoKodu + " " + _depoAdi + " " + "Hareketleri";
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridDepoHareket.OptionsView.ShowAutoFilterRow == true)
                gridDepoHareket.OptionsView.ShowAutoFilterRow = false;
            else
                gridDepoHareket.OptionsView.ShowAutoFilterRow = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guncelle()
        {
            gridConDepoHareket.DataSource = stokHareketdal.GetAll(context, c => c.DepoKodu == _depoKodu);
            gridConDepoStok.DataSource = stokHareketdal.DepoStokListele(context, _depoKodu);
            gridConIstatik.DataSource = stokHareketdal.DepoIstatistikListele(context, _depoKodu);
        }

        private void FrmDepoHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void gridDepoHareket_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column == colHareket)
            {
                var durum = gridDepoHareket.GetRowCellValue(e.RowHandle, colHareket);
                if (durum.ToString() == "Stok Çıkış")
                    e.Appearance.BackColor = Color.Chocolate;
                else
                    e.Appearance.BackColor = Color.LightGreen;
            }
        }
    }
}