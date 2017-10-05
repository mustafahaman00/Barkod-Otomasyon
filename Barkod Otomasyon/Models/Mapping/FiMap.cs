using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Barkod_Otomasyon.Models.Mapping
{
    public class FiMap : EntityTypeConfiguration<Fi>
    {
        public FiMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Fis");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.SatisTarihi).HasColumnName("SatisTarihi");
            this.Property(t => t.MusteriID).HasColumnName("MusteriID");
            this.Property(t => t.KullaniciID).HasColumnName("KullaniciID");
            this.Property(t => t.OdendiMi).HasColumnName("OdendiMi");
            this.Property(t => t.ToplamTutar).HasColumnName("ToplamTutar");

            // Relationships
            this.HasOptional(t => t.Kullanici)
                .WithMany(t => t.Fis)
                .HasForeignKey(d => d.KullaniciID);
            this.HasOptional(t => t.Musteri)
                .WithMany(t => t.Fis)
                .HasForeignKey(d => d.MusteriID);

        }
    }
}
