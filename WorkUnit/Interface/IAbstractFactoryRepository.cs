using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkUnit.Interface
{
    public interface IAbstractFactoryRepository
    {
        IPersonRepository Person { get; }
        IUserRepository User { get; }
    }
}
