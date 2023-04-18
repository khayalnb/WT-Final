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
    public class AdressTypeService:GlobalService<AdressType>, IAdressTypeService
    {
        private readonly AppDbContext _appDbContext;
        public AdressTypeService(AppDbContext appDbContext) : base(appDbContext) => _appDbContext = appDbContext;
    }
}
