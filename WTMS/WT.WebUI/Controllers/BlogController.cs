using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.DAL.Data;
using WT.DAL.Models;

namespace WT.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public BlogController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _appDbContext.Blogs.Where(b => b.IsActive == true).ToListAsync();
            if (data.Count <= 0)
            {
                ViewBag.Info = "Blog siyahınız boşdur";
                return View();
            }
            return View(data);
           
        }
        public async Task<IActionResult> BlogDetails(int ? id)
        {
            var data =await _appDbContext.Blogs.Where(b => b.Id == id).FirstOrDefaultAsync();
            return View(data);
        }
    }
}
