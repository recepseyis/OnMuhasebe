using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using YemekYemek.Entities.Tables;

namespace YemekYemek.Entities.Mapping
{
    public class FisMap : EntityTypeConfiguration<Fis>
    {
        public FisMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(50);
            this.Property(p => p.FisTuru).HasMaxLength(50);
            this.Property(p => p.CariTuru).HasMaxLength(50);
            this.Property(p => p.CariKodu).HasMaxLength(50);
            this.Property(p => p.CariAdi).HasMaxLength(50);
            this.Property(p => p.BelgeNo).HasMaxLength(50);
            this.Property(p => p.Tarih);
            //this.Property(p => p.PersonelAdi).HasMaxLength(50);
            this.Property(p => p.PersonelKodu).HasMaxLength(50);
            this.Property(p => p.IskontoOrani).HasPrecision(12, 2);
            this.Property(p => p.IskontoTutar).HasPrecision(12, 2);
            this.Property(p => p.ToplamTutar).HasPrecision(12, 2);
            this.Property(p => p.Aciklama).HasMaxLength(200);
            this.Property(p => p.FaturaUnvani).HasMaxLength(100);
            this.Property(p => p.CepTelefonu).HasMaxLength(15);
            this.Property(p => p.Il).HasMaxLength(50);
            this.Property(p => p.Ilce).HasMaxLength(50);
            this.Property(p => p.Semt).HasMaxLength(50);
            this.Property(p => p.Adres).HasMaxLength(200);
            this.Property(p => p.VergiDairesi).HasMaxLength(50);
            this.Property(p => p.VergiNo).HasMaxLength(50);

            this.ToTable("Fisler");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.FisTuru).HasColumnName("FisTuru");
            this.Property(p => p.CariTuru).HasColumnName("CariTuru");
            this.Property(p => p.CariKodu).HasColumnName("CariKodu");
            this.Property(p => p.CariAdi).HasColumnName("CariAdi");
            this.Property(p => p.BelgeNo).HasColumnName("BelgeNo");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            //this.Property(p => p.PersonelAdi).HasColumnName("PersonelAdi");
            this.Property(p => p.PersonelKodu).HasColumnName("PersonelKodu");
            this.Property(p => p.IskontoOrani).HasColumnName("IskontoOrani");
            this.Property(p => p.IskontoTutar).HasColumnName("IskontoTutar");
            this.Property(p => p.ToplamTutar).HasColumnName("ToplamTutar");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
            this.Property(p => p.FaturaUnvani).HasColumnName("FaturaUnvani");
            this.Property(p => p.CepTelefonu).HasColumnName("CepTelefonu");
            this.Property(p => p.Il).HasColumnName("Il");
            this.Property(p => p.Ilce).HasColumnName("Ilce");
            this.Property(p => p.Semt).HasColumnName("Semt");
            this.Property(p => p.Adres).HasColumnName("Adres");
            this.Property(p => p.VergiDairesi).HasColumnName("VergiDairesi");
            this.Property(p => p.VergiNo).HasColumnName("VergiNo");
        }
    }
}