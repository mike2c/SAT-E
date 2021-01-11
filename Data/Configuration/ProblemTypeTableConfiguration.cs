using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
    class ProblemTypeTableConfiguration : IEntityTypeConfiguration<ProblemType>
    {
        public void Configure(EntityTypeBuilder<ProblemType> builder)
        {
            builder.ToTable("ProblemType");

            builder.Property(s => s.ProblemName)
                .HasColumnType("Varchar")
                .HasMaxLength(100);

            builder.Property(p => p.ProblemDescription)
                .HasColumnType("TEXT")
                .IsRequired(true);

            builder.HasOne(s => s.CurrentSolution);

            builder.HasMany(s => s.SolutionHistories)
                .WithOne(x => x.Solution);

        }
    }
}
