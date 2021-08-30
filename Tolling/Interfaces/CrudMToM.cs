using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tolling.Interfaces
{
    public interface CrudMToM<T1, T2,T3>
    {
        public void Create(T1 t,T3 t3);
        public IEnumerable<T1> GetAll();
        public T1 GetOne(T2 id);

        public void Update(T1 t,T3 t3);
        public void Delete(T2 id);
        public void AssignMToM(T3 T);
    }
}
