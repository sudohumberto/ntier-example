using NTierExample.BLL.Services.Abstract;
using NTierExample.Dll.Entities;
using NTierExample.Dll.Repositories.Abstract;

namespace NTierExample.BLL.Services.Implementation
{
    public class LogService : ILogService
    {
        // Service can have multiple repositories implementing UoW (Unit of Work) design Pattern

        private readonly ILogRepository _logRepository;

        public LogService(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }

        public Task<List<Log>> SelectLog()
        {
            return _logRepository.SelectAll();
        }

        public Task<Log?> SelectLogById(int id)
        {
            return _logRepository.SelectById(id);
        }
        public void InsertLog(Log entity)
        {
            _logRepository.Insert(entity);
        }

        public void UpdateLog(Log entity)
        {
            _logRepository.Update(entity);
        }

        public void DeleteLog(int id)
        {
            _logRepository.Delete(id);
        }
    }
}
