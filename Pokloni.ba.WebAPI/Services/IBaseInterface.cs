using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokloni.ba.WebAPI.Controllers
{
    public interface IBaseInterface<T>
    {
        IEnumerable<T> Get();

        T GetById(int id);

        T Insert(T request);

        T Update(T request, int id);

        void Delete(int id);
    }
}
