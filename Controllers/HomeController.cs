using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Collections.Domain;
using Collections.Domain.Entities;
using Collections.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Collections.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index(Guid id)
        {
            MainPageViewModel mpvm = new MainPageViewModel();
            mpvm.latestItems = dataManager.Items.GetLatestItems();
            mpvm.bigestCollections = dataManager.Collections.GetBigestCollections();
            return View(mpvm);
        }
    }
}