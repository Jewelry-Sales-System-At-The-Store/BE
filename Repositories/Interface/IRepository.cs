using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<int> Create(T entity);
        Task<IEnumerable<T>> Find(Func<T, bool> predicate);
        Task<T> Update(T entity);
    }
}
