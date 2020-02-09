using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace YemekYemek.BackOffice.Fis
{
    public partial class FrmSeriNoGir : XtraForm
    {
        public string VeriSeriNo;
        public bool kilitli = true;

        public FrmSeriNoGir(string veri)
        {
            InitializeComponent();
            if (veri != null)
            {
                string[] verilistesi = veri.Split(new[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in verilistesi)
                {
                    listBoxControl1.Items.Add(item);
                }
            }
            if (kilitli)
            {
                txtSeriNo.Enabled = false;
                simpleButton1.Enabled = false;
                listBoxControl1.Enabled = false;
            }
        }

        private void FrmSeriNoGir_Load(object sender, EventArgs e)
        {
            txtSeriNo.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listBoxControl1.Items.Remove(listBoxControl1.SelectedItem);
        }

        private void txtSeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            listBoxControl1.Items.Add(txtSeriNo.Text);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSeriNoGir_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listBoxControl1.Items.Count != 0)
            {
                foreach (var item in listBoxControl1.Items)
                {
                    VeriSeriNo += item + System.Environment.NewLine;
                }
            }
        }

        private void txtSeriNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBoxControl1.Items.Add(txtSeriNo.Text);
                txtSeriNo.Text = null;
                txtSeriNo.Focus();
            }
        }

        private void listBoxControl1_DoubleClick(object sender, EventArgs e)
        {
            listBoxControl1.Items.Remove(listBoxControl1.SelectedItem);
        }
    }
}