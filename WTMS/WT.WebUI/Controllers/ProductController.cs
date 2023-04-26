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
            var source = _context.Products.Where(p => p.BrandId == id || p.IsActive == true)
                      .Include(p => p.SubCategory)
                      .Include(i => i.Images)
                      .Include(b => b.Brand)
                      .OrderByDescending(p => p.Created_Date).AsQueryable();
            productVM.Products = await GetFilter(source, productVM.ProductFilterVM).ToListAsync();
            productVM.Brands = await _context.Brands.Where(b => b.IsActive == true).ToListAsync();
            productVM.Path = Request.Path.ToString();
            return View("ProductList",productVM);
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

    }
}
