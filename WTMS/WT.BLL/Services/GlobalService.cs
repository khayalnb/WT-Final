using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WT.BLL.Services.Interfaces;
using WT.DAL.BaseEntity;
using WT.DAL.Data;

namespace WT.BLL.Services
{
    public class GlobalService<TEntity>: IGlobalService<TEntity> where TEntity : BaseEntity<int>
    {
        private readonly AppDbContext _appDbContext;


        public GlobalService(AppDbContext appDbContext) => _appDbContext = appDbContext;

        public async Task<TEntity> AddAsync(TEntity item)
        {
            await _appDbContext.Set<TEntity>().AddAsync(item);
            _appDbContext.SaveChanges();
            return item;
        }

        public void Delete(int id)
        {
            var data = _appDbContext.Set<TEntity>().Find(id);
            _appDbContext.Set<TEntity>().Remove(data);
            _appDbContext.SaveChanges();
        }

        public async Task<List<TEntity>> GetAllAsync(params Expression<Func<TEntity, bool>>[] predicates)
        {
            var source = _appDbContext.Set<TEntity>().AsQueryable(); ;
            if (predicates != null && predicates.Any())
            {
                foreach (var query in predicates)
                {
                    source = source.Where(query);
                }
            }
            return await source.OrderByDescending(c => c.Created_Date).ToListAsync();
        }

        public async Task<TEntity> GetAsync(params Expression<Func<TEntity, bool>>[] predicates)
        {
            var source = _appDbContext.Set<TEntity>().AsQueryable();
            if (predicates != null && predicates.Any())
            {
                foreach (var query in predicates)
                {
                    source = source.Where(query);
                }
            }
            var dbItem = await source.FirstOrDefaultAsync();
            return dbItem;
        }

        public TEntity Update(TEntity item)
        {
            _appDbContext.Set<TEntity>().Update(item);
            _appDbContext.SaveChanges();
            return item;
        }
    }
}
