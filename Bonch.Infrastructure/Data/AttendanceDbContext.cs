using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitModule.API.UniverMember;

namespace VisitModule.Infrastructure.Data
{
    public class AttendanceDbContext : DbContext
    {
        public DbSet<AttendanceRecord> AttendanceRecords { get; set; }
    }

}
