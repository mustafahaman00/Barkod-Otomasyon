using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Barkod_Otomasyon.Models.Mapping
{
    public class MusteriMap : EntityTypeConfiguration<Musteri>
    {
        public MusteriMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.AdiSoyadi)
                .HasMaxLength(50);

            this.Property(t => t.Gsm)
                .HasMaxLength(12);

            this.Property(t => t.Adres)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Musteri");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AdiSoyadi).HasColumnName("AdiSoyadi");
            this.Property(t => t.Gsm).HasColumnName("Gsm");
            this.Property(t => t.Adres).HasColumnName("Adres");
            this.Property(t => t.EkleyenID).HasColumnName("EkleyenID");
            this.Property(t => t.KayitTarihi).HasColumnName("KayitTarihi");

            // Relationships
            this.HasOptional(t => t.Kullanici)
                .WithMany(t => t.Musteris)
                .HasForeignKey(d => d.EkleyenID);

        }
    }
}
