using NTierExample.BLL.Services.Abstract;
using NTierExample.Dll.Entities;
using NTierExample.Dll.Repositories.Abstract;

namespace NTierExample.BLL.Services.Implementation
{
    public class ActivityService : IActivityService
    {
        // Service can have multiple repositories implementing UoW (Unit of Work) design Pattern

        private readonly IActivityRepository _activityRepository;

        public ActivityService(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }

        public Task<List<Activity>> SelectActivity()
        {
            return _activityRepository.SelectAll();
        }

        public Task<Activity?> SelectActivityById(int id)
        {
            return _activityRepository.SelectById(id);
        }

        public void InsertActivity(Activity entity)
        {
            _activityRepository.Insert(entity);
        }

        public void UpdateActivity(Activity entity)
        {
            _activityRepository.Update(entity);
        }

        public void DeleteActivity(int id)
        {
            _activityRepository.Delete(id);
        }
    }
}
