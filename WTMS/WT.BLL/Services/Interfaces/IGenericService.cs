using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WT.BLL.Services.Interfaces
{
    public interface IGenericService<TDto, TEntity> where TDto : class where TEntity : class
    {
        public Task<TDto> AddAsync(TDto item);
        public Task<TDto> GetByIdAsync(int id);
        public Task<List<TDto>> GetListAsync(params Expression<Func<TEntity, bool>>[] predicates);
        public void Delete(int id);
        public TDto Update(TDto item);
    }
}
