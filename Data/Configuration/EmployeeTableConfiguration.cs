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
    class EmployeeTableConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {

            builder.ToTable("Employee")
                .HasKey(e => e.EmployeeId);

            builder.Property(e => e.EmployeeId)
                .ValueGeneratedNever();

            builder.Property(e => e.FirstName)
                .HasMaxLength(45)
                .IsRequired(true);

            builder.Property(e => e.LastName)
                .HasMaxLength(45)
                .IsRequired(true);

            builder.Property(e => e.Gender)
                .IsRequired(true);

            builder.Property(e => e.Email)
                .HasMaxLength(45)
                .IsRequired(false);

            builder.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsRequired(false);

            builder.Property(e => e.PhoneExtension)
                .HasMaxLength(8)
                .IsRequired(false);

            builder.Property(e => e.CelPhone)
                .HasMaxLength(15)
                .IsRequired(false);

            builder.Property(e => e.Department)
                .IsRequired(true);

            builder.Property(e => e.Branch)
                .IsRequired(true);

            builder.HasOne(e => e.Branch);
            builder.HasOne(e => e.Department);
        }
    }
}
