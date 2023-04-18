using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.BLL.Services.Interfaces;
using WT.DAL.Models;

namespace WT.WebAdmin.Controllers
{
    public class ShopAndOfficeController : Controller
    {
        private readonly IShopAndOfficeService _shopAndOfficeService;
        private readonly IAdressTypeService _adressTypeService;
        public ShopAndOfficeController (IShopAndOfficeService shopAndOfficeService,
                                        IAdressTypeService adressTypeService)
        {
            _shopAndOfficeService = shopAndOfficeService;
            _adressTypeService = adressTypeService;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _shopAndOfficeService.GetAllShopAndOffice();
            if (data is not null)
            {
                return View(model: data);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ShopAndOffice shopAndOffice = new();
            shopAndOffice.AdressTypes = await _adressTypeService.GetAllAsync(a => a.IsActive == true);
            return View(shopAndOffice);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ShopAndOffice shopAndOffice)
        {
            if (ModelState.IsValid)
            {
                shopAndOffice.Created_Date = DateTime.Now;
                shopAndOffice.IsActive = true;
                await _shopAndOfficeService.AddAsync(shopAndOffice);
                return RedirectToAction(nameof(Index));
            }
            return View(shopAndOffice);
        }
    }
}
