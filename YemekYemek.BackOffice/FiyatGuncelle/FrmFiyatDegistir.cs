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
using YemekYemek.Entities.Tables.OtherTables;

namespace YemekYemek.BackOffice.FiyatGuncelle
{
    public partial class FrmFiyatDegistir : XtraForm
    {
        public List<FiyatDegistir> list;
        public bool secildi = false;
        public FrmFiyatDegistir()
        {
            InitializeComponent();
            list = new List<FiyatDegistir>
            {
                new FiyatDegistir
                {
                    FiyatTuru ="Alış Fiyatı",
                    KolonAdi = "AlisFiyati",
                    Degistir = false,
                    DegisimTuru ="Yüzde",
                    DegisimYonu = "Arttır",
                    Degeri = 0
                },
                new FiyatDegistir
                {
                    FiyatTuru ="Alış Fiyatı-2",
                    KolonAdi = "AlisFiyati2",
                    Degistir = false,
                    DegisimTuru ="Yüzde",
                    DegisimYonu = "Arttır",
                    Degeri = 0
                },
                new FiyatDegistir
                {
                    FiyatTuru ="Alış Fiyatı-3",
                    KolonAdi = "AlisFiyati3",
                    Degistir = false,
                    DegisimTuru ="Yüzde",
                    DegisimYonu = "Arttır",
                    Degeri = 0
                },
                new FiyatDegistir
                {
                    FiyatTuru ="Satış Fiyatı",
                    KolonAdi = "SatisFiyati",
                    Degistir = false,
                    DegisimTuru ="Yüzde",
                    DegisimYonu = "Arttır",
                    Degeri = 0
                },
                new FiyatDegistir
                {
                    FiyatTuru ="Satış Fiyatı-2",
                    KolonAdi = "SatisFiyati2",
                    Degistir = false,
                    DegisimTuru ="Yüzde",
                    DegisimYonu = "Arttır",
                    Degeri = 0
                },
                new FiyatDegistir
                {
                    FiyatTuru ="Satış Fiyatı-3",
                    KolonAdi = "SatisFiyati3",
                    Degistir = false,
                    DegisimTuru ="Yüzde",
                    DegisimYonu = "Arttır",
                    Degeri = 0
                },

            };
            gridControl1.DataSource = list;
        }

        private void FrmFiyatDegistir_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            secildi = true;
            this.Close();
        }
    }
}
