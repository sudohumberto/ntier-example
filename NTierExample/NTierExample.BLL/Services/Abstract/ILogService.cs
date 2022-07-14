using NTierExample.Dll.Entities;

namespace NTierExample.BLL.Services.Abstract
{
    public interface ILogService
    {
        // SELECT methods
        Task<List<Log>> SelectLog();
        Task<Log?> SelectLogById(int id);

        // INSERT methods
        void InsertLog(Log entity);

        // UPDATE methods
        void UpdateLog(Log entity);

        // DELETE methods
        void DeleteLog(int id);
    }
}
