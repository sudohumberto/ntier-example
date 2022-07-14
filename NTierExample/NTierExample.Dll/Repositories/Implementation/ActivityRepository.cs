using NTierExample.Dll.Context;
using NTierExample.Dll.Entities;
using NTierExample.Dll.Repositories.Abstract;

namespace NTierExample.Dll.Repositories.Implementation
{
    public class ActivityRepository : BaseRepository<Activity>, IActivityRepository
    {
        public ActivityRepository(AppDbContext context) : base(context)
        {

        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
