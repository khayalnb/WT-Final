using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using WT.BLL.Services.Interfaces;
using WT.DAL.Models;
using WT.BLL.Message;
using WT.BLL.Utilities;
using Microsoft.AspNetCore.Authorization;

namespace WT.WebAdmin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class OfferCompanyController : Controller
    {
        private readonly IOfferCompanyService _offerCompanyService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public OfferCompanyController(IOfferCompanyService offerCompanyService, IWebHostEnvironment webHostEnvironment)
        {
            _offerCompanyService = offerCompanyService;
            _webHostEnvironment = webHostEnvironment;

        }
       
        public async  Task<IActionResult> Index()
        {
            var data = await _offerCompanyService.GetAllAsync();
            if (data.Count!=0)
            {
                return View(data);
            }
            ViewBag.Info = AllMessage.NullObjMessage("Kampaniya");
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            OfferCompany offerCompany = new();
            return View(offerCompany);
        }

        [HttpPost]
        public async Task<IActionResult> Create(OfferCompany offerCompany)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                string folderPath = @"Documents/OfferCompanyImage/";
                if (offerCompany.FormFile?.IsImage() is true)
                {
                    offerCompany.ImageName = await offerCompany.FormFile.PhotoSaveAsync(wwwRootPath,folderPath);
                    offerCompany.Created_Date = DateTime.Now;
                    offerCompany.IsActive = true;
                    await _offerCompanyService.AddAsync(offerCompany);
                    TempData["success"] = "Product added succesfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Warning"] = "Zehmet olmasa duzgun format daxil edin. Daxil edilen faylın formatının şəkil olduğundan əmin olun";
                    RedirectToAction(nameof(Create),offerCompany);
                }
            }
            return View(offerCompany);
        }
        [HttpGet]
        public async Task< IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var data =await _offerCompanyService.GetAsync(oc=>oc.Id==id);
            if (data == null) return NotFound();
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(OfferCompany offerCompany)
        {
            if (ModelState.IsValid)
            {
                if (offerCompany.FormFile?.IsImage() == true)
                {
                    try
                    {
                        string wwwRootPath = _webHostEnvironment.WebRootPath;
                        string folderPath = @"Documents/OfferCompanyImage/";
                        offerCompany.Created_Date = offerCompany.Created_Date;
                        if (offerCompany.IsActive is not true)
                        {
                            offerCompany.Deleted_Date = DateTime.Now;
                        }
                        offerCompany.Updated_Date = DateTime.Now;
                        FileExtension.Delete(wwwRootPath, folderPath, offerCompany.ImageName);
                        offerCompany.ImageName = await offerCompany.FormFile.PhotoSaveAsync(wwwRootPath, folderPath);
                    }
                    catch (Exception)
                    {
                        offerCompany.ImageName = offerCompany.ImageName;
                    }
                    _offerCompanyService.Update(offerCompany);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    if (offerCompany.IsActive is not true)
                    {
                        offerCompany.Deleted_Date = DateTime.Now;
                    }
                    offerCompany.Updated_Date = DateTime.Now;
                    _offerCompanyService.Update(offerCompany);
                    return RedirectToAction(nameof(Edit),offerCompany);
                }
              
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int ? id)
        {
            var data = await _offerCompanyService.GetAsync(oc => oc.Id == id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(OfferCompany offerCompany)
        {
            if (offerCompany != null)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                string folderPath = @"Documents/OfferCompanyImage/";
                FileExtension.Delete(wwwRootPath , folderPath, offerCompany.ImageName);
                _offerCompanyService.Delete(offerCompany.Id);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id is null)
            {
                return NotFound();
            }
            var data =await  _offerCompanyService.GetAsync(c => c.Id == id);
            if (data is not null)
            {
                return View(data);
            }
            return NotFound();
        }
    }
}
