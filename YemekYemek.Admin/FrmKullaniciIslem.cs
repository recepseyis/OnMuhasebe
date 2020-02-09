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
    public partial class FrmKullaniciIslem : XtraForm
    {
        Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private Entities.Tables.Kullanici _entity;
        KullaniciDAL kullanicidal = new KullaniciDAL();
        public bool saved = false;
        private string parola, cevap;
        public FrmKullaniciIslem(Entities.Tables.Kullanici entity)
        {
            InitializeComponent();
            if (entity != null)
            {
                parola = entity.Parola;
                cevap = entity.Cevap;
                entity.Cevap = null;
                entity.Parola = null;
            }
            _entity = entity;
            txtKullaniciAdi.DataBindings.Add("Text", _entity, "KullaniciAdi", false, DataSourceUpdateMode.OnPropertyChanged);

            txtSifre.DataBindings.Add("Text", _entity, "Parola", false, DataSourceUpdateMode.OnPropertyChanged);

            txtAdi.DataBindings.Add("Text", _entity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSoyadi.DataBindings.Add("Text", _entity, "Soyadi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtGorevi.DataBindings.Add("Text", _entity, "Gorevi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtHatirlatmaSorusu.DataBindings.Add("Text", _entity, "HatirlatmaSorusu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCevap.DataBindings.Add("Text", _entity, "Cevap", false, DataSourceUpdateMode.OnPropertyChanged);
            AyarYukle();
        }

        private void AyarYukle()
        {
            if (!string.IsNullOrEmpty(_entity.KullaniciAdi))
            {
                foreach (var item in context.KullaniciRoller.Where(c => c.KullaniciAdi == _entity.KullaniciAdi).ToList())
                {
                    treeList1.SetNodeCheckState(treeList1.Nodes[item.RootId].Nodes[item.ParentId], item.Yetki == true ? CheckState.Checked : CheckState.Unchecked, true);
                }
            }
        }

        private void Kaydet()
        {
            for (int i = 0; i < treeList1.Nodes.Count; i++)
            {
                for (int j = 0; j < treeList1.Nodes[i].Nodes.Count; j++)
                {
                    if (context.KullaniciRoller.Count(c => c.KullaniciAdi == txtKullaniciAdi.Text && c.RootId == i && c.ParentId == j) == 0)
                    {
                        context.KullaniciRoller.Add(new Entities.Tables.KullaniciRol
                        {
                            KullaniciAdi = txtKullaniciAdi.Text,
                            FormAdi = treeList1.Nodes[i].GetDisplayText(treeListColumn2),
                            KontrolAdi = treeList1.Nodes[i].Nodes[j].GetDisplayText(treeListColumn2),
                            RootId = i,
                            ParentId = j,
                            Yetki = treeList1.Nodes[i].Nodes[j].Checked
                        });
                    }
                    else
                    {
                        context.KullaniciRoller.SingleOrDefault(c => c.KullaniciAdi == txtKullaniciAdi.Text && c.RootId == i && c.ParentId == j).Yetki = treeList1.Nodes[i].Nodes[j].Checked;
                    }
                }
            }
            context.SaveChanges();
        }

        private void FrmKullaniciIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_entity.Parola))
            {
                txtSifre.Text = parola;
            }
            if (string.IsNullOrEmpty(_entity.Cevap))
            {
                txtCevap.Text = cevap;
            }
            _entity.KayitTarihi = DateTime.Now;
            kullanicidal.AddOrUpdate(context, _entity);
            Kaydet();
            saved = true;
        }
    }
}
