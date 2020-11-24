using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
    class SolutionHistoryTableConfiguration : IEntityTypeConfiguration<SolutionHistory>
    {
        public void Configure(EntityTypeBuilder<SolutionHistory> builder)
        {
            builder.ToTable("SolutionHistory")
                .HasMany(s => s.Attachments);

            builder.HasMany(s => s.Attachments)
                .WithMany(a => a.SolutionHistories)
                .UsingEntity(sh => sh.ToTable("SolutionHistoryAttachments"));

            builder.Property(s => s.CreatedDate)
                .IsRequired(true);

            builder.Property(s => s.SolutionDescription)
                .IsRequired(true)
                .HasColumnType("text");
        }
    }
}
