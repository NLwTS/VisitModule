using System.Collections.Generic;
using System.Threading.Tasks;
using VisitModule.Domain.Model;

namespace VisitModule.Infrastructure.Repository
{
    public interface IVisitRepository
    {
        Task<List<Visit>> GetVisitsAsync(); // Получить все визиты

        Task AddVisitAsync(Visit visit); // Добавить визит
        Task SaveChangesAsync(); // Сохранить изменения в БД
    }
}
