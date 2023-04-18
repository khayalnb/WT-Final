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
using WT.DAL.Repository.Interfaces;

namespace WT.BLL.Services
{
    public class ProductService: GlobalService<Product>, IProductService
    {
        private readonly AppDbContext _appDbContext;
        public ProductService(AppDbContext appDbContext) : base(appDbContext) => _appDbContext = appDbContext;

        public async Task<List<Product>> GetProducts()
        {
            var data = await _appDbContext.Products
                         .Select(p => new Product
                         {
                             Id = p.Id,
                             Name = p.Name,
                             TextParametr = p.TextParametr,
                             IsFreeDelivery = p.IsFreeDelivery,
                             IsActive=p.IsActive,
                             Price = p.Price,
                             Count = p.Count,
                             DisCount = p.DisCount,
                             WarrantyYearNumber = p.WarrantyYearNumber,
                             BrandId = p.Brand.Id,
                             Brand = new Brand
                             {
                                 Id = p.Brand.Id,
                                 Name = p.Brand.Name
                             },
                             SubCategoryId = p.SubCategory.Id,
                             SubCategory = new SubCategory
                             {
                                 Id = p.SubCategory.Id,
                                 Name = p.SubCategory.Name
                             },
                             ProductParametrs = p.ProductParametrs,
                             OfferCompanyId = p.OfferCompanyId,
                             OfferCompany = new OfferCompany
                             {
                                 Id = p.OfferCompany.Id,
                                 Title = p.OfferCompany.Title
                             },
                             Images = p.Images.Select(i => new Image
                             {
                                 Id = i.Id,
                                 ImageName = i.ImageName
                             }).ToList()
                         }).ToListAsync();
            return data;
           
        }
    }
}
