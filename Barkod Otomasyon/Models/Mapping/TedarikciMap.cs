using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Barkod_Otomasyon.Models.Mapping
{
    public class TedarikciMap : EntityTypeConfiguration<Tedarikci>
    {
        public TedarikciMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FirmaAdi)
                .HasMaxLength(50);

            this.Property(t => t.Gsm)
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("Tedarikci");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FirmaAdi).HasColumnName("FirmaAdi");
            this.Property(t => t.Adres).HasColumnName("Adres");
            this.Property(t => t.Gsm).HasColumnName("Gsm");
            this.Property(t => t.KayitTarihi).HasColumnName("KayitTarihi");
            this.Property(t => t.KaydedenID).HasColumnName("KaydedenID");

            // Relationships
            this.HasOptional(t => t.Kullanici)
                .WithMany(t => t.Tedarikcis)
                .HasForeignKey(d => d.KaydedenID);

        }
    }
}
