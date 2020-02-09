using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using YemekYemek.Entities.Tables;

namespace YemekYemek.Entities.Mapping
{
    public class PersonelMap : EntityTypeConfiguration<Personel>
    {
        public PersonelMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Calisiyor);
            this.Property(p => p.Unvani).HasMaxLength(50);
            this.Property(p => p.PersonelKodu).HasMaxLength(50);
            this.Property(p => p.PersonelAdi).HasMaxLength(50);
            this.Property(p => p.PersonelSoyAdi).HasMaxLength(50);
            this.Property(p => p.TcKimlikNo).HasMaxLength(50);
            this.Property(p => p.IseGirisTarihi);
            this.Property(p => p.IstenCikisTarihi);
            this.Property(p => p.Aciklama).HasMaxLength(200);
            this.Property(p => p.CepTelefonu).HasMaxLength(50);
            this.Property(p => p.Email).HasMaxLength(50);
            this.Property(p => p.Adres).HasMaxLength(50);
            this.Property(p => p.VergiNo).HasMaxLength(50);
            this.Property(p => p.PrimOrani).HasPrecision(12, 2);
            this.Property(p => p.AylikMaas).HasPrecision(12, 2);

            this.ToTable("Personeller");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Calisiyor).HasColumnName("Calisiyor");
            this.Property(p => p.Unvani).HasColumnName("Unvani");
            this.Property(p => p.PersonelKodu).HasColumnName("PersonelKodu");
            this.Property(p => p.PersonelAdi).HasColumnName("PersonelAdi");
            this.Property(p => p.PersonelSoyAdi).HasColumnName("PersonelSoyAdi");
            this.Property(p => p.TcKimlikNo).HasColumnName("TcKimlikNo");
            this.Property(p => p.IseGirisTarihi).HasColumnName("IseGirisTarihi");
            this.Property(p => p.IstenCikisTarihi).HasColumnName("IstenCikisTarihi");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
            this.Property(p => p.CepTelefonu).HasColumnName("CepTelefonu");
            this.Property(p => p.Email).HasColumnName("Email");
            this.Property(p => p.Adres).HasColumnName("Adres");
            this.Property(p => p.VergiNo).HasColumnName("VeriNo");
            this.Property(p => p.PrimOrani).HasColumnName("PrimOrani");
            this.Property(p => p.AylikMaas).HasColumnName("AylikMaas");
        }
    }
}