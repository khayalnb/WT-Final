using Microsoft.AspNetCore.Mvc;
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
    public class CampaignController : Controller
    {
        private readonly IOfferCompanyService _offerCompanyService;
        private readonly AppDbContext _appDbContext;
        public CampaignController(IOfferCompanyService offerCompanyService, AppDbContext appDbContext)
        {
            _offerCompanyService = offerCompanyService;
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var data =await _offerCompanyService.GetAllAsync(o=>o.IsActive==true);
            if (data.Count !<= 0)
            {
                ViewBag.Info = "Kompaniya siyahınız boşdur";
                return View();
            }
            return View(data);
        }

        public async Task<IActionResult> CampaignDetails(int? id)
        {
            var data = await _offerCompanyService.GetAsync(c => c.Id == id);
            var products = _appDbContext.Products.Where(p => p.OfferCompanyId == id)
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
                              ImageName = i.ImageName
                          }).ToList()
                      }).ToList();
            CompaignVM compaignVM = new();
            compaignVM.OfferCompany = data;
            compaignVM.Products = products;
            return View(compaignVM);
        }
    }
}
