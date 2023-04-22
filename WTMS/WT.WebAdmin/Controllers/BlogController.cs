using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WT.BLL.Services.Interfaces;
using WT.DAL.Dtos;
using WT.DAL.Models;

namespace WT.WebAdmin.Controllers
{
    public class BlogController : Controller
    {
        private readonly IGenericService<BlogDto, Blog> _genericService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BlogController(IGenericService<BlogDto, Blog> genericService, IWebHostEnvironment webHostEnvironment)
        {
            _genericService = genericService;
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> ActiveBlog()
        {
            var activeBlogList = await _genericService.GetListAsync(s=>s.IsActive==true);
            return View(model:activeBlogList);
        }

        public IActionResult DeactiveBlog()
        {
            var deaktiveBlogList = _genericService.GetListAsync(s=>s.IsActive==false);
            return View(model: deaktiveBlogList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            BlogDto blogDto = new BlogDto();
            return View( blogDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(BlogDto itemDto)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                string folderPath = @"Documents\BlogImages";
                string fullPath = Path.Combine(wwwRootPath, folderPath);
                string fileName = Guid.NewGuid().ToString();
                string extension = Path.GetExtension(itemDto.FormFile.FileName);
                string realPath = Path.Combine(fullPath, fileName + extension);
                using (var fileStream = new FileStream(realPath, FileMode.Create))
                {
                    await itemDto.FormFile.CopyToAsync(fileStream);
                }
                itemDto.ImageName  = fileName + extension;
                await _genericService.AddAsync(itemDto);
                TempData["success"] = "Product added succecfully";
                return RedirectToAction("ActiveBlog");
            }


            return View(itemDto);
        }

        public async Task<IActionResult> Details(int id)
        {
            var data = await _genericService.GetByIdAsync(id);
            return View(data);
        }




    }
}
