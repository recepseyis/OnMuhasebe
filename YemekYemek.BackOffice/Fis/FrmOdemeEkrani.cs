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
using YemekYemek.BackOffice.Kasa;
using YemekYemek.Entities.Tables;

namespace YemekYemek.BackOffice.Fis
{
    public partial class FrmOdemeEkrani : XtraForm
    {
        public KasaHareket entity;
        private string _odemeturukodu;
        public FrmOdemeEkrani(string odemeturu,string odemeturukodu)
        {
            InitializeComponent();
            txtOdemeTuru.Text = odemeturu;
            _odemeturukodu = odemeturukodu;
        }

        private void FrmOdemeEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmKasaSec frm = new FrmKasaSec();
            frm.ShowDialog();
            if (frm.secildi)
            {
                txtKasaAdi.Text = frm.entity.KasaAdi;
                txtKasaKodu.Text = frm.entity.KasaKodu;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string message = null;
            int error = 0;
            if (string.IsNullOrEmpty(txtKasaAdi.Text))
            {
                message += "Kasa Bilgileri Eksik."+ System.Environment.NewLine;
                error++;
            }
            if (txtTutar.Value <= 0 )
            {
                message += "Tutar 0 ve 0'dan Küçük Olamaz." + System.Environment.NewLine;
                error++;
            }
            if (error != 0)
            {
                MessageBox.Show(message);
                return;
            }
            entity = new KasaHareket();
            entity.OdemeTuruKodu = _odemeturukodu;
            entity.OdemeTuruAdi = txtOdemeTuru.Text;
            entity.KasaKodu = txtKasaKodu.Text;
            entity.KasaAdi = txtKasaAdi.Text;
            entity.Tutar = txtTutar.Value;
            entity.Aciklama = txtAciklama.Text;
            this.Close();
        }
    }
}
