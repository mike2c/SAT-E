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
    public class DepartmentTableConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department")
                .HasKey(d => d.DepartmentId);

            builder.Property(d => d.DepartmentName)
                .HasMaxLength(45)
                .IsRequired(true);
        }
    }
}
