using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using YemekYemek.Entities.Tables;

namespace YemekYemek.Entities.Mapping
{
    public class StokMap : EntityTypeConfiguration<Stok>
    {
        public StokMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.StokKodu).HasMaxLength(50);
            this.Property(p => p.StokAltGrubu).HasMaxLength(50);
            this.Property(p => p.Barkod).HasMaxLength(50);
            this.Property(p => p.BarkodTuru).HasMaxLength(50);
            this.Property(p => p.Birimi).HasMaxLength(50);
            this.Property(p => p.StokGrubu).HasMaxLength(50);
            this.Property(p => p.StokAdi).HasMaxLength(50);
            this.Property(p => p.Marka).HasMaxLength(50);
            this.Property(p => p.Modeli).HasMaxLength(50);
            this.Property(p => p.OzelKod1).HasMaxLength(50);
            this.Property(p => p.OzelKod2).HasMaxLength(50);
            this.Property(p => p.OzelKod3).HasMaxLength(50);
            this.Property(p => p.OzelKod4).HasMaxLength(50);
            this.Property(p => p.GarantiSuresi).HasMaxLength(50);
            this.Property(p => p.UreticiKodu).HasMaxLength(50);
            this.Property(p => p.AlisFiyati).HasPrecision(12, 2);
            this.Property(p => p.AlisFiyati2).HasPrecision(12, 2);
            this.Property(p => p.AlisFiyati3).HasPrecision(12, 2);
            this.Property(p => p.SatisFiyati).HasPrecision(12, 2);
            this.Property(p => p.SatisFiyati2).HasPrecision(12, 2);
            this.Property(p => p.SatisFiyati3).HasPrecision(12, 2);
            this.Property(p => p.MinStokMiktari).HasPrecision(12, 3);
            this.Property(p => p.MaxStokMiktari).HasPrecision(12, 3);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("Stoklar");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.StokKodu).HasColumnName("StokKodu");
            this.Property(p => p.StokAltGrubu).HasColumnName("StokAltGrubu");
            this.Property(p => p.Barkod).HasColumnName("Barkod");
            this.Property(p => p.BarkodTuru).HasColumnName("BarkodTuru");
            this.Property(p => p.Birimi).HasColumnName("Birimi");
            this.Property(p => p.StokGrubu).HasColumnName("StokGrubu");
            this.Property(p => p.StokAdi).HasColumnName("StokAdı");
            this.Property(p => p.Marka).HasColumnName("Marka");
            this.Property(p => p.Modeli).HasColumnName("Modeli");
            this.Property(p => p.OzelKod1).HasColumnName("OzelKod1");
            this.Property(p => p.OzelKod2).HasColumnName("OzelKod2");
            this.Property(p => p.OzelKod3).HasColumnName("OzelKod3");
            this.Property(p => p.OzelKod4).HasColumnName("OzelKod4");
            this.Property(p => p.GarantiSuresi).HasColumnName("GarantiSuresi");
            this.Property(p => p.UreticiKodu).HasColumnName("UreticiKodu");
            this.Property(p => p.AlisFiyati).HasColumnName("AlisFiyati");
            this.Property(p => p.AlisFiyati2).HasColumnName("AlisFiyati2");
            this.Property(p => p.AlisFiyati3).HasColumnName("AlisFiyati3");
            this.Property(p => p.SatisFiyati).HasColumnName("SatisFiyati");
            this.Property(p => p.SatisFiyati2).HasColumnName("SatisFiyati2");
            this.Property(p => p.SatisFiyati3).HasColumnName("SatisFiyati3");
            this.Property(p => p.MinStokMiktari).HasColumnName("MinStokMiktari");
            this.Property(p => p.MaxStokMiktari).HasColumnName("MaxStokMiktari");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
            this.Property(p => p.AlisKdv).HasColumnName("AlisKdv");
            this.Property(p => p.SatisKdv).HasColumnName("SatisKdv");
        }
    }
}