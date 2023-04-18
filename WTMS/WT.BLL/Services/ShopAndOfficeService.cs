using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WT.BLL.Services.Interfaces;
using WT.DAL.Data;
using WT.DAL.Models;

namespace WT.BLL.Services
{
    public class ShopAndOfficeService: GlobalService<ShopAndOffice>, IShopAndOfficeService
    {
        private readonly AppDbContext _appDbContext;
        public ShopAndOfficeService(AppDbContext appDbContext) : base(appDbContext) => _appDbContext = appDbContext;

        public async Task<List<ShopAndOffice>> GetAllShopAndOffice()
        {
            var data = await _appDbContext.ShopAndOffices.Include(i => i.AdressType).ToListAsync();
            return data;
        }
    }
}
