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
    public class CategoryService : GlobalService<Category>, ICategoryService
    {
        private readonly AppDbContext _appDbContext;
        public CategoryService(AppDbContext appDbContext) : base(appDbContext) => _appDbContext = appDbContext;
    }
}
