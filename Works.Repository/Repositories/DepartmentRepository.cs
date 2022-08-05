using Microsoft.EntityFrameworkCore;
using Works.Data.Entities;
using Works.Repository.Infrastructure;


namespace Works.Repository.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        private readonly DbContext _dbContext;
        public DepartmentRepository(DbContext dbContext)
            : base(dbContext)
        {
           _dbContext = dbContext;
        }

    }
}
