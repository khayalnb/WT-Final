using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.BLL.Services.Interfaces;
using WT.DAL.Data;
using WT.DAL.Models;
using WT.WebAdmin.ViewModels;

namespace WT.WebAdmin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly AppDbContext _appDbContext;
        public CategoryController(ICategoryService categoryService,AppDbContext appDbContext)
        {
            _categoryService = categoryService;
            _appDbContext = appDbContext;
            
        }
        public async Task<IActionResult> Index(CategortFilterVM categortFilterVM)
        {
            categortFilterVM ??= new CategortFilterVM();
            if (categortFilterVM.Query is not null)
                categortFilterVM.Categories =
                    _appDbContext.Categories.
                    Where(q => q.Name.Contains(categortFilterVM.Query))
                   .ToList();
            else
                categortFilterVM.Categories =
                    await _categoryService
                    .GetAllAsync();
            return View(categortFilterVM);
        }
     
        [HttpGet]
        public IActionResult Create()
        {
            Category category = new();
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                category.Created_Date = DateTime.Now;
                category.IsActive = true;
                await _categoryService.AddAsync(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var data =await _categoryService.GetAsync(c => c.Id == id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                category.Updated_Date = DateTime.Now;
                _categoryService.Update(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var data =await _categoryService.GetAsync(c => c.Id == id);
            var subcategory = _appDbContext.SubCategories.Where(p => p.CategoryId == id).ToList();
            ViewBag.Info = "";
            if (subcategory.Count() > 0)
            {
                ViewBag.Info = "Bagli oldugu alt kateqoriyalar var";
            }
            
            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(Category category)
        {
            _appDbContext.SaveChanges();
            _categoryService.Delete(category.Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
