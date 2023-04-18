using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WT.DAL.Models;

namespace WT.BLL.Services.Interfaces
{
    public interface IShopAndOfficeService:IGlobalService<ShopAndOffice>
    {
        Task<List<ShopAndOffice>> GetAllShopAndOffice();
    }
}
