using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Collections.Domain;
using Collections.Domain.Entities;
using Collections.Service;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq;

namespace Collections.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AddItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        private static string collectionId;
        public AddItemsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }
        /* public IActionResult Index(string id)
         {
             if (id != null) { collectionId = id; }
             return View(dataManager.Items.GetItemsByCollectionId(collectionId));
         }*/
        public IActionResult Index(string id, string name, string sortBy)
        {
            if (id != null) { collectionId = id; }
            IQueryable<Item> items = dataManager.Items.GetItemsByCollectionId(collectionId);
            if (!String.IsNullOrEmpty(name))
            {
                items = items.Where(p => p.Name.Contains(name));
            }
            if (!String.IsNullOrEmpty(sortBy))
            {
                switch (sortBy)
                {
                    case "Datemax":
                        items = items.OrderBy(s => s.DateAdded);
                        break;
                    case "Datemin":
                        items = items.OrderByDescending(s => s.DateAdded);
                        break;
                    case "AlphAZ":
                        items = items.OrderBy(s => s.Name);
                        break;
                    case "AlphZA":
                        items = items.OrderByDescending(s => s.Name);
                        break;
                }
            }
            return View(items);
        }
        public IActionResult Edit(Guid id)
        {
            Item entity = id == default ? new Item() : dataManager.Items.GetItemById(id);
            Collection collection = dataManager.Collections.GetCollectionById(collectionId);
            GetItemFieldsNames(collectionId);
            entity.itemFields = collection.itemFields;
            entity.CollectionId = collectionId;
            if (id == null)
            {
                collection.numberOfItems += 1;
                dataManager.Collections.SaveCollection(collection);
            }
            dataManager.Items.SaveItem(entity);
            return View(entity);
        }

        public void GetItemFieldsNames(string collectionId)
        {
            Collection collection = dataManager.Collections.GetCollectionById(collectionId);
            ViewData["Num1Name"] = collection.Num1Name;
            ViewData["Num2Name"] = collection.Num2Name;
            ViewData["Num3Name"] = collection.Num3Name;
            ViewData["Input1Name"] = collection.Input1Name;
            ViewData["Input2Name"] = collection.Input2Name;
            ViewData["Input3Name"] = collection.Input3Name;
            ViewData["Textarea1Name"] = collection.Textarea1Name;
            ViewData["Textarea2Name"] = collection.Textarea2Name;
            ViewData["Textarea3Name"] = collection.Textarea3Name;
            ViewData["Date1Name"] = collection.Date1Name;
            ViewData["Date2Name"] = collection.Date2Name;
            ViewData["Date3Name"] = collection.Date3Name;
            ViewData["Checkbox1Name"] = collection.Checkbox1Name;
            ViewData["Checkbox2Name"] = collection.Checkbox2Name;
            ViewData["Checkbox3Name"] = collection.Checkbox3Name;
        }

        [HttpPost]
        public IActionResult Edit(Item model)
        {
            if (ModelState.IsValid)
            {
                model.CollectionId = collectionId;
                dataManager.Items.SaveItem(model);
                return RedirectToAction(nameof(AddItemsController.Index), nameof(AddItemsController).CutController());
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.Items.DeleteItem(id);
            return RedirectToAction(nameof(AddItemsController.Index), nameof(AddItemsController).CutController());
        }
    }
}