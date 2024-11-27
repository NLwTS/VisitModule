using Microsoft.EntityFrameworkCore;
using VisitModule.API.UniversityMember;
using VisitModule.Infrastructure.Data;

namespace VisitModule.API.Services
{
    public class AttendanceRepository
    {
        private readonly AppDbContext _context;

        public AttendanceRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<AttendanceRecord>> GetAttendanceByStudentAsync(int studentId)
        {
            return await _context.AttendanceRecords
                .Where(a => a.StudentId == studentId)
                .ToListAsync();
        }

        public async Task AddAttendanceAsync(AttendanceRecord record)
        {
            _context.AttendanceRecords.Add(record);
            await _context.SaveChangesAsync();
        }

        public async Task<List<AttendanceRecord>> GetAbsenteesByDateAsync(DateTime date)
        {
            return await _context.AttendanceRecords
                .Where(a => a.AttendanceDate.Date == date.Date && !a.IsPresent)
                .ToListAsync();
        }
    }

}
