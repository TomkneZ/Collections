using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Collections.Models;
using System;

namespace Collections.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userMgr, SignInManager<IdentityUser> signinMgr)
        {
            userManager = userMgr;
            signInManager = signinMgr;
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(new LoginViewModel());
        }

        [AllowAnonymous]
        public IActionResult Register(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(new RegisterViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Register(string UserName, string Email, string Password)
        {
            Random rnd = new Random();
            IdentityUser user = new IdentityUser(UserName);            
            user.NormalizedUserName = UserName.ToUpper();
            user.Email = Email;
            user.NormalizedEmail = Email.ToUpper();
            user.Id = "2a00001d-3e00-99ez-z00e-d6574a" + rnd.Next(1000,9999).ToString()+"c8";
            IdentityResult result = await userManager.CreateAsync(user, Password);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "user");
                return RedirectToAction("Login", "Account");
            }
            else
            {
                foreach (IdentityError error in result.Errors)
                {
                    //ModelState.AddModelError("", error.ToString());
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(new RegisterViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByNameAsync(model.UserName);
                IList<string> roles = new List<string> { };
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);
                    if (result.Succeeded)
                    {
                        roles = await userManager.GetRolesAsync(user);
                        returnUrl = returnUrl + roles[0]+"?id="+user.Id;
                        return Redirect(returnUrl ?? " / ");
                    }
                }
                ModelState.AddModelError(nameof(LoginViewModel.UserName), "Incorrect login or password");
            }           
            return View();
        }
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}