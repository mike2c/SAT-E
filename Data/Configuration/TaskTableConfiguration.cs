using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Data.Configuration
{
    public class TaskTableConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {

            builder.ToTable("Task");

            builder.HasKey(i => i.TaskId);
            builder.HasOne(i => i.AssingedTo);
            builder.HasOne(i => i.AttendedBy);
            builder.HasOne(i => i.AssignedBy);
            builder.HasOne(i => i.Source);

            builder.Property(t => t.Problem)
                .IsRequired(true)
                .HasColumnType("text");

            builder.Property(t => t.State)
                .IsRequired(true)
                .HasDefaultValue(State.Pendiente);

            builder.Property(t => t.Priority)
                .IsRequired(true);


        }
    }
}
