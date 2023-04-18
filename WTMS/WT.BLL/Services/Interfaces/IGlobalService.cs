using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WT.BLL.Services.Interfaces
{
    public interface IGlobalService<TEntity> where TEntity : class
    {
        public Task<TEntity> AddAsync(TEntity item);
        public Task<TEntity> GetAsync(params Expression<Func<TEntity, bool>>[] predicates);
        public Task<List<TEntity>> GetAllAsync(params Expression<Func<TEntity, bool>>[] predicates);
        public void Delete(int id);
        public TEntity Update(TEntity item);


    }
}
