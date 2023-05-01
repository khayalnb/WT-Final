using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.BLL.Services.Interfaces;
using WT.DAL.Data;
using WT.DAL.Models;
using WT.WebUI.ViewModels;

namespace WT.WebUI.Controllers
{
    public class ProductController : Controller
    {
        readonly AppDbContext _context;
        readonly IProductService _productService;
        public ProductController(AppDbContext context, IProductService service) 
        {
            _context = context;
            _productService = service;
        
        }

        [HttpGet]
        public async Task<IActionResult> GetBySubCategoryId(int? id, ProductVM productVM)
        {
            productVM ??= new();
            var source = _context.Products.
                Where(p => p.SubCategoryId == id || p.IsActive == true)
                      .Include(p => p.SubCategory)
                      .Include(i => i.Images)
                      .Include(b => b.Brand)
                      .AsQueryable();

            productVM.Products = await GetFilter(source, productVM.ProductFilterVM).ToListAsync();
            productVM.Brands = await _context.Brands.Where(b => b.IsActive == true).ToListAsync();
            productVM.Path = Request.Path.ToString();
            return View("ProductList",productVM);
        }
        [HttpGet]
        public async Task<IActionResult> GetByBrandId(int? id, ProductVM productVM)
        {
            productVM ??= new();
            var source = _context.Products.Where(p => p.BrandId == id )
                      .Include(p => p.SubCategory)
                      .Include(i => i.Images)
                      .Include(b => b.Brand)
                      .OrderByDescending(p => p.Created_Date).AsQueryable();
            productVM.Products = await GetFilter(source, productVM.ProductFilterVM).ToListAsync();
            productVM.Brands = await _context.Brands.Where(b => b.IsActive == true).ToListAsync();
            productVM.Path = Request.Path.ToString();
            return View("ProductList",productVM);
        }

        [HttpGet]
        public async Task<IActionResult> GetByName(string name, ProductVM productVM)
        {
            if (string.IsNullOrEmpty(name)) return RedirectToAction(controllerName:"Home",actionName:"Index");
            productVM ??= new();
            var source = _context.Products
                      .Include(p => p.SubCategory)
                      .Include(i => i.Images)
                      .Include(b => b.Brand)
                      .Where(p => p.Name.ToLower().Trim().Contains(name.Trim().ToLower()))
                      .OrderByDescending(p => p.Created_Date).AsQueryable();
            productVM.Products = await GetFilter(source, productVM.ProductFilterVM).ToListAsync();
            productVM.Brands = await _context.Brands.Where(b => b.IsActive == true).ToListAsync();
            productVM.Path = Request.Path.ToString();
            productVM.PName = name;
            return View("ProductList", productVM);
        }

        private IQueryable<Product> GetFilter(IQueryable<Product> source, ProductFilterVM filterVM) 
        {
            var isDesc = filterVM?.LessToMore ?? false;
            if (isDesc)
                source = source.OrderByDescending(s => s.Price);
            else
                source = source.OrderBy(s => s.Price);
            if (filterVM is null) return source;
            var brandIds = filterVM.BrandSearch;
            var maxprice = filterVM.MaxPrice; 
            var minprice = filterVM.MinPrice;   

            if (brandIds is not null && brandIds.Any())
                source = source.Where(s => brandIds.Contains(s.BrandId));
            
            if (maxprice is not null)
                source = source.Where(s => s.Price < maxprice);

            if (minprice is not null)
                source = source.Where(s => minprice < s.Price);

            return source;
        }

        public async Task<IActionResult> ProductDetails(int? id)
        {
            if (id is null)
            {
                ViewBag.NullMessage = "Belə id məxsus məhsul yoxdur";
                return View();
            }
            var data = await _context.Products.Where(p => p.Id == id)
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
                       }).FirstOrDefaultAsync();

            try
            {
                decimal percent = ((decimal)data?.DisCount / (decimal)data?.Price) * 100;
                percent = Math.Round(percent, 1);
                ViewBag.percent = percent;
                string productParametr = data.TextParametr;
                if (productParametr is not null)
                {
                    string[] split = productParametr.Split(",");
                    ViewBag.Specifications = split;
                }
            }
            catch (Exception)
            {

                if (data is null)
                {
                    ViewBag.NullMessage = "Məhsulun tapılmadı";
                    return View();
                }
            }


            return View(data);
        }


    }
}
