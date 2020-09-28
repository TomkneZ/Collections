using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Collections.Domain;
using Collections.Models;
using Collections.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Collections.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        AppDbContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public HomeController(UserManager<IdentityUser> userMgr, AppDbContext context, RoleManager<IdentityRole> roleMgr)
        {
            userManager = userMgr;
            _context = context;
            roleManager = roleMgr;
        }
        public async Task<IActionResult> Edit(string Id)
        {
            var user = await userManager.FindByIdAsync(Id);
            return View(user);
        }
        public async Task<IActionResult> EditRole(string Id)
        {
            IdentityUser user = await userManager.FindByIdAsync(Id);
            if (user != null)
            {
                var userRoles = await userManager.GetRolesAsync(user);
                var allRoles = roleManager.Roles.ToList();
                ChangeRoleModel model = new ChangeRoleModel
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                    UserRoles = userRoles,
                    AllRoles = allRoles
                };
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Edit(string Id, string UserName, string Email)
        {
            var user = await userManager.FindByIdAsync(Id);
            if (user != null)
            {
                user.UserName = UserName;
                user.NormalizedUserName = UserName.ToUpper();
                user.Email = Email;
                user.NormalizedEmail = Email.ToUpper();
                IdentityResult result = await userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.ToString());
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "User isn't found ");
            }
            return View();
        }
        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(string id, string role)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                var removedRole = await userManager.GetRolesAsync(user);
                removedRole.Remove(role);
                await userManager.AddToRoleAsync(user, role);
                await userManager.RemoveFromRolesAsync(user, removedRole);
            }
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            await userManager.DeleteAsync(user);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}