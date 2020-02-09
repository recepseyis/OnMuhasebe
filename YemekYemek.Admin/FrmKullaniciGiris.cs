using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekYemek.Admin
{
    public partial class FrmKullaniciGiris : XtraForm
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("Gdi32.dll", EntryPoint = "DeleteObject")]
        public static extern bool DeleteObject(IntPtr hObject);

        IntPtr handle;

        Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private bool girisbasarili = false;
        public FrmKullaniciGiris()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            handle = CreateRoundRectRgn(0, 0, Width, Height, 10, 10);
            if (handle != IntPtr.Zero)
                this.Region = System.Drawing.Region.FromHrgn(handle);
        }

        private void FrmKullaniciGiris_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (context.Kullanicilar.Any(c => c.KullaniciAdi == txtKullaniciAdi.Text && c.Parola == txtSifre.Text))
            {
                girisbasarili = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
                txtSifre.Text = null;
            }
        }

        private void FrmKullaniciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!girisbasarili)
            {
                Application.Exit();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (context.Kullanicilar.Any(c => c.KullaniciAdi == txtKullaniciAdi.Text))
            {
                FrmParolaHatirlat frm = new FrmParolaHatirlat(txtKullaniciAdi.Text);
                frm.ShowDialog();
                frm.Close();
            }
            else
            {
                MessageBox.Show("Böyle Bir Kullanıcı Bulunamadı.");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmKullaniciGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (handle != IntPtr.Zero)
                DeleteObject(handle);//Release handle
        }
    }
}
