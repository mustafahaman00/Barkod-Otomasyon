using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Barkod_Otomasyon.Models.Mapping
{
    public class IadeMap : EntityTypeConfiguration<Iade>
    {
        public IadeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Iade");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UrunID).HasColumnName("UrunID");
            this.Property(t => t.Adet).HasColumnName("Adet");
            this.Property(t => t.BirimFiyat).HasColumnName("BirimFiyat");
            this.Property(t => t.ToplamFiyat).HasColumnName("ToplamFiyat");
            this.Property(t => t.IadeTarihi).HasColumnName("IadeTarihi");
            this.Property(t => t.KullaniciID).HasColumnName("KullaniciID");
            this.Property(t => t.Aciklama).HasColumnName("Aciklama");
            this.Property(t => t.MusteriID).HasColumnName("MusteriID");

            // Relationships
            this.HasOptional(t => t.Kullanici)
                .WithMany(t => t.Iades)
                .HasForeignKey(d => d.KullaniciID);
            this.HasOptional(t => t.Musteri)
                .WithMany(t => t.Iades)
                .HasForeignKey(d => d.MusteriID);
            this.HasOptional(t => t.Urun)
                .WithMany(t => t.Iades)
                .HasForeignKey(d => d.UrunID);

        }
    }
}
