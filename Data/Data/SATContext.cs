using Core.Entity;
using Data.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;

namespace Data.Data
{
    public class SATContext : DbContext
    {
        
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Source> Source { get; set; }
        public DbSet<TechnicalAssistance> TechnicalAssistance { get; set; }
        public DbSet<ProblemType> Solutions { get; set; }
        public DbSet<SolutionHistory> SolutionHistories { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Annotation> Annotations { get; set; }
        public DbSet<ProblemType> ProblemTypes { get; set; }
        public DbSet<Rol> Roles { get; set; }

        public SATContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserTableConfiguration());
            builder.ApplyConfiguration(new TaskTableConfiguration());
            builder.ApplyConfiguration(new TechnicalAssistanceTableConfiguration());
            builder.ApplyConfiguration(new ProblemTypeTableConfiguration());
            builder.ApplyConfiguration(new SolutionHistoryTableConfiguration());
            builder.ApplyConfiguration(new SourceTableConfiguration());
            builder.ApplyConfiguration(new AttachmentTableConfiguration());
            builder.ApplyConfiguration(new AnnotationTableConfiguration());
            builder.ApplyConfiguration(new RolTableConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.LogTo(Console.WriteLine);
        }
    }
}