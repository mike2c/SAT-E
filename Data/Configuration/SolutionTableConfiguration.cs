using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
    class SolutionTableConfiguration : IEntityTypeConfiguration<Solution>
    {
        public void Configure(EntityTypeBuilder<Solution> builder)
        {
            builder.ToTable("Solution");

            builder.Property(s => s.SolutionDescription)
                .HasColumnType("Text")
                .HasMaxLength(45);

            builder.Property(s => s.ProblemDescription)
                .HasColumnType("Varchar")
                .HasMaxLength(45);

            builder.HasOne(s => s.CurrentSolution);

        }
    }
}
