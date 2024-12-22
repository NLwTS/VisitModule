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
        public DbSet<Classroom> Classrooms { get; set; }

        // Метод конфигурации (не обязателен, если использована строка подключения в AddDbContext)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Подключение к базе данных PostgreSQL
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=mydb;Username=postgres;Password=admin");
            }
        }
    }
}
