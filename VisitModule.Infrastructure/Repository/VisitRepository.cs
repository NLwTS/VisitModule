using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using VisitModule.Domain.Model;
using VisitModule.Infrastructure.Data;

namespace VisitModule.Infrastructure.Repository
{
    public class VisitRepository : IVisitRepository
    {
        private readonly VisitContext _context;

        public VisitRepository(VisitContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<Visit>> GetVisitsAsync()
        {
            return await _context.Visits.ToListAsync();
        }

        //public async Task<Visit> GetVisitByIdAsync(int id)
        //{
        //    return await _context.Visits.FindAsync(id);
        //}

        public async Task AddVisitAsync(Visit visit)
        {
            await _context.Visits.AddAsync(visit);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
