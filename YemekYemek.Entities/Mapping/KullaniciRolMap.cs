using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using YemekYemek.Entities.Tables;

namespace YemekYemek.Entities.Mapping
{
    public class KullaniciRolMap : EntityTypeConfiguration<KullaniciRol>
    {
        public KullaniciRolMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.RootId);
            this.Property(p => p.ParentId);
            this.Property(p => p.KullaniciAdi).HasMaxLength(50);
            this.Property(p => p.FormAdi).HasMaxLength(50);
            this.Property(p => p.KontrolAdi).HasMaxLength(50);
            this.Property(p => p.Yetki);

            this.ToTable("KullaniciRoller");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.RootId).HasColumnName("RootId");
            this.Property(p => p.ParentId).HasColumnName("ParentId");
            this.Property(p => p.KullaniciAdi).HasColumnName("KullaniciAdi");
            this.Property(p => p.FormAdi).HasColumnName("FormAdi");
            this.Property(p => p.KontrolAdi).HasColumnName("KontrolAdi");
            this.Property(p => p.Yetki).HasColumnName("Yetki");
        }
    }
}
