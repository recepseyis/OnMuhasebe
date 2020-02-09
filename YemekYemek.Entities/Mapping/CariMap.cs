﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using YemekYemek.Entities.Tables;

namespace YemekYemek.Entities.Mapping
{
    public class CariMap : EntityTypeConfiguration<Cari>
    {
        public CariMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Aciklama).HasMaxLength(200);
            this.Property(p => p.CariKodu).HasMaxLength(50);
            this.Property(p => p.CariTuru).HasMaxLength(50);
            this.Property(p => p.CariAdi).HasMaxLength(100);
            this.Property(p => p.YetkiliKisi).HasMaxLength(50);
            this.Property(p => p.FaturaUnvani).HasMaxLength(100);
            this.Property(p => p.CepTelefonu).HasMaxLength(50);
            this.Property(p => p.Telefon).HasMaxLength(50);
            this.Property(p => p.Fax).HasMaxLength(50);
            this.Property(p => p.Email).HasMaxLength(50);
            this.Property(p => p.Web).HasMaxLength(50);
            this.Property(p => p.Il).HasMaxLength(50);
            this.Property(p => p.Ilce).HasMaxLength(50);
            this.Property(p => p.Semt).HasMaxLength(50);
            this.Property(p => p.Adres).HasMaxLength(200);
            this.Property(p => p.CariGrubu).HasMaxLength(50);
            this.Property(p => p.CariAltGrubu).HasMaxLength(50);
            this.Property(p => p.OzelKod).HasMaxLength(50);
            this.Property(p => p.OzelKod1).HasMaxLength(50);
            this.Property(p => p.OzelKod2).HasMaxLength(50);
            this.Property(p => p.OzelKod3).HasMaxLength(50);
            this.Property(p => p.VergiDairesi).HasMaxLength(50);
            this.Property(p => p.VergiNumarasi).HasMaxLength(50);
            this.Property(p => p.IskontoOrani).HasPrecision(12, 2);
            this.Property(p => p.RiskLimiti).HasPrecision(12, 2);
            this.Property(p => p.AlisOzelFiyati).HasMaxLength(50);
            this.Property(p => p.SatisOzelFiyati).HasMaxLength(50);

            this.ToTable("Cariler");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.CariTuru).HasColumnName("CariTuru");
            this.Property(p => p.CariAdi).HasColumnName("CariAdi");
            this.Property(p => p.CariKodu).HasColumnName("CariKodu");
            this.Property(p => p.YetkiliKisi).HasColumnName("YetkiliKisi");
            this.Property(p => p.FaturaUnvani).HasColumnName("FaturaUnvani");
            this.Property(p => p.CepTelefonu).HasColumnName("CepTelefonu");
            this.Property(p => p.Telefon).HasColumnName("Telefon");
            this.Property(p => p.Fax).HasColumnName("Fax");
            this.Property(p => p.Email).HasColumnName("Email");
            this.Property(p => p.Web).HasColumnName("Web");
            this.Property(p => p.Il).HasColumnName("Il");
            this.Property(p => p.Ilce).HasColumnName("Ilce");
            this.Property(p => p.Semt).HasColumnName("Semt");
            this.Property(p => p.Adres).HasColumnName("Adres");
            this.Property(p => p.CariGrubu).HasColumnName("CariGrubu");
            this.Property(p => p.CariAltGrubu).HasColumnName("CariAltGrubu");
            this.Property(p => p.OzelKod).HasColumnName("OzelKod");
            this.Property(p => p.OzelKod1).HasColumnName("OzelKod1");
            this.Property(p => p.OzelKod2).HasColumnName("OzelKod2");
            this.Property(p => p.OzelKod3).HasColumnName("OzelKod3");
            this.Property(p => p.VergiDairesi).HasColumnName("VergiDairesi");
            this.Property(p => p.VergiNumarasi).HasColumnName("VergiNumarasi");
            this.Property(p => p.IskontoOrani).HasColumnName("IskontoOrani");
            this.Property(p => p.RiskLimiti).HasColumnName("RiskLimiti");
            this.Property(p => p.AlisOzelFiyati).HasColumnName("AlisOzelFiyati");
            this.Property(p => p.SatisOzelFiyati).HasColumnName("SatisOzelFiyati");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}