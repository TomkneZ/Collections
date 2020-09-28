using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Collections.Domain;
using Collections.Domain.Entities;
using Collections.Models;
using Collections.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Collections.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceCollectionsController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        private static string ownerId;

        public ServiceCollectionsController(UserManager<IdentityUser> userMgr, DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
            this.userManager = userMgr;
        }
        public async System.Threading.Tasks.Task<IActionResult> Index(string id)
        {
            if (id != null) { ownerId = id; }
            var user = await userManager.FindByIdAsync(ownerId);
            ViewBag.currentUserName = user.UserName;
            return View(dataManager.Collections.GetUsersCollections(ownerId));
        }
        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new Collection() : dataManager.Collections.GetCollectionById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(Collection model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (model.Num1Name != null)
                {
                    model.itemFields = model.itemFields | 1;

                }
                if (model.Num2Name != null)
                {
                    model.itemFields = model.itemFields | 2;

                }
                if (model.Num3Name != null)
                {
                    model.itemFields = model.itemFields | 4;

                }
                if (model.Input1Name != null)
                {
                    model.itemFields = model.itemFields | 8;
                }
                if (model.Input2Name != null)
                {
                    model.itemFields = model.itemFields | 16;
                }
                if (model.Input3Name != null)
                {
                    model.itemFields = model.itemFields | 32;
                }
                if (model.Textarea1Name != null)
                {
                    model.itemFields = model.itemFields | 64;
                }
                if (model.Textarea2Name != null)
                {
                    model.itemFields = model.itemFields | 128;
                }
                if (model.Textarea3Name != null)
                {
                    model.itemFields = model.itemFields | 256;
                }
                if (model.Date1Name != null)
                {
                    model.itemFields = model.itemFields | 512;
                }
                if (model.Date2Name != null)
                {
                    model.itemFields = model.itemFields | 1024;
                }
                if (model.Date3Name != null)
                {
                    model.itemFields = model.itemFields | 2048;
                }
                if (model.Checkbox1Name != null)
                {
                    model.itemFields = model.itemFields | 4096;
                }
                if (model.Checkbox2Name != null)
                {
                    model.itemFields = model.itemFields | 8192;
                }
                if (model.Checkbox3Name != null)
                {
                    model.itemFields = model.itemFields | 16384;
                }
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                model.ownerId = ownerId;
                dataManager.Collections.SaveCollection(model);
                return RedirectToAction(nameof(ServiceCollectionsController.Index), nameof(ServiceCollectionsController).CutController());

            }
            return View(model);

        }
        [HttpPost]
        public IActionResult Delete(Guid id, string ownerId)
        {
            ViewBag.currentUserId = ownerId;
            dataManager.Collections.DeleteCollection(id);
            return RedirectToAction(nameof(ServiceCollectionsController.Index), nameof(ServiceCollectionsController).CutController());
        }
    }
}