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
            return View(data);
        }
        public IActionResult BlogDetails()
        {
            return View();
        }
    }
}
