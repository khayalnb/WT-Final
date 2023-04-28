using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.BLL.Message;
using WT.BLL.Services.Interfaces;
using WT.BLL.Utilities;
using WT.DAL.Data;
using WT.DAL.Models;
using WT.WebAdmin.ViewModels;
using System.Text;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace WT.WebAdmin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IBrandService _brandService;
        private readonly ISubCategoryService _subCategoryService;
        private readonly IOfferCompanyService _offerCompanyService;
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IProductService productService,
                                 IBrandService brandService,
                                 ISubCategoryService subCategoryService,
                                 IOfferCompanyService offerCompanyService,
                                 IWebHostEnvironment webHostEnvironment,
                                 AppDbContext appDbContext)
        {
            _productService = productService;
            _brandService = brandService;
            _subCategoryService = subCategoryService;
            _offerCompanyService = offerCompanyService;
            _appDbContext = appDbContext;
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _productService.GetProducts();
            if (data.Count != 0)
            {
                return View(data);
            }
            ViewBag.Info = AllMessage.NullObjMessage("Məhsullar");
            return View();
        }
      
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            Product product = new();
            product.OfferCompanies = await _offerCompanyService.GetAllAsync(o => o.IsActive);
            product.SubCategories = await _subCategoryService.GetAllAsync(sc => sc.IsActive);
            product.Brands = await _brandService.GetAllAsync(b => b.IsActive);
            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            var count = 0;
            List<Image> images = new();
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                string folderPath = @"Documents/ProductImage/";
                foreach (var item in product.FormFiles)
                {
                    count++;
                    if (item.IsImage() is true)
                    {
                        Image image = new();
                        image.ImageName=await FileExtension.PhotoSaveAsync(item,wwwRootPath,folderPath);
                        image.ProductId = product.Id;
                        image.MainImage = count is 1 ? true : false;
                        images.Add(image);
                    }
                    else
                    {
                        TempData["Warning"] = "Zehmet olmasa duzgun format daxil edin. Daxil edilen faylın formatının şəkil olduğundan əmin olun";
                    }
                }
                TempData["success"] = "Product added succesfully";
                product.Images = images;
                product.Created_Date = DateTime.Now;
                product.IsActive = true;
                await _productService.AddAsync(product);
                return RedirectToAction(nameof(Index));


            }
            product.OfferCompanies = await _offerCompanyService.GetAllAsync(o => o.IsActive);
            product.SubCategories = await _subCategoryService.GetAllAsync(sc => sc.IsActive);
            product.Brands = await _brandService.GetAllAsync(b => b.IsActive);
            return View(product);
        }
        [Route("about/{id:int}")]
        public IActionResult Details(int? id)
        {
            if (id is null)
            {
                ViewBag.NullMessage = "Belə id məxsus məhsul yoxdur";
                return View();
            }
            var data = _appDbContext.Products.Where(p => p.Id == id)
                       .Select(p => new Product
                       {
                           Id = p.Id,
                           Name = p.Name,
                           TextParametr = p.TextParametr,
                           IsFreeDelivery = p.IsFreeDelivery,
                           Price = p.Price,
                           Count = p.Count,
                           DisCount = p.DisCount,
                           WarrantyYearNumber=p.WarrantyYearNumber,
                           BrandId = p.Brand.Id,
                           Brand = new Brand {
                               Id = p.Brand.Id,
                               Name = p.Brand.Name
                           },
                           SubCategoryId = p.SubCategory.Id,
                           SubCategory = new SubCategory { 
                               Id = p.SubCategory.Id, 
                               Name = p.SubCategory.Name 
                           }, 
                           ProductParametrs = p.ProductParametrs,
                           OfferCompanyId = p.OfferCompanyId,
                           OfferCompany = new OfferCompany { 
                               Id = p.OfferCompany.Id,
                               Title = p.OfferCompany.Title 
                           },
                           Images = p.Images.Select(i => new Image { 
                               Id = i.Id,
                               ImageName = i.ImageName ,
                               MainImage=i.MainImage
                           }).ToList()
                       }).FirstOrDefault();

            try
            {
                decimal percent = ((decimal)data?.DisCount / (decimal)data?.Price) * 100;
                percent = Math.Round(percent, 1);
                ViewBag.percent = percent;
                string productParametr = data.TextParametr;
                if(productParametr is not null)
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

        
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _productService.GetAsync(s => s.Id == id);
            product.OfferCompanies = await _offerCompanyService.GetAllAsync(o => o.IsActive);
            product.SubCategories = await _subCategoryService.GetAllAsync(sc => sc.IsActive);
            product.Brands = await _brandService.GetAllAsync(b => b.IsActive);
            product.Images =await _appDbContext.Images.Where(i => i.ProductId == id).ToListAsync();
            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            var count = 0;
            List<Image> images = new();
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                string folderPath = @"Documents/ProductImage/";
                foreach (var item in product.FormFiles)
                {
                    count++;
                    if (item.IsImage() is true)
                    {
                        Image image = new();
                        image.ImageName = await FileExtension.PhotoSaveAsync(item, wwwRootPath, folderPath);
                        image.ProductId = product.Id;
                        image.MainImage = count is 1 ? true : false;
                        images.Add(image);
                    }
                    else
                    {
                        TempData["Warning"] = "Zehmet olmasa duzgun format daxil edin. Daxil edilen faylın formatının şəkil olduğundan əmin olun";
                    }
                }
                TempData["success"] = "Product added succesfully";
                product.Images = images;
                product.Created_Date = product.Created_Date;
                product.Updated_Date = DateTime.Now;
                _productService.Update(product);
                return RedirectToAction(nameof(Index));


            }
            return RedirectToAction(nameof(Edit), new { id = product.Id });

        }
        [HttpPost]
        public async Task<JsonResult> Delete(int? id) {

            if (id==null)
            {
                return Json(new { status = false });
            }
            string wwwRootPath = _webHostEnvironment.WebRootPath;
            string folderPath = @"Documents/ProductImage/";
            var data = _appDbContext.Images.Where(i => i.ProductId == id);
            foreach (var item in data)
            {
                FileExtension.Delete(wwwRootPath, folderPath, item.ImageName);
                _appDbContext.Images.Remove(item);
            }
            var product = await _productService.GetAsync(p => p.Id == id);
            _productService.Delete(product.Id);
            return Json(new { msg = "success", status = true });
            
        }
        [HttpPost]
        public async Task<JsonResult> ImageDelete(int? id)
        {
            if (id is null)
            {
                return Json(new { status = false });
            }
            string wwwRootPath = _webHostEnvironment.WebRootPath;
            string folderPath = @"Documents/ProductImage/";
            var data =await _appDbContext.Images.Where(i => i.Id == id).FirstOrDefaultAsync();
            FileExtension.Delete(wwwRootPath, folderPath, data.ImageName);
            _appDbContext.Images.Remove(data);
            await _appDbContext.SaveChangesAsync();
            return Json(new { msg = "success", status = true });
        
        }
        
      
    }
}
