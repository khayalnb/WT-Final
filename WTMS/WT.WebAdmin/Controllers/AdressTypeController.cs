using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.BLL.Services.Interfaces;
using WT.DAL.Models;

namespace WT.WebAdmin.Controllers
{
    public class AdressTypeController : Controller
    {
        private readonly IAdressTypeService _adressTypeService;
        public AdressTypeController(IAdressTypeService adressTypeService) => _adressTypeService = adressTypeService;
       
        public async Task<IActionResult> Index()
        {
            var data = await _adressTypeService.GetAllAsync();
            if (data is not null)
            {
                return View(model: data);
            }
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            AdressType adressType = new(); 
            return View(adressType);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AdressType adressType)
        {
            if (ModelState.IsValid)
            {
                adressType.Created_Date = DateTime.Now;
                adressType.IsActive = true;
                await _adressTypeService.AddAsync(adressType);
                return RedirectToAction(nameof(Index));
            }
            return View(adressType);
        }
    }
}
