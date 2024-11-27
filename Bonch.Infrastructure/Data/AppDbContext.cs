using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitModule.API.UniversityMember;


namespace VisitModule.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<AttendanceRecord> AttendanceRecords { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Конфигурация модели (например, ограничение строк)
            modelBuilder.Entity<AttendanceRecord>()
                .Property(a => a.Reason)
                .HasMaxLength(500);
        }
    }
}
