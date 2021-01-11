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
    class BranchTableConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.ToTable("Branch")
                .HasKey(b => b.BranchId);

            builder.Property(b => b.BranchName)
                .HasMaxLength(45)
                .IsRequired(true);

            builder.Property(b => b.Municipality)
                .IsRequired(true);

            builder.HasOne(b => b.Municipality)
                .WithMany(m => m.Branches);
        }
    }
}
