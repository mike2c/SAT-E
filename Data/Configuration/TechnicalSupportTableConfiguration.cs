using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
    class TechnicalSupportTableConfiguration : IEntityTypeConfiguration<TechnicalSupport>
    {
        public void Configure(EntityTypeBuilder<TechnicalSupport> builder)
        {
            builder.ToTable("TechnicalSupport");

            builder.Property(t => t.Problem)
                .IsRequired(true)
                .HasColumnType("text");

            builder.Property(t => t.State)
                .IsRequired(true)
                .HasDefaultValue(State.Pendiente);

            builder.Property(t => t.Priority)
                .IsRequired(true);
        }
    }
}
