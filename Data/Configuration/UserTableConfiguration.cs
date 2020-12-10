using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class UserTableConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User")
                .HasKey(u => u.UserId);

            builder.Property(u => u.Username)
                .IsRequired(true)
                .HasMaxLength(15)
                .HasColumnType("VarChar");

            builder.Property(u => u.Password)
                .IsRequired(true)
                .HasMaxLength(250)
                .HasColumnType("VarChar");

            builder.Property(u => u.Email)
                .IsRequired(true)
                .HasMaxLength(45)
                .HasColumnType("VarChar");

            builder.Property(u => u.IsActive)
                .HasDefaultValue(true);

            builder.HasMany(u => u.Roles)
                .WithMany(r => r.Users)
                .UsingEntity(ur =>
                {
                    ur.ToTable("UserRoles");
                });
        }
    }
}