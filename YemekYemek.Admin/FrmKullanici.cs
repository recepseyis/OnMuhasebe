using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YemekYemek.Entities.DataAccess;

namespace YemekYemek.Admin
{
    public partial class FrmKullanici : DevExpress.XtraEditors.XtraForm
    {
        Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        KullaniciDAL kullanicidal = new KullaniciDAL();
        public FrmKullanici()
        {
            InitializeComponent();
            Listele();
            
        }
        private void Listele()
        {
            gridControl1.DataSource = kullanicidal.GetAll(context);
        }

        private void FrmKullanici_Load(object sender, EventArgs e)
        {
            FrmKullaniciGiris frm = new FrmKullaniciGiris();
            frm.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmKullaniciIslem frm = new FrmKullaniciIslem(new Entities.Tables.Kullanici());
            frm.ShowDialog();
        }

        private void grpKontroluMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            string secilen = gridView1.GetFocusedRowCellValue(colKullaniciAdi).ToString();
            FrmKullaniciIslem frm = new FrmKullaniciIslem(kullanicidal.GetByFilter(context, c => c.KullaniciAdi == secilen));
            frm.ShowDialog();
            if (frm.saved)
            {
                Listele();
            }
        }
    }
}
