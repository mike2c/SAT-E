using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
