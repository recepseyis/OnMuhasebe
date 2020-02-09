using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using YemekYemek.Entities.Tables;

namespace YemekYemek.Entities.Mapping
{
    public class KasaHareketMap : EntityTypeConfiguration<KasaHareket>
    {
        public KasaHareketMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(50);
            this.Property(p => p.Hareket).HasMaxLength(50);
            this.Property(p => p.KasaKodu).HasMaxLength(50);
            this.Property(p => p.KasaAdi).HasMaxLength(50);
            this.Property(p => p.OdemeTuruKodu).HasMaxLength(50);
            this.Property(p => p.OdemeTuruAdi).HasMaxLength(50);
            this.Property(p => p.CariKodu).HasMaxLength(50);
            this.Property(p => p.CariAdi).HasMaxLength(50);
            this.Property(p => p.Tarih);
            this.Property(p => p.Tutar).HasPrecision(12, 2);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("KasaHareketler");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.Hareket).HasColumnName("Hareket");
            this.Property(p => p.KasaKodu).HasColumnName("KasaKodu");
            this.Property(p => p.KasaAdi).HasColumnName("KasaAdi");
            this.Property(p => p.OdemeTuruKodu).HasColumnName("OdemeTuruKodu");
            this.Property(p => p.OdemeTuruAdi).HasColumnName("OdemeTuruAdi");
            this.Property(p => p.CariKodu).HasColumnName("CariKodu");
            this.Property(p => p.CariAdi).HasColumnName("CariAdi");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.Tutar).HasColumnName("Tutar");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}