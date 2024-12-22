using Microsoft.EntityFrameworkCore;

using VisitModule.Domain.Model;

namespace VisitModule.Infrastructure.Data
{
    public class VisitContext : DbContext
    {
        public VisitContext(DbContextOptions<VisitContext> options) : base(options) { }

        public DbSet<Visit> Visits { get; set; } // Таблица Visits

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Visit>().ToTable("Visits");
        }
    }
}
