using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Barkod_Otomasyon.Models.Mapping;

namespace Barkod_Otomasyon.Models
{
    public partial class FdkBarkodOtomasyonContext : DbContext
    {
        static FdkBarkodOtomasyonContext()
        {
            Database.SetInitializer<FdkBarkodOtomasyonContext>(new Configuration());
        }

        public FdkBarkodOtomasyonContext()
            : base("Name=FdkBarkodOtomasyonContext")
        {
        }

        public DbSet<Fi> Fis { get; set; }
        public DbSet<Iade> Iades { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Sati> Satis { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Tedarikci> Tedarikcis { get; set; }
        public DbSet<Urun> Uruns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FiMap());
            modelBuilder.Configurations.Add(new IadeMap());
            modelBuilder.Configurations.Add(new KategoriMap());
            modelBuilder.Configurations.Add(new KullaniciMap());
            modelBuilder.Configurations.Add(new MusteriMap());
            modelBuilder.Configurations.Add(new SatiMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TedarikciMap());
            modelBuilder.Configurations.Add(new UrunMap());
        }
    }
}
