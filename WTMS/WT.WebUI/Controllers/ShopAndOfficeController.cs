using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.BLL.Services.Interfaces;

namespace WT.WebUI.Controllers
{
    public class ShopAndOfficeController : Controller
    {
        private readonly IShopAndOfficeService _shopAndOfficeService;
        public ShopAndOfficeController(IShopAndOfficeService shopAndOfficeService)
        {
            _shopAndOfficeService = shopAndOfficeService;
        }
        public async Task<IActionResult> Index()
        {
            var data =await _shopAndOfficeService.GetAllAsync();
            return View(data);
        }
    }
}
