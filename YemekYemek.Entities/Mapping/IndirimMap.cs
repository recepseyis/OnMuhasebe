using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using YemekYemek.Entities.Tables;

namespace YemekYemek.Entities.Mapping
{
    public class IndirimMap : EntityTypeConfiguration<Indirim>
    {
        public IndirimMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.StokKodu).HasMaxLength(50);
            this.Property(p => p.StokAdi).HasMaxLength(50);
            this.Property(p => p.Barkod).HasMaxLength(50);
            this.Property(p => p.IndirimTuru).HasMaxLength(50);
            this.Property(p => p.Aciklama).HasMaxLength(200);
            this.Property(p => p.IndirimOrani).HasPrecision(5,2);

            this.ToTable("Indirimler");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.StokAdi).HasColumnName("StokAdi");
            this.Property(p => p.StokKodu).HasColumnName("StokKodu");
            this.Property(p => p.Barkod).HasColumnName("Barkod");
            this.Property(p => p.IndirimTuru).HasColumnName("IndirimTuru");
            this.Property(p => p.IndirimOrani).HasColumnName("IndirimOrani");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
