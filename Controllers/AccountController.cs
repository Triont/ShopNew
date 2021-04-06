using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewShopApp.ModelView;
using NewShopApp.Models;
using NewShopApp.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace CustomIdentityApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly EmailSendService emailSendService;

        public AccountController(UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager,
            EmailSendService emailSendService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            this.emailSendService = emailSendService;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser { Email = model.Email, UserName = model.Name   };
                // добавляем пользователя
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    // установка куки
                    await _signInManager.SignInAsync(user, false);
                    IdentityRole identityRole = new IdentityRole();
                    identityRole.Name = "Admin";
                    identityRole.NormalizedName = "ADMIN";
                    IdentityRole identity = new IdentityRole("User");
                await    _roleManager.CreateAsync(identityRole);
                      await _userManager.AddToRoleAsync(user, "Admin");


                    var c = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callback = Url.Action("ConfirmEmail", "Account", new { UserId = user.Id, code = c }, protocol: HttpContext.Request.Scheme);
                    await EmailSendService.SendEmailAsync(model.Email, "Confirm your account",
                     $"Confirm registration : <a href='{callback}'>link</a>");
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return View("Error");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View("Error");
            }
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
                return RedirectToAction("Index", "Home");
            else
                return View("Error");
        }
        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var signedUser = await _userManager.FindByEmailAsync(model.Email);
                var result = await _signInManager.PasswordSignInAsync(signedUser.UserName, model.Password, model.RememberMe, false);
                //var result =
                //    await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    // проверяем, принадлежит ли URL приложению
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Неправильный логин и (или) пароль");
                }
            }

            
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            // удаляем аутентификационные куки
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}