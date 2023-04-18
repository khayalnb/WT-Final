using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WT.DAL.Repository.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        public Task<TEntity> AddAsync(TEntity item);
        public Task<List<TEntity>> GetListAsync(params Expression<Func<TEntity, bool>>[] predicates);
        IQueryable<TEntity> GetAllQueryable();
        public Task<TEntity> GetByIdAsync(int id);
        public TEntity Update(TEntity item);
        public void Delete(int id);

    }
}
