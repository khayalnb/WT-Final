using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WT.DAL.Models;

namespace WT.BLL.Services.Interfaces
{
    public interface IProductService : IGlobalService<Product>
    {
        Task<List<Product>> GetProducts();
    }
}
