using System;
using Microsoft.AspNetCore.Mvc;
using Collections.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.Features;
using System.Linq;
using Collections.Domain.Entities;

namespace Collections.Controllers
{
    public class ServicesController : Controller
    {
        private readonly DataManager dataManager;

        public ServicesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.Items.GetItemsByCollectionId(id.ToString()));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageServices");
            return View(dataManager.Collections.GetCollections());             
        }

        public IActionResult Search(string searchString)
        {            
            var items = dataManager.Items.GetItems().Where(i => i.Name.Contains(searchString))
            .Union(dataManager.Items.GetItems().Where(i => i.Tag.Contains(searchString)))
            .Union(dataManager.Items.GetItems().Where(i => i.Num1Value.ToString().Contains(searchString)))
            .Union(dataManager.Items.GetItems().Where(i => i.Num2Value.ToString().Contains(searchString)))
            .Union(dataManager.Items.GetItems().Where(i => i.Num3Value.ToString().Contains(searchString)))
            .Union(dataManager.Items.GetItems().Where(i => i.Textarea1Value.Contains(searchString)))
            .Union(dataManager.Items.GetItems().Where(i => i.Textarea2Value.Contains(searchString)))
            .Union(dataManager.Items.GetItems().Where(i => i.Textarea3Value.Contains(searchString)))
            .Union(dataManager.Items.GetItems().Where(i => i.Input1Value.Contains(searchString)))
            .Union(dataManager.Items.GetItems().Where(i => i.Input2Value.Contains(searchString)))
            .Union(dataManager.Items.GetItems().Where(i => i.Input3Value.Contains(searchString)))
            .Union(dataManager.Items.GetItems().Where(i => i.Date1Value.Contains(searchString)))
            .Union(dataManager.Items.GetItems().Where(i => i.Date2Value.Contains(searchString)))
            .Union(dataManager.Items.GetItems().Where(i => i.Date3Value.Contains(searchString)));       
            return View(items);
        }       
    }
}