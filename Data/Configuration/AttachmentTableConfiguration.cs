using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
    class AttachmentTableConfiguration : IEntityTypeConfiguration<Attachment>
    {
        public void Configure(EntityTypeBuilder<Attachment> builder)
        {
            builder.ToTable("Attachment");

            builder.Property(s => s.Extension)
                .IsRequired(true)
                .HasColumnType("Char")
                .HasMaxLength(5);

            builder.Property(s => s.FileName)
                .IsRequired(true)
                .HasColumnType("VarChar")
                .HasMaxLength(100);

            builder.Property(s => s.Path)
                .IsRequired(true)
                .HasColumnType("VarChar")
                .HasMaxLength(1000);

        }
    }
}
