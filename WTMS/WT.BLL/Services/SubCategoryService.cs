using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WT.BLL.Services.Interfaces;
using WT.DAL.Data;
using WT.DAL.Models;

namespace WT.BLL.Services
{
    public class SubCategoryService : GlobalService<SubCategory>, ISubCategoryService
    {
        private readonly AppDbContext _appDbContext;
        public SubCategoryService(AppDbContext appDbContext):base(appDbContext) => _appDbContext = appDbContext;
        
        public async Task<List<SubCategory>> GetAllSubParentCategory()
        {
            var data =await _appDbContext.SubCategories.Include(c => c.Category).ToListAsync();
            return data;
        }

        public async Task<SubCategory> GetById(int id)
        {
            var data = await _appDbContext.SubCategories.Include(c => c.Category).FirstOrDefaultAsync();
            return data;
        }

        public async Task<IList<Brand>> GetBrands(int subCategoryId)
        {
            var source = await _appDbContext.Brands
                .Where(s => s.Products.Any(s => s.SubCategoryId == subCategoryId))
                .ToListAsync();

            return source;
        }
    }
}
