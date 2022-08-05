using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace Works.Repository.Infrastructure
{
    public class Repository<entity> : IRepository<entity> where entity : class
    {
        private readonly DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(entity entity)
        {
            await  _dbContext.Set<entity>().AddAsync(entity);
        }

        public void AddRange(IEnumerable<entity> entities)
        {
            _dbContext.Set<entity>().AddRange(entities);
        }

        public void Delete(entity entity)
        {
            _dbContext.Set<entity>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<entity> entities)
        {
            _dbContext.Set<entity>().RemoveRange(entities);
        }

        public async Task<entity> FindAsync(Expression<Func<entity, bool>> predicate)
        {
            return await _dbContext.Set<entity>().FirstOrDefaultAsync(predicate);
        }

        public IQueryable<entity> GetAll()
        {
            return _dbContext.Set<entity>();
        }




        public async Task<entity> GetAsync(int id)
        {
            return await _dbContext.Set<entity>().FindAsync(id);
        }

        public IQueryable<entity> GetWhereAsync(Expression<Func<entity, bool>> predicate)
        {
            return _dbContext.Set<entity>().Where(predicate).AsQueryable();
        }

        public IQueryable<entity> Query()
        {
            throw new NotImplementedException();
        }

        public void Update(entity entity)
        {
            _dbContext.Set<entity>().Update(entity);
        }

        public void UpdateRange(IEnumerable<entity> entities)
        {
            _dbContext.Set<entity>().UpdateRange(entities);
        }
    }
    
}
