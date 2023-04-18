using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.BLL.Message;
using WT.BLL.Services.Interfaces;
using WT.DAL.Models;

namespace WT.WebAdmin.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;
        private readonly ISubCategoryService _subCategoryService;

        public BrandController(IBrandService brandService,ISubCategoryService subCategoryService)
        {
            _brandService = brandService;
            _subCategoryService = subCategoryService;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _brandService.GetAllAsync();
            ViewBag.Info = AllMessage.NullObjMessage("Brend");
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            Brand brand = new();
            brand.SubCategories =await _subCategoryService.GetAllAsync(s => s.IsActive == true);
            return View(brand);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Brand brand)
        {
            if (ModelState.IsValid)
            {
                brand.Created_Date = DateTime.Now;
                brand.IsActive = true;
                await _brandService.AddAsync(brand);
                return RedirectToAction(nameof(Index));
            }
            return View(brand);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var data = await _brandService.GetAsync(c => c.Id == id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Brand brand)
        {
            if (ModelState.IsValid)
            {
                brand.Updated_Date = DateTime.Now;
                _brandService.Update(brand);
                return RedirectToAction(nameof(Index));
            }
            return View(brand);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _brandService.GetAsync(c => c.Id == id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(Brand brand)
        {
            _brandService.Delete(brand.Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
