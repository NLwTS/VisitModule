using Microsoft.EntityFrameworkCore;
using VisitModule.Domain.Models;

namespace VisitModule.Infrastructure.Data
{
    public class VisitContext : DbContext
    {
        public VisitContext(DbContextOptions<VisitContext> options) : base(options) { }

        public DbSet<Visit> Visits { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Visit>().HasKey(v => v.Id);
            modelBuilder.Entity<Student>().HasKey(s => s.Id);
            modelBuilder.Entity<Class>().HasKey(c => c.Id);
        }
    }
}