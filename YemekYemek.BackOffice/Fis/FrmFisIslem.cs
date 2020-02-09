using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using YemekYemek.BackOffice.Cari;
using YemekYemek.BackOffice.Depo;
using YemekYemek.BackOffice.Genel;
using YemekYemek.BackOffice.Kasa;
using YemekYemek.BackOffice.Personel;
using YemekYemek.BackOffice.Stok;
using YemekYemek.Entities.DataAccess;
using YemekYemek.Entities.Tables;
using YemekYemek.Entities.Tables.OtherTables;
using YemekYemek.Entities.Tools;
using static YemekYemek.Entities.Tools.RsTools;

namespace YemekYemek.BackOffice.Fis
{
    public partial class FrmFisIslem : XtraForm
    {
        public bool saved = false;
        private Entities.Context.YemekYemekContext context = new Entities.Context.YemekYemekContext();
        private FisDAL fisdal = new FisDAL();
        private StokHareketDAL stokhareketdal = new StokHareketDAL();
        private KasaHareketDAL kasahareketdal = new KasaHareketDAL();
        private PersonelHareketDAL personelhareketdal = new PersonelHareketDAL();
        private Entities.Tables.Fis _fisentity = new Entities.Tables.Fis();
        private CariDAL caridal = new CariDAL();
        private CariBakiye entitybakiye = new CariBakiye();
        FisAyarlari ayarlar = new FisAyarlari();
        public enum Nerden { Kasa = 0, Stok = 1, Personel = 2 }

