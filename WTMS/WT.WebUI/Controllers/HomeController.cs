using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WT.BLL.Services.Interfaces;
using WT.DAL.Data;
using WT.DAL.Models;
using WT.WebUI.Models;
using WT.WebUI.ViewModels;

namespace WT.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly IBrandService _brandService;
        private readonly IOfferCompanyService _offerCompanyService;
        private readonly AppDbContext _appDbContext;
        //private readonly IHttpContextAccessor _httpContextAccessor;
        public HomeController(IBrandService brandService,
                              IProductService productService,
                              IOfferCompanyService offerCompanyService,
                              AppDbContext appDbContext)
        {
            _brandService = brandService;
            _productService = productService;
            _offerCompanyService = offerCompanyService;
            _appDbContext = appDbContext;
            //_httpContextAccessor = httpContextAccessor;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Count = _appDbContext.Products.Where(n => n.IsActive == true).Count();
            HomeVM homeVM = new();
            homeVM.Brands =await _brandService.GetAllAsync(b=>b.IsActive==true);
            homeVM.Products= await _appDbContext.Products.Where(p => p.IsActive == true)
                      .Select(p => new Product
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
                              MainImage=i.MainImage
                          }).ToList()
                      }).OrderByDescending(p => p.Id).Take(4).ToListAsync();
            homeVM.OfferCompanies= await _offerCompanyService.GetAllAsync(b => b.IsActive == true);
            return View(homeVM);
        }

        public async Task<IActionResult> LoadMore(int skip = 4, int take = 2)
        {
            var dataList = await _appDbContext.Products.Where(p => p.IsActive == true)
                      .Select(p => new Product
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
                      }).OrderByDescending(p => p.Id)
                        .Skip(skip).Take(take)
                        .ToListAsync();

            return PartialView("_ProductPartial", model: dataList);

        }
 
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
