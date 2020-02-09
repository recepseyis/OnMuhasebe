using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using YemekYemek.Entities.Tables;

namespace YemekYemek.Entities.Mapping
{
    public class PersonelAvansMap : EntityTypeConfiguration<PersonelAvans>
    {
        public PersonelAvansMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Tarih);
            this.Property(p => p.OdenenTutar).HasPrecision(12, 2);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("PersonelAvanslar");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.OdenenTutar).HasColumnName("OdenenTutar");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}