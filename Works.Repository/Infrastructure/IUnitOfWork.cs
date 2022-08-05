using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Works.Data;
using Works.Repository.Repositories;

namespace Works.Repository.Infrastructure
{
    public  interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository Employee { get; }
        IDepartmentRepository Department { get; }

         Task<int> CompleteAsync();
    }
}
