using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    class MunicipalityTableConfiguration : IEntityTypeConfiguration<Municipality>
    {
        public void Configure(EntityTypeBuilder<Municipality> builder)
        {

            builder.ToTable("Municipality")
                .HasKey(m => m.MunicipalityId);

            builder.Property(m => m.MunicipalityName)
                .HasMaxLength(45)
                .IsRequired(true);

            builder.HasMany(p => p.Branches)
                .WithOne(m => m.Municipality);
        }
    }
}
