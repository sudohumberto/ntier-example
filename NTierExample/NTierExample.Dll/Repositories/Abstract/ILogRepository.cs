using NTierExample.Dll.Entities;

namespace NTierExample.Dll.Repositories.Abstract
{
    public interface ILogRepository : IBaseRepository<Log>, IDisposable
    {
        // Additional methods or override ones from BaseRepository
    }
}
