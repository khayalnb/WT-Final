using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using WT.DAL.Data;
using WT.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace WT.WebUI.Controllers
{
    public class CustomerOperationController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public CustomerOperationController(AppDbContext appDbContext) => _appDbContext = appDbContext;

        public IActionResult LikeIndex() => View();
       

        public JsonResult GetProduct(List<int> likedProductIds)
        {
            if (likedProductIds is null) return Json(new { success = false });
            List<Product> products = _appDbContext.Products.Where(p => likedProductIds.Contains(p.Id)).Select(p => new Product
            {
                Id = p.Id,
                Name = p.Name,
                TextParametr = p.TextParametr,
                IsFreeDelivery = p.IsFreeDelivery,
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
                    ImageName = i.ImageName,
                    MainImage = i.MainImage
                }).ToList()
            }).ToList(); ;
            return Json(new { success = true, data = products });
        }

    }
}
