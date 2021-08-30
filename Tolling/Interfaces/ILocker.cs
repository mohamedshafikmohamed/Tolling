using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tolling.Models;

namespace Tolling.Interfaces
{
    public interface ILocker : CrudMToM<Locker, int,LocationDetails>
    {
    }
}
