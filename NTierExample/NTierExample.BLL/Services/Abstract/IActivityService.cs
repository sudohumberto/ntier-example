using NTierExample.Dll.Entities;

namespace NTierExample.BLL.Services.Abstract
{
    public interface IActivityService
    {
        // SELECT methods
        Task<List<Activity>> SelectActivity();
        Task<Activity?> SelectActivityById(int id);

        // INSERT methods
        void InsertActivity(Activity entity);

        // UPDATE methods
        void UpdateActivity(Activity entity);

        // DELETE methods
        void DeleteActivity(int id);
    }
}
