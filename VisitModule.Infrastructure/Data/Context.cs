using Microsoft.EntityFrameworkCore;

using VisitModule.Domain.Model;

namespace VisitModule.Infrastructure.Data
{
    public class VisitContext : DbContext
    {
        // Конструктор с параметром DbContextOptions
        public VisitContext(DbContextOptions<VisitContext> options) : base(options) { }

        public DbSet<Visit> Visits { get; set; }
        public DbSet<Student> Students { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(s => s.StudentListId);

            modelBuilder.Entity<Student>()
                .Property(s => s.fofeducation)
                .HasMaxLength(50);

            modelBuilder.Entity<Student>()
                .Property(s => s.StudentListId)
                .IsRequired();

            modelBuilder.Entity<Student>()
                .HasIndex(s => s.StudentListId)
                .IsUnique();
        }
    }

}
