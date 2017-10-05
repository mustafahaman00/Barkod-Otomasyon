using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Barkod_Otomasyon.Models.Mapping
{
    public class KategoriMap : EntityTypeConfiguration<Kategori>
    {
        public KategoriMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.KategoriAdi)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Kategori");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.KategoriAdi).HasColumnName("KategoriAdi");
        }
    }
}
