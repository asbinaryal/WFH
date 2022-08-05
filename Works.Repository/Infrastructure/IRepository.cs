using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Works.Repository.Infrastructure
{
    public interface IRepository<entity> where entity : class

    {
         Task<entity> GetAsync(int id);
       // Task<entity> GetAsync();
        Task<entity> FindAsync(Expression<Func<entity, bool>> predicate);

        IQueryable<entity> Query();

        IQueryable<entity> GetAll();

        Task Add(entity entity);
        void AddRange(IEnumerable<entity> entities);

        void Update(entity entity);
        void UpdateRange(IEnumerable<entity> entities);

        void Delete(entity entity);
        void DeleteRange(IEnumerable<entity> entities);
    }
}
