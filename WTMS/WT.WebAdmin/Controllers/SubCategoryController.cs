using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.BLL.Services.Interfaces;
using WT.DAL.Models;
using WT.WebAdmin.ViewModels;

namespace WT.WebAdmin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SubCategoryController : Controller
    {
        private readonly ISubCategoryService _subCategoryService;
        private readonly ICategoryService _categoryService;
        public SubCategoryController(ISubCategoryService subCategoryService, ICategoryService categoryService) {
            _subCategoryService = subCategoryService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            List<SubCategory> subCategories = await _subCategoryService.GetAllSubParentCategory();
            if (subCategories is not null)
            {
                return View(model: subCategories);
            }
            return View();
        }

        [HttpGet]
        public async Task< IActionResult> Create()
        {
            SubCategoryParentCategoryVM subCategoryParentCategoryVM = new();
            subCategoryParentCategoryVM.Categories = await _categoryService.GetAllAsync(c => c.IsActive == true); ;
            subCategoryParentCategoryVM.SubCategory = new();
            return View(subCategoryParentCategoryVM);
        }
        [HttpPost]
        public async Task<IActionResult> Create(SubCategory subCategory)
        {
            if (ModelState.IsValid)
            {
                subCategory.Created_Date = DateTime.Now;
                subCategory.IsActive = true;
                await _subCategoryService.AddAsync(subCategory);
                return RedirectToAction(nameof(Index));
            }
            return View(subCategory);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            SubCategoryParentCategoryVM subCategoryParentCategoryVM = new();
            subCategoryParentCategoryVM.Categories = await _categoryService.GetAllAsync(c => c.IsActive == true);
            subCategoryParentCategoryVM.SubCategory = await _subCategoryService.GetAsync(c => c.Id == id); ;
            return View(subCategoryParentCategoryVM);
            
        }

        [HttpPost]
        public IActionResult Edit(SubCategoryParentCategoryVM subCategoryParentCategoryVM)
        {
            if (ModelState.IsValid)
            {
                subCategoryParentCategoryVM.SubCategory.Updated_Date = DateTime.Now;
                _subCategoryService.Update(subCategoryParentCategoryVM.SubCategory);
                return RedirectToAction(nameof(Index));
            }
            return View(subCategoryParentCategoryVM.SubCategory);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _subCategoryService.GetById(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(SubCategory subCategory)
        {
            _subCategoryService.Delete(subCategory.Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
