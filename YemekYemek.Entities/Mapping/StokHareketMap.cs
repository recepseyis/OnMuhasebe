using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using YemekYemek.Entities.Tables;

namespace YemekYemek.Entities.Mapping
{
    public class StokHareketMap : EntityTypeConfiguration<StokHareket>
    {
        public StokHareketMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Fiskodu).HasMaxLength(50);
            this.Property(p => p.Hareket).HasMaxLength(50);
            this.Property(p => p.StokKodu).HasMaxLength(50);
            this.Property(p => p.StokAdi).HasMaxLength(50);
            this.Property(p => p.Barkod).HasMaxLength(50);
            this.Property(p => p.BarkodTuru).HasMaxLength(50);
            this.Property(p => p.Birimi).HasMaxLength(50);
            this.Property(p => p.BirimFiyati).HasPrecision(12, 2);
            this.Property(p => p.Miktari).HasPrecision(12, 2);
            this.Property(p => p.Kdv);
            this.Property(p => p.IndirimOrani).HasPrecision(12, 2);
            //this.Property(p => p.IndırımTutari).HasPrecision(12, 2);
            //this.Property(p => p.ToplamTutar).HasPrecision(12, 2);
            this.Property(p => p.DepoAdi).HasMaxLength(50);
            this.Property(p => p.DepoKodu).HasMaxLength(50);
            this.Property(p => p.SeriNo).HasMaxLength(50);
            this.Property(p => p.Tarih);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("StokHareketler");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Fiskodu).HasColumnName("FisKodu");
            this.Property(p => p.Hareket).HasColumnName("Hareket");
            this.Property(p => p.StokKodu).HasColumnName("StokKodu");
            this.Property(p => p.StokAdi).HasColumnName("StokAdi");
            this.Property(p => p.Barkod).HasColumnName("Barkod");
            this.Property(p => p.BarkodTuru).HasColumnName("BarkodTuru");
            this.Property(p => p.Birimi).HasColumnName("Birimi");
            this.Property(p => p.BirimFiyati).HasColumnName("BirimFiyati");
            this.Property(p => p.Miktari).HasColumnName("Miktari");
            this.Property(p => p.Kdv).HasColumnName("Kdv");
            this.Property(p => p.IndirimOrani).HasColumnName("IndirimOrani");
            //this.Property(p => p.IndırımTutari).HasColumnName("IndırımTutari");
            //this.Property(p => p.ToplamTutar).HasColumnName("ToplamTutar");
            this.Property(p => p.DepoAdi).HasColumnName("DepoAdi");
            this.Property(p => p.DepoKodu).HasColumnName("DepoKodu");
            this.Property(p => p.SeriNo).HasColumnName("SeriNo");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}