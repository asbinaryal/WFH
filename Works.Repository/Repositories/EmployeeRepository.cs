using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Works.Data;
using Works.Data.Entities;
using Works.Repository.Infrastructure;


namespace Works.Repository.Repositories
{
    public class EmployeeRepository : Repository<Employee> , IEmployeeRepository
    {
        private readonly DbContext _dbContext;
        public EmployeeRepository(DbContext dbContext) : base(dbContext)
        {
            _dbContext= dbContext;
        }
    }

}
