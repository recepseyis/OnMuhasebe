using System.Data.Entity;
using YemekYemek.Entities.Mapping;
using YemekYemek.Entities.Tables;

namespace YemekYemek.Entities.Context
{
    public class YemekYemekContext : DbContext
    {
        public YemekYemekContext():base ("YemekYemekContext")
        {

        }

        public DbSet<Cari> Cariler { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<Fis> Fisler { get; set; }
        public DbSet<Kasa> Kasalar { get; set; }
        public DbSet<KasaHareket> KasaHareketleri { get; set; }
        public DbSet<OdemeTuru> OdemeTurleri { get; set; }
        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<StokHareket> StokHareketleri { get; set; }
        public DbSet<Tanim> Tanimlar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<PersonelAvans> PersonelAvanslar { get; set; }
        public DbSet<Indirim> Indirimler { get; set; }
        public DbSet<EFAppointment> EFAppointments { get; set; }
        public DbSet<EFResource> EFResources { get; set; }
        public DbSet<PersonelHareket> PersonelHareketler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciRol> KullaniciRoller { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StokMap());
            modelBuilder.Configurations.Add(new CariMap());
            modelBuilder.Configurations.Add(new FisMap());
            modelBuilder.Configurations.Add(new KasaHareketMap());
            modelBuilder.Configurations.Add(new KasaMap());
            modelBuilder.Configurations.Add(new OdemeTuruMap());
            modelBuilder.Configurations.Add(new StokHareketMap());
            modelBuilder.Configurations.Add(new TanimMap());
            modelBuilder.Configurations.Add(new DepoMap());
            modelBuilder.Configurations.Add(new PersonelMap());
            modelBuilder.Configurations.Add(new PersonelAvansMap());
            modelBuilder.Configurations.Add(new IndirimMap());
            modelBuilder.Configurations.Add(new PersonelHareketMap());
            modelBuilder.Configurations.Add(new KullaniciMap());
            modelBuilder.Configurations.Add(new KullaniciRolMap());

        }
    }
}