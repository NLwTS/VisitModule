using System.Collections.Generic;
using System.Threading.Tasks;
using VisitModule.Domain.Model;

namespace VisitModule.Infrastructure.Repository
{
    public interface IVisitRepository
    {
        Task<List<Visit>> GetVisitsAsync(); // Получить все визиты
        Task<Visit> GetVisitByIdAsync(int id); // Получить визит по ID
        Task AddVisitAsync(Visit visit); // Добавить визит
        Task SaveChangesAsync(); // Сохранить изменения в БД
    }
}
