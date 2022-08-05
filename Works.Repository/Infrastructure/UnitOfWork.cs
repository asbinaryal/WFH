using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Works.Data;
using Works.Repository.Repositories;

namespace Works.Repository.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        private  IEmployeeRepository _employeeRepository;
        private DepartmentRepository _departmentRepository;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEmployeeRepository Employee => _employeeRepository ??= new EmployeeRepository(_dbContext);
        public IDepartmentRepository Department => _departmentRepository ??= new DepartmentRepository(_dbContext);

        public async Task<int> CompleteAsync()
        {
            return await   _dbContext.SaveChangesAsync();

        }
        
        public void Dispose() 
        {
            _dbContext.Dispose();
        }
    }
}
