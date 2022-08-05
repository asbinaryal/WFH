using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Works.Data.Entities;
using Works.Models;

namespace Works.Service
{
    public  interface IDepartmentServices
    {
         Task Add(DepartmentViewModel department);
        IEnumerable<DepartmentViewModel> GetAll();
        Task<Department> GetAsync(int id);
  

    }
}