        public FrmFisIslem(string fiskodu = null, Nerden nereye = Nerden.Kasa, string fisturu = null)
        {
            InitializeComponent();
            if (nereye == Nerden.Kasa)
                tabPane2.SelectedPage = tabKasaHareketleri;
            if (nereye == Nerden.Personel)
            {
                tabPane2.SelectedPage = tabPersonelIslem;
            }

            if (fiskodu != null)
            {
                _fisentity = context.Fisler.Where(c => c.FisKodu == fiskodu).SingleOrDefault();
                context.StokHareketleri.Where(c => c.Fiskodu == fiskodu).Load();
                context.KasaHareketleri.Where(c => c.FisKodu == fiskodu).Load();
                context.PersonelHareketler.Where(c => c.FisKodu == fiskodu).Load();
                toggleSwitch1.IsOn = context.KasaHareketleri.Count(c => c.FisKodu == fiskodu && c.Hareket == "Kasa Giriş") == 0;
                if (_fisentity.CariKodu != null)
                {
                    entitybakiye = caridal.CariBakiyesi(context, _fisentity.CariKodu);
                    lblAlacak.Text = entitybakiye.Alacak.ToString("C2");
                    lblBorc.Text = entitybakiye.Borc.ToString("C2");
                    lblBakiye.Text = entitybakiye.Bakiye.ToString("C2");
                }
            }
            else
            {
                _fisentity.FisTuru = fisturu;
                _fisentity.Tarih = DateTime.Now;
            }

            txtFisKodu.DataBindings.Add("Text", _fisentity, "FisKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFisTuru.DataBindings.Add("Text", _fisentity, "FisTuru", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTarih.DataBindings.Add("EditValue", _fisentity, "Tarih", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBelgeNo.DataBindings.Add("Text", _fisentity, "BelgeNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _fisentity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCariAdi14.DataBindings.Add("Text", _fisentity, "CariAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCariKodu.DataBindings.Add("Text", _fisentity, "CariKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFaturaUnvan.DataBindings.Add("Text", _fisentity, "FaturaUnvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCepTelefon.DataBindings.Add("Text", _fisentity, "CepTelefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtil.DataBindings.Add("Text", _fisentity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtilce.DataBindings.Add("Text", _fisentity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _fisentity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiDairesi.DataBindings.Add("Text", _fisentity, "VergiDairesi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNo.DataBindings.Add("Text", _fisentity, "VergiNo", false, DataSourceUpdateMode.OnPropertyChanged);
            gridConStokHareket.DataSource = context.StokHareketleri.Local.ToBindingList();
            gridConKasaHareket.DataSource = context.KasaHareketleri.Local.ToBindingList();
            gridConPersonelHareket.DataSource = context.PersonelHareketler.Local.ToBindingList();
            cmbAy.Month = DateTime.Now.Month;
            for (int i = DateTime.Now.Year -2; i <= DateTime.Now.Year +2; i++)
            {
                cmbYil.Properties.Items.Add(i);
            }
            cmbYil.Text = DateTime.Now.Year.ToString();
            toplamlar();
            FisAyar();
            gridView2.UpdateSummary();
            gridView2.UpdateTotalSummary();
            txtOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            txtOdenmesiGereken.Value = txtToplam.Value - txtOdenenTutar.Value;
            foreach (var item in context.OdemeTurleri.ToList())
            {
                var buton = new SimpleButton
                {
                    Name = item.OdemeTuruKodu,
                    Text = item.OdemeTuruAdi,
                    Height = 28,
                    Width = 144,
                };
                buton.Click += OdemeEkle_Click;
                FlowOdemeTurleri.Controls.Add(buton);
            }
            foreach (var item in context.Personeller.ToList())
            {
                var buton = new CheckButton
                {
                    Name = item.PersonelKodu,
                    Text = item.PersonelAdi + " " + item.PersonelSoyAdi,
                    GroupIndex = 1,
                    Height = 28,
                    Width = 144,
                    Checked = item.PersonelKodu == _fisentity.PersonelKodu
            };
                buton.Click += PersonelEkle_Click;
                flowPersonel.Controls.Add(buton);
            }
        }
        private void PersonelEkle_Click(object sender, EventArgs e)
        {
            var buton = sender as CheckButton;
            _fisentity.PersonelKodu = buton.Name;
            _fisentity.PersonelAdi = buton.Text;
            buton.ImageOptions.ImageList = imageList1;
            buton.ImageOptions.ImageIndex = 0;
            buton.Tag = "fotosu";
        }

        private void FisAyar()
        {
            switch (_fisentity.FisTuru)
            {
                case "Alış Faturası":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    lblBaslik.Text = "Alış Faturası";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    tabPersonelIslem.Dispose();
                    //lblBaslik.Appearance.ImageIndex = -1;
                    break;

                case "Satış Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    lblBaslik.Text = "Satış Faturası";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    tabPersonelIslem.Dispose();
                    break;

                case "Toptan Satış Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    lblBaslik.Text = "Toptan Satış Faturası";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    tabPersonelIslem.Dispose();
                    break;
                case "Alış İade Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    lblBaslik.Text = "Alış İade Faturası";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    tabPersonelIslem.Dispose();
                    break;

                case "Satış İade Faturası":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    lblBaslik.Text = "Satış İade Faturası";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    tabPersonelIslem.Dispose();
                    break;
                case "Sayım Fazlası Fişi":
                    ayarlar.StokHareketi = "Stok Giriş";
                    lblBaslik.Text = "Sayım Fazlası Fişi";
                    navCariBilgi.Dispose();
                    PanelOdeme.Visible = false;
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    tabPersonelIslem.Dispose();
                    tabKasaHareketleri.Dispose();
                    break;
                case "Sayım Eksiği Fişi":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    navCariBilgi.Dispose();
                    lblBaslik.Text = "Sayım Eksiği Fişi";
                    ayarlar.OdemeEkrani = false;
                    PanelOdeme.Visible = false;
                    ayarlar.SatisEkrani = true;
                    tabKasaHareketleri.Dispose();
                    tabPersonelIslem.Dispose();
                    break;
                case "Stok Devir Fişi":
                    navCariBilgi.Dispose();
                    ayarlar.StokHareketi = "Stok Giriş";
                    lblBaslik.Text = "Stok Devir Fişi";
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    PanelOdeme.Visible = false;
                    tabKasaHareketleri.Dispose();
                    tabPersonelIslem.Dispose();
                    break;
                case "Tahsilat Fişi":
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    PanelOdeme.Visible = false;
                    paneliskonto.Visible = false;
                    panelkdv.Visible = false;
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    tabStokHareketleri.Dispose();
                    tabKasaHareketleri.Show();
                    tabPersonelIslem.Dispose();
                    break;
                case "Ödeme Fişi":
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    PanelOdeme.Visible = false;
                    paneliskonto.Visible = false;
                    panelkdv.Visible = false;
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    tabStokHareketleri.Dispose();
                    tabKasaHareketleri.Show();
                    tabPersonelIslem.Dispose();
                    break;
                //daha sınra bakacm
                case "Cari Devir Fişi":
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    PanelOdeme.Visible = false;
                    paneliskonto.Visible = false;
                    panelkdv.Visible = false;
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    panelCariDevir.Visible = true;
                    tabKasaHareketleri.Show();
                    tabStokHareketleri.Dispose();
                    tabPersonelIslem.Dispose();
                    break;
                //case FaturaTipiCons.AlisFaturasi:
                //    ayarlar.StokHareketi = "Stok Çıkış";
                //    ayarlar.KasaHareketi = "Kasa Giriş";
                //    break;
                case "Hakediş Fişi":
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    PanelOdeme.Visible = true;
                    paneliskonto.Visible = false;
                    panelkdv.Visible = false;
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    panelCariDevir.Visible = false;
                    tabPersonelIslem.Show();
                    navCariBilgi.Dispose();
                    //navFisBilgi.Dispose();
                    navPersonelBilgi.Dispose();
                    tabStokHareketleri.Dispose();
                    lblBaslik.Text = "Hakediş Fişi";

                    break;
            }
        }


        private void OdemeEkle_Click(object sender, EventArgs e)
        {
            var buton = (sender as SimpleButton);
            if (ayarlar.SatisEkrani == false && _fisentity.FisTuru != "Hakediş Fişi")
            {
                FrmOdemeEkrani frm = new FrmOdemeEkrani(buton.Text, buton.Name);
                frm.ShowDialog();
                if (frm.entity != null)
                {
                    
                    kasahareketdal.AddOrUpdate(context, frm.entity);
                    OdenenTutarGuncelle();
                    //toplamlar();
                    gridView2.UpdateSummary();
                    gridView2.UpdateTotalSummary();
                    txtOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
                    txtOdenmesiGereken.Value = txtToplam.Value - txtOdenenTutar.Value;
                }
            }
            else
            {
                if (txtOdenmesiGereken.Value <= 0)
                {
                    MessageBox.Show("Ödenmesi Gereken Bir Tutar Yok");
                }
                else
                {
                    if (txtFisTuru.Text != "Hakediş Fişi")
                    {
                        KasaHareket entityKasahareket = new KasaHareket
                        {
                            OdemeTuruKodu = buton.Name,
                            OdemeTuruAdi = buton.Text,
                            Tutar = txtOdenmesiGereken.Value

                        };
                        {
                            kasahareketdal.AddOrUpdate(context, entityKasahareket);
                            gridView2.UpdateSummary();
                            gridView2.UpdateTotalSummary();
                            txtOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
                            txtOdenmesiGereken.Value = txtToplam.Value - txtOdenenTutar.Value;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < gridPersonelHareket.RowCount; i++)
                        {
                            KasaHareket entityKasahareket = new KasaHareket
                            {
                                CariKodu = gridPersonelHareket.GetRowCellValue(i, colPersonelKodu).ToString(),
                                CariAdi = gridPersonelHareket.GetRowCellValue(i, colPersonelAdi).ToString(),
                                OdemeTuruKodu = buton.Name,
                                OdemeTuruAdi = buton.Text,
                                Tutar =(decimal) gridPersonelHareket.GetRowCellValue(i, colOdenecekTutar),
                                Aciklama = $"{gridPersonelHareket.GetRowCellValue(i, colPersonelKodu).ToString()} - {gridPersonelHareket.GetRowCellValue(i, colPersonelAdi).ToString()} Aylık Maaş : {Convert.ToDecimal(gridPersonelHareket.GetRowCellValue(i, colAylikMaas)).ToString("C2")} || Prim Tutarı : {Convert.ToDecimal(gridPersonelHareket.GetRowCellValue(i, colPrimTutari)).ToString("C2")}"

                            };
                            {
                                kasahareketdal.AddOrUpdate(context, entityKasahareket);
                            }
                        }
                        gridView2.UpdateSummary();
                        gridView2.UpdateTotalSummary();
                        txtOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
                        txtOdenmesiGereken.Value = txtToplam.Value - txtOdenenTutar.Value;
                    }

                }
                KasaSecildi();
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount != 0)
            {
                if (MessageBox.Show("Satış Ekranına Eklenmiş Ürünler var Yinede Çıkmak İstiyormusunuz.", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
                this.Close();
        }
        private void OdenenTutarGuncelle()
        {
            gridView2.UpdateSummary();
            gridView2.UpdateTotalSummary();
            if (ayarlar.SatisEkrani || txtFisTuru.Text == "Hakediş Fişi")
            {
                txtOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
                txtOdenmesiGereken.Value = txtToplam.Value - txtOdenenTutar.Value;
            }
            else
            {
                txtToplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            }
        }
        private void FrmFisIslem_Load(object sender, EventArgs e)
        {

        }

        private StokHareket StokSec(Entities.Tables.Stok entity)
        {
            StokHareket stokhareket = new StokHareket();
            IndirimDAL indirimdal = new IndirimDAL();
            stokhareket.StokKodu = entity.StokKodu;
            stokhareket.StokAdi = entity.StokAdi;
            stokhareket.Barkod = entity.Barkod;
            stokhareket.BarkodTuru = entity.BarkodTuru;
            stokhareket.DepoKodu = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo);
            //stokhareket.DepoAdi = context.Depolar.SingleOrDefault(c => c.DepoKodu == stokhareket.DepoKodu).DepoAdi;
            stokhareket.DepoAdi = context.Depolar.SingleOrDefault(c => c.DepoKodu == stokhareket.DepoKodu).DepoAdi;
            stokhareket.BirimFiyati = txtFisTuru.Text == "Alış Faturası" ? entity.AlisFiyati : entity.SatisFiyati;
            stokhareket.Birimi = entity.Birimi;
            stokhareket.Kdv = entity.SatisKdv;
            stokhareket.Miktari = txtMiktar.Value;
            stokhareket.IndirimOrani = indirimdal.StokIndirimi(context, entity.StokKodu);
            return stokhareket;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmStokSec frm = new FrmStokSec();
            frm.ShowDialog();
            if (frm.secildi)
                stokhareketdal.AddOrUpdate(context, StokSec(frm._Secilen.First()));
            toplamlar();
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Entities.Tables.Stok entity = new Entities.Tables.Stok();
                entity = context.Stoklar.Where(c => c.Barkod == txtBarkod.Text).SingleOrDefault();
                if (entity != null)
                {
                    stokhareketdal.AddOrUpdate(context, StokSec(entity));
                    toplamlar();
                }
                else
                    MessageBox.Show("Aradığınız Barkod Numarası Ürünler Arasında Bulunamadı.");
                txtBarkod.Text = null;
            }
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            carisec();
        }

        private void carisec()
        {
            FrmCariSec frm = new FrmCariSec();
            frm.ShowDialog();
            if (frm.secildi)
            {
                Entities.Tables.Cari entity = frm._Secilen.FirstOrDefault();
                entitybakiye = caridal.CariBakiyesi(context, entity.CariKodu);
                txtCariKodu.Text = entity.CariKodu;
                txtCariAdi14.Text = entity.CariAdi;
                txtFaturaUnvan.Text = entity.FaturaUnvani;
                txtVergiDairesi.Text = entity.VergiDairesi;
                txtVergiNo.Text = entity.VergiNumarasi;
                txtCepTelefon.Text = entity.CepTelefonu;
                txtil.Text = entity.Il;
                txtilce.Text = entity.Ilce;
                txtAdres.Text = entity.Adres;
                txtAciklama.Text = entity.Aciklama;
                lblAlacak.Text = entitybakiye.Alacak.ToString("C2");
                lblBorc.Text = entitybakiye.Borc.ToString("C2");
                lblBakiye.Text = entitybakiye.Bakiye.ToString("C2");
                txtCariTuru.Text = entity.CariTuru;
                groupControl1.Enabled = true;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtCariKodu.Text = null;
            txtCariAdi14.Text = null;
            txtFaturaUnvan.Text = null;
            txtVergiDairesi.Text = null;
            txtVergiNo.Text = null;
            txtCepTelefon.Text = null;
            txtil.Text = null;
            txtilce.Text = null;
            txtAdres.Text = null;
            txtAciklama.Text = null;
            lblAlacak.Text = "Görüntülenemiyor.";
            lblBorc.Text = "Görüntülenemiyor.";
            lblBakiye.Text = "Görüntülenemiyor.";
            groupControl1.Enabled = false;
        }

        private void txtCariKodu_Click(object sender, EventArgs e)
        {
            carisec();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            toplamlar();
        }
        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            toplamlar();
        }

        private void toplamlar()
        {
            gridView1.UpdateSummary();
            gridView1.UpdateTotalSummary();
            txtIskontoTutari.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) / 100 * txtIskontoOrani.Value;
            if (_fisentity.FisTuru == "Hakediş Fişi")
            {
                txtToplam.Value = Convert.ToDecimal(colOdenecekTutar.SummaryItem.SummaryValue);
            }
            else
            {
                txtToplam.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) - txtIskontoTutari.Value;
            }
            txtKdvToplam.Value = Convert.ToDecimal(colToplamKdv.SummaryItem.SummaryValue);
            txtIndirimToplam.Value = Convert.ToDecimal(colIndirimTutar.SummaryItem.SummaryValue);
            txtOdenmesiGereken.Value = txtToplam.Value - txtOdenenTutar.Value;
        }

        private void txtIskontoOrani_Validating(object sender, CancelEventArgs e)
        {
            toplamlar();
        }

        private void repoDepoSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmDepoSec frm = new FrmDepoSec(gridView1.GetFocusedRowCellValue(colStokKodu).ToString());
            frm.ShowDialog();
            if (frm.secildi)
            {
                gridView1.SetFocusedRowCellValue(colDepoAdi, frm.entity.DepoAdi);
                gridView1.SetFocusedRowCellValue(colDepoKodu, frm.entity.DepoKodu);
            }
        }

        private void repoBirimFiyatSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string fiyatsecilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            Entities.Tables.Stok fiyatentity = context.Stoklar.Where(c => c.StokKodu == fiyatsecilen).SingleOrDefault();

            barFiyat1.Tag = txtFisTuru.Text == "Alış Faturası" ? fiyatentity.AlisFiyati ?? 0 : fiyatentity.SatisFiyati ?? 0;
            barFiyat2.Tag = txtFisTuru.Text == "Alış Faturası" ? fiyatentity.AlisFiyati2 ?? 0 : fiyatentity.SatisFiyati2 ?? 0;
            barFiyat3.Tag = txtFisTuru.Text == "Alış Faturası" ? fiyatentity.AlisFiyati3 ?? 0 : fiyatentity.SatisFiyati3 ?? 0;
            barFiyat1.Caption = string.Format("{0:C2}", barFiyat1.Tag);
            barFiyat2.Caption = string.Format("{0:C2}", barFiyat2.Tag);
            barFiyat3.Caption = string.Format("{0:C2}", barFiyat3.Tag);
            radialFiyat.ShowPopup(MousePosition);
        }

        private void FiyatSec(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.SetFocusedRowCellValue(colBirimFiyati, Convert.ToDecimal(e.Item.Tag));
        }

        private void repoSeriNO_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri = Convert.ToString(gridView1.GetFocusedRowCellValue(colSeriNo));
            FrmSeriNoGir frm = new FrmSeriNoGir(veri);
            frm.ShowDialog();
            gridView1.SetFocusedRowCellValue(colSeriNo, frm.VeriSeriNo);
        }

        private void repoSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz.?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                toplamlar();
            }
        }
        void KasaSecildi()
        {
            KasaHareket kasadal = new KasaHareket();
            kasadal.KasaKodu = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa);
            kasadal.KasaAdi = context.Kasalar.SingleOrDefault(c => c.KasaKodu == kasadal.KasaKodu).KasaAdi;
            gridView2.SetFocusedRowCellValue(colKasaKodu, kasadal.KasaKodu);
            gridView2.SetFocusedRowCellValue(colKasaAdi, kasadal.KasaAdi);
        }
        private void repoKasa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmKasaSec frm = new FrmKasaSec();
            frm.ShowDialog();
            if (frm.secildi)
            {
                gridView2.SetFocusedRowCellValue(colKasaKodu, frm.entity.KasaKodu);
                gridView2.SetFocusedRowCellValue(colKasaAdi, frm.entity.KasaAdi);
            }
        }

        private void repoKHSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz.?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridView2.DeleteSelectedRows();
                gridView2.UpdateSummary();
                gridView2.UpdateTotalSummary();
                txtOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
                txtOdenmesiGereken.Value = txtToplam.Value - txtOdenenTutar.Value;
                toplamlar();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn)
                ayarlar.KasaHareketi = "Kasa Çıkış";
            else
                ayarlar.KasaHareketi = "Kasa Giriş";

            int stokhata = context.StokHareketleri.Local.Where(c => c.DepoKodu == null).Count();
            int kasahata = context.KasaHareketleri.Local.Where(c => c.KasaKodu == null).Count();
            string message = null;
            int hata = 0;
            if (gridView1.RowCount == 0 && ayarlar.SatisEkrani == true)
            {
                message += "- Satış Ekranında Eklenmiş Ürün Bulunamadı." + System.Environment.NewLine;
                hata++;
            }
            if (_fisentity.CariKodu == null && ayarlar.SatisEkrani == false && _fisentity.FisTuru != "Hakediş Fişi")
            {
                message += "- " + txtFisTuru.Text + " Türünde Cari Seçimi Zorunludur." + System.Environment.NewLine;
                hata++;
            }
            if (ayarlar.SatisEkrani == false && gridView2.RowCount == 0)
            {
                message += "- Herhangi Bir Ödeme Bulunamadı." + System.Environment.NewLine;
                hata++;
            }
            if (string.IsNullOrEmpty(txtFisKodu.Text))
            {
                message += "- Fiş Kodu Boş Geçilemez." + System.Environment.NewLine;
                hata++;
            }
            if (string.IsNullOrEmpty(_fisentity.CariKodu) && string.IsNullOrEmpty(txtCariAdi14.Text) && _fisentity.FisTuru != "Hakediş Fişi")
            {
                message += "- Cari Kodu ve Adı Boş Geçilemez." + System.Environment.NewLine;
                hata++;
            }
            if (txtOdenmesiGereken.Value != 0 && ayarlar.OdemeEkrani == true)
            {
                message += "- Ödenmesi Gereken Tutar Ödenmemiş Görünüyor." + System.Environment.NewLine;
                hata++;
            }
            if (stokhata != 0)
            {
                message += "- Satış Ekranındaki Ürünlerin Depo Seçimi Yapın." + System.Environment.NewLine;
                hata++;
            }
            if (kasahata != 0)
            {
                message += "- Ödeme Ekranındaki Ürünlerin Kasa Seçimi Yapın.";
                hata++;
            }
            if (hata != 0)
            {
                MessageBox.Show(message);
                return;
            }
            if (stokhata == 0 && kasahata == 0)
            {
                foreach (var stokVeri in context.StokHareketleri.Local.ToList())
                {
                    stokVeri.Tarih = stokVeri.Tarih == null
                        ? Convert.ToDateTime(txtTarih.DateTime)
                        : Convert.ToDateTime(stokVeri.Tarih);
                    stokVeri.Fiskodu = txtFisKodu.Text;
                    stokVeri.Hareket = ayarlar.StokHareketi;
                }
                foreach (var item in context.PersonelHareketler.Local.ToList())
                {
                    item.FisKodu = txtFisKodu.Text;
                }
                if (ayarlar.OdemeEkrani)
                {
                    foreach (var kasaVeri in context.KasaHareketleri.Local.ToList())
                    {
                        kasaVeri.Tarih = kasaVeri.Tarih == null
                            ? Convert.ToDateTime(txtTarih.DateTime)
                            : Convert.ToDateTime(kasaVeri.Tarih);
                        if (_fisentity.FisTuru != "Hakediş Fişi")
                        {
                            kasaVeri.CariAdi = txtCariAdi14.Text;
                            kasaVeri.CariKodu = txtCariKodu.Text;
                        }
                        kasaVeri.FisKodu = txtFisKodu.Text;
                        kasaVeri.Hareket = ayarlar.KasaHareketi;
                    }

                }
                _fisentity.ToplamTutar = txtToplam.Value;
                _fisentity.CariTuru = txtCariTuru.Text;
                _fisentity.IskontoOrani = txtIskontoOrani.Value;
                _fisentity.IskontoTutar = txtIskontoTutari.Value;
                fisdal.AddOrUpdate(context, _fisentity);
                context.SaveChanges();
                SplashScreenManager.ShowForm(this, typeof(WaitKayededildi), true, true, false);
                try
                {
                    Thread.Sleep(1000);
                    saved = true;
                }
                finally
                {
                    SplashScreenManager.CloseForm(false);
                    this.Close();
                }
            }
            else
                MessageBox.Show("hata var");
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            
        }

        private void btnPersonelBul_Click(object sender, EventArgs e)
        {
            DateTime time = new DateTime(Convert.ToInt32(cmbYil.Text), cmbAy.Month, 1);
            FrmPersonelSec frm = new FrmPersonelSec(time);
            frm.ShowDialog();
            if (frm.secildi)
            {
                foreach (var item in frm._Secilen.ToList())
                {
                    if (context.PersonelHareketler.Local.Count(c=> c.Donemi == time && c.PersonelKodu == item.PersonelKodu) == 0)
                        personelhareketdal.AddOrUpdate(context, item);
                }
                toplamlar();
            }
        }
    }
}