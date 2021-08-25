using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tolling.Interfaces
{
    public   interface Crud<T1,T2>
    {
        public void Create(T1 t);
        public IEnumerable<T1> GetAll();
        public T1 GetOne(T2 id);
        
        public void Update(T1 t);
        public void Delete(T2 id);
    }
}
