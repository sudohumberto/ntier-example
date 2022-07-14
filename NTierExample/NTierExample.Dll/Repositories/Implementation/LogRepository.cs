
using Microsoft.EntityFrameworkCore;
using NTierExample.Dll.Context;
using NTierExample.Dll.Entities;
using NTierExample.Dll.Repositories.Abstract;

namespace NTierExample.Dll.Repositories.Implementation
{
    public class LogRepository : BaseRepository<Log>, ILogRepository
    {
        public LogRepository(AppDbContext context) : base(context)
        {

        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
