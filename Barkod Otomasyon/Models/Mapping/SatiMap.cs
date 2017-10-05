using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Barkod_Otomasyon.Models.Mapping
{
    public class SatiMap : EntityTypeConfiguration<Sati>
    {
        public SatiMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Satis");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UrunID).HasColumnName("UrunID");
            this.Property(t => t.Adet).HasColumnName("Adet");
            this.Property(t => t.BirimFiyat).HasColumnName("BirimFiyat");
            this.Property(t => t.ToplamFiyat).HasColumnName("ToplamFiyat");
            this.Property(t => t.FisID).HasColumnName("FisID");
            this.Property(t => t.AdetAlisFiyati).HasColumnName("AdetAlisFiyati");
            this.Property(t => t.AdetSatisFiyati).HasColumnName("AdetSatisFiyati");

            // Relationships
            this.HasOptional(t => t.Fi)
                .WithMany(t => t.Satis)
                .HasForeignKey(d => d.FisID);
            this.HasOptional(t => t.Urun)
                .WithMany(t => t.Satis)
                .HasForeignKey(d => d.UrunID);

        }
    }
}
