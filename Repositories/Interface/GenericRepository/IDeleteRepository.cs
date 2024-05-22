using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface.GenericRepository
{
    public interface IDeleteRepository<T>
    {
        Task<int> Delete(int id);
    }
}
