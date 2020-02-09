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

namespace YemekYemek.Admin
{
    public partial class FrmParolaHatirlat : XtraForm
    {
        Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        Entities.Tables.Kullanici _entity;
        KullaniciDAL kullanicidal = new KullaniciDAL();
        public FrmParolaHatirlat(string kullaniciadi)
        {
            InitializeComponent();
            _entity = context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == kullaniciadi);
            txtHatirlatmaSorusu.Text = _entity.HatirlatmaSorusu;
        }

        private void FrmParolaHatirlat_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (_entity.Cevap == txtCevap.Text)
            {
                _entity.Parola = txtSifre.Text;
                kullanicidal.AddOrUpdate(context, _entity);
                context.SaveChanges();
                MessageBox.Show("Şifre Değişti.");
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
