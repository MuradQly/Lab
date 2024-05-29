using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Murik.Service
{
    internal interface IService<T>
    {
        List<T> GetAll();
        T Get(int id);
        void Delete(int id);
        void Add(T entity);
        void Save();
     
    }
}
