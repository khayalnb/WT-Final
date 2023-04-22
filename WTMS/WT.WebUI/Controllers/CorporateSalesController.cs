using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.DAL.Data;

namespace WT.WebUI.Controllers
{
    public class CorporateSalesController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public CorporateSalesController(AppDbContext appDbContext) => _appDbContext = appDbContext;
        public IActionResult Index()
        {
            var data = _appDbContext.CorporativeSales.FirstOrDefault();
            if (data is null)
            {
                ViewBag.Info = "Karparativ siyahı boşdur";
                return View();
            }
            return View(data);
        }
    }
}
