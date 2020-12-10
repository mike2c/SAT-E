using Core.Entity;
using Data.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Data.Data
{
    public class SATContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Source> Source { get; set; }
        public DbSet<TechnicalAssistance> TechnicalSupports { get; set; }
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<SolutionHistory> SolutionHistories { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Annotation> Annotations { get; set; }
        public DbSet<Rol> Roles { get; set; }

        public SATContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserTableConfiguration());
            builder.ApplyConfiguration(new TaskTableConfiguration());
            builder.ApplyConfiguration(new TechnicalAssistanceTableConfiguration());
            builder.ApplyConfiguration(new SolutionTableConfiguration());
            builder.ApplyConfiguration(new SolutionHistoryTableConfiguration());
            builder.ApplyConfiguration(new SourceTableConfiguration());
            builder.ApplyConfiguration(new AttachmentTableConfiguration());
            builder.ApplyConfiguration(new AnnotationTableConfiguration());
            builder.ApplyConfiguration(new RolTableConfiguration());
        }
    }
}