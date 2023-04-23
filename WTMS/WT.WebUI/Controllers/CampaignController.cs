using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.BLL.Services.Interfaces;
using WT.WebUI.ViewModels;

namespace WT.WebUI.Controllers
{
    public class CampaignController : Controller
    {
        private readonly IOfferCompanyService _offerCompanyService;
        private readonly IProductService _productService;
        public CampaignController(IOfferCompanyService offerCompanyService, IProductService productService)
        {
            _offerCompanyService = offerCompanyService;
            _productService = productService;
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

        public async Task<IActionResult> CompaignDetails(int? id)
        {
            var data = await _offerCompanyService.GetAsync(c => c.Id == id);
            var products = await _productService.GetAllAsync(p => p.OfferCompanyId == id);
            CompaignVM compaignVM = new();
            compaignVM.OfferCompany = data;
            compaignVM.Products = products;
            return View(compaignVM);
        }
    }
}
