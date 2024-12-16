using Microsoft.EntityFrameworkCore;
using VisitModule.Domain.Models;
using VisitModule.Infrastructure.Data;

namespace VisitModule.Infrastructure.Repository
{
    public interface IVisitRepository
    {
        Task<IEnumerable<Visit>> GetVisitsAsync();
        Task<Visit?> GetVisitByIdAsync(int id);
        Task AddVisitAsync(Visit visit);
        Task<bool> SaveChangesAsync();
    }

    public class VisitRepository : IVisitRepository
    {
        private readonly VisitContext _context;

        public VisitRepository(VisitContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Visit>> GetVisitsAsync()
        {
            return await _context.Visits.ToListAsync();
        }

        public async Task<Visit?> GetVisitByIdAsync(int id)
        {
            return await _context.Visits.FindAsync(id);
        }

        public async Task AddVisitAsync(Visit visit)
        {
            await _context.Visits.AddAsync(visit);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}