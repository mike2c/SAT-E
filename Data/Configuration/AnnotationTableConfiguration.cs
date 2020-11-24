using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
    class AnnotationTableConfiguration : IEntityTypeConfiguration<Annotation>
    {
        public void Configure(EntityTypeBuilder<Annotation> builder)
        {
            builder.ToTable("Annotation");

            builder.Property(a => a.AnnotationBody)
                .IsRequired(true)
                .HasColumnType("text");

        }
    }
}
