using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.BLL.Message;
using WT.BLL.ViewModels.Account;
using WT.DAL.Enums;
using WT.DAL.Models.Identity;

namespace WT.WebAdmin.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AccountController(UserManager<AppUser> userManager,
                                 RoleManager<IdentityRole> roleManager,
                                 SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login(string  returnUrl)
        {
            return View(new LoginVM { ReturnUrl = returnUrl });
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }
            AppUser appUser = await _userManager.FindByEmailAsync(loginVM.Email);

            if (appUser is null)
            {
                ModelState.AddModelError("", AllMessage.FailedLogin);
                return View(loginVM);
            }
            var signinResult = await _signInManager.CheckPasswordSignInAsync(appUser, loginVM.Password, true);

            if (signinResult.IsNotAllowed)
            {
                ModelState.AddModelError("", AllMessage.ConfirmPassword);
                return View(loginVM);
            }
            var isInRole = await _userManager.IsInRoleAsync(appUser, UserRole.Admin.ToString());
            if (signinResult.IsLockedOut)
            {
                ModelState.AddModelError("", AllMessage.AccountBlock);
                return View(loginVM);
            }

            if (!signinResult.Succeeded)
            {
                ModelState.AddModelError("", AllMessage.FailedLogin);
                return View(loginVM);
            }
            else if(!isInRole)
            {
                ModelState.AddModelError("", AllMessage.FailedLogin);
                return View(loginVM);
            }
            else if(isInRole && signinResult.Succeeded)
            {
                await _signInManager.SignInAsync(appUser, false);
                if (!string.IsNullOrEmpty(loginVM?.ReturnUrl)) return Redirect(loginVM.ReturnUrl);
                return RedirectToAction(actionName: "Index", controllerName: "Home");
            }
            return View(loginVM);

        }





        public async Task<IActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await _signInManager.SignOutAsync();
            }
            return RedirectToAction(nameof(Login));
        }
    }
}
