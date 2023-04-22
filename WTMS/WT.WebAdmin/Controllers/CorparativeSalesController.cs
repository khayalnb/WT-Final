using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.DAL.Data;
using WT.DAL.Models;

namespace WT.WebAdmin.Controllers
{
    public class CorparativeSalesController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public CorparativeSalesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var data = _appDbContext.CorporativeSales.FirstOrDefault();
            if (data is not null)
            {
                return View(data);
            }
            ViewBag.Info = "Karparativ satış boşdur";
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            CorporativeSale corporativeSale = new();
            return View(corporativeSale);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CorporativeSale corporativeSale)
        {
            if (ModelState.IsValid)
            {
                await _appDbContext.CorporativeSales.AddAsync(corporativeSale);
                await _appDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(corporativeSale);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            var data = await _appDbContext.CorporativeSales.FindAsync(id);
            return View("Create", model:data);
        } 
        [HttpPost]
        public IActionResult Edit(CorporativeSale corporativeSale)
          {
            if (ModelState.IsValid)
            {
                _appDbContext.CorporativeSales.Update(corporativeSale);
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(corporativeSale);
        }
        [HttpPost]
        public IActionResult Delete(int ? id)
        {
            if (id is null)
            return Json(new { status = false }); 
            var data = _appDbContext.CorporativeSales.Where(i => i.Id == id).FirstOrDefault();
            _appDbContext.CorporativeSales.Remove(data);
            _appDbContext.SaveChanges();
            return Json(new { msg = "success", status = true });
        }
    }
}
