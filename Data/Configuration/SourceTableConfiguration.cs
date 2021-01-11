using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
    class SourceTableConfiguration : IEntityTypeConfiguration<Source>
    {
        public void Configure(EntityTypeBuilder<Source> builder)
        {
            builder.ToTable("Source");

            builder.Property(s => s.IsActive)
                .HasDefaultValue(true);

            builder.Property(s => s.SourceName)
                .IsRequired(true)
                .HasColumnType("VarChar")
                .HasMaxLength(45);

        }
    }
}
