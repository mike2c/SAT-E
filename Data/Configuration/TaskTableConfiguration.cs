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

            builder.Property(t => t.TaskName)
                .IsRequired(true);

            builder.Property(t => t.State)
                .IsRequired(true)
                .HasDefaultValue(State.Pendiente);

            builder.Property(t => t.Priority)
                .IsRequired(true);

            builder.Property(t => t.StartDate)
                .IsRequired(false);

            builder.Property(t => t.EndDate)
                .IsRequired(false);

            builder.HasKey(i => i.TaskId);
            builder.HasOne(i => i.AssignedTo);
            builder.HasOne(i => i.AttendedBy);
            builder.HasOne(i => i.AssignedBy);
            builder.HasOne(i => i.Source);

            builder.HasOne(t => t.Employee)
                .WithMany(e => e.Tasks);
        }
    }
}
