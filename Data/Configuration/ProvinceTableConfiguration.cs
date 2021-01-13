using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    class ProvinceTableConfiguration : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.ToTable("Province")
                .HasKey(p => p.ProvinceId);

            builder.Property(p => p.ProvinceName)
                .HasMaxLength(45)
                .IsRequired(true);

            builder.HasMany(p => p.Municipalities)
                .WithOne(m => m.Province);
        }
    }
}
