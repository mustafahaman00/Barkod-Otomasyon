using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Barkod_Otomasyon.Models.Mapping
{
    public class UrunMap : EntityTypeConfiguration<Urun>
    {
        public UrunMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.UrunAdi)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Urun");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UrunAdi).HasColumnName("UrunAdi");
            this.Property(t => t.KategoriID).HasColumnName("KategoriID");
            this.Property(t => t.TedarikciID).HasColumnName("TedarikciID");
            this.Property(t => t.Barkod).HasColumnName("Barkod");
            this.Property(t => t.AlisFiyati).HasColumnName("AlisFiyati");
            this.Property(t => t.SatisFiyati).HasColumnName("SatisFiyati");
            this.Property(t => t.Aciklama).HasColumnName("Aciklama");
            this.Property(t => t.EklenmeTarihi).HasColumnName("EklenmeTarihi");
            this.Property(t => t.EkleyenID).HasColumnName("EkleyenID");
            this.Property(t => t.ResimYolu).HasColumnName("ResimYolu");

            // Relationships
            this.HasOptional(t => t.Kategori)
                .WithMany(t => t.Uruns)
                .HasForeignKey(d => d.KategoriID);
            this.HasOptional(t => t.Kullanici)
                .WithMany(t => t.Uruns)
                .HasForeignKey(d => d.EkleyenID);
            this.HasOptional(t => t.Tedarikci)
                .WithMany(t => t.Uruns)
                .HasForeignKey(d => d.TedarikciID);

        }
    }
}
