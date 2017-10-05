using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Barkod_Otomasyon.Models.Mapping
{
    public class KullaniciMap : EntityTypeConfiguration<Kullanici>
    {
        public KullaniciMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.KullaniciAdi)
                .HasMaxLength(50);

            this.Property(t => t.Parola)
                .HasMaxLength(50);

            this.Property(t => t.Adi)
                .HasMaxLength(50);

            this.Property(t => t.Soyadi)
                .HasMaxLength(50);

            this.Property(t => t.Gsm)
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("Kullanici");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.KullaniciAdi).HasColumnName("KullaniciAdi");
            this.Property(t => t.Parola).HasColumnName("Parola");
            this.Property(t => t.Adi).HasColumnName("Adi");
            this.Property(t => t.Soyadi).HasColumnName("Soyadi");
            this.Property(t => t.Gsm).HasColumnName("Gsm");
            this.Property(t => t.AdminMi).HasColumnName("AdminMi");
            this.Property(t => t.AktifMi).HasColumnName("AktifMi");
        }
    }
}
