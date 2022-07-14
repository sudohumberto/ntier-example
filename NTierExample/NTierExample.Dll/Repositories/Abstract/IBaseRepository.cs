using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierExample.Dll.Repositories.Abstract
{
    public interface IBaseRepository<T> where T : class
    {
        // SELECT methods
        Task<T?> SelectById(int id);
        Task<List<T>> SelectAll();

        // INSERT methods
        Task<T> Insert(T entity);

        // UPDATE methods
        void Update(T entity);

        // DELETE methods
        void Delete(int id);

        // Save Changes methods
        void SaveChanges();
    }
}
