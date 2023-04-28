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

namespace WT.WebUI.Controllers
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

        [HttpGet(nameof(Login))]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost(nameof(Login))]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }
            AppUser appUser =await _userManager.FindByEmailAsync(loginVM.Email);

            if (appUser is null)
            {
                ModelState.AddModelError("", AllMessage.FailedLogin);
                return View(loginVM);
            }
            var signinResult= await _signInManager.PasswordSignInAsync(appUser, loginVM.Password, loginVM.RememberMe,true);

            if (signinResult.IsNotAllowed)
            {
                ModelState.AddModelError("", AllMessage.ConfirmPassword);
                return View(loginVM);
            }

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

            return RedirectToAction(actionName:"Index",controllerName:"Home");
        }

        [HttpGet(nameof(Register))]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost(nameof(Register))]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View(registerVM);
            }
            AppUser appUser = new AppUser();
            appUser.FirstName = registerVM.FirstName;
            appUser.LastName = registerVM.LastName;
            appUser.UserName = registerVM.Email;
            appUser.Email = registerVM.Email;

            var result = await _userManager.CreateAsync(appUser, registerVM.Password);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(registerVM);
            }
            var roleResult=await _userManager.AddToRoleAsync(appUser, UserRole.Member.ToString());
            if (!roleResult.Succeeded)
            {
                foreach (var item in roleResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(registerVM);
            }

            return RedirectToAction(typeof(Index).ToString(), typeof(HomeController));
          
        }

        public async Task<IActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
               await _signInManager.SignOutAsync();
            }
            return RedirectToAction("Index","Home");
        }

        public async Task CreateRoles()
        {
            foreach (var item in Enum.GetValues(typeof(UserRole)))
            {
                if (!await _roleManager.RoleExistsAsync(item.ToString()))
                {
                    await _roleManager.CreateAsync(new IdentityRole(item.ToString()));
                }
            }
        }
    }
}
