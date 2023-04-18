using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WT.DAL.Data;
using WT.DAL.Repository.Interfaces;
using WT.DAL.BaseEntity;
using System.Linq.Expressions;

namespace WT.DAL.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity<int>
    {
        protected readonly AppDbContext _dbContext;
        protected readonly DbSet<TEntity> _entities;
        public GenericRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _entities = _dbContext.Set<TEntity>();
        }
        public async Task<TEntity> AddAsync(TEntity item)
        {

            await _entities.AddAsync(item);
            _dbContext.SaveChanges();
            return item;
        }

        public void Delete(int id)
        {
            var dbItem = _entities.Find(id);
            _entities.Remove(dbItem);
            _dbContext.SaveChanges();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            var dbItem = await _entities.FindAsync(id);
            return dbItem;
        }

        public async Task<List<TEntity>> GetListAsync(params Expression<Func<TEntity, bool>>[] predicates)
        {
            var source = _entities;
            if (predicates!=null && predicates.Any())
            {
                foreach(var query in predicates)
                {
                   source.Where(query);
                }
            }
            var dbItem = await source.ToListAsync();
            return dbItem;
        }

        public IQueryable<TEntity> GetAllQueryable()
        {
            return _entities.AsQueryable();
        }

        public TEntity Update(TEntity item)
        {
            var dbEntity = _entities.Find(item.Id);
            item.Created_Date = dbEntity.Created_Date;
            // item.UpdateDate = DateTime.Now;        
            _entities.Update(item);
            _dbContext.SaveChanges();
            return item;
        }


    }
}
