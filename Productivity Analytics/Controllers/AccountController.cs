using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivity_Analytics.Models;
using Productivity_Analytics.ViewModels;
using System.Security.Claims;
using static System.Runtime.InteropServices.JavaScript.JSType;

//sql table name is AspNetUsers

namespace Productivity_Analytics.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<Users> signInManager;
        private readonly UserManager<Users> userManager;

        public AccountController(SignInManager<Users> signInManager, UserManager<Users> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginView model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Email or password is incorrect.");
                    return View(model);
                }
            }
            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterView model)
        {
            if (ModelState.IsValid)
            {
                Users users = new Users
                {
                    FullName = model.UserName,
                    UserName = model.UserName,
                    Email = model.Email,
                    
                };

                var result = await userManager.CreateAsync(users, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    return View(model);
                }
            }
            return View(model);
        }

        public IActionResult VerifyEmail()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> VerifyEmail(VerifyEmailView model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(model.Email);

                if (user == null)
                {
                    ModelState.AddModelError("", "Something is wrong!");
                    return View(model);
                }
                else
                {
                    return RedirectToAction("ChangePassword", "Account", new { username = user.UserName });
                }
            }
            return View(model);
        }

        public IActionResult ChangePassword(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("VerifyEmail", "Account");
            }
            return View(model: new ChangePasswordView
            {
                Email = username,
                NewPassword = string.Empty,
                ConfirmNewPassword = string.Empty
            });
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordView model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(model.Email);
                if (user != null)
                {
                    var result = await userManager.RemovePasswordAsync(user);
                    if (result.Succeeded)
                    {
                        result = await userManager.AddPasswordAsync(user, model.NewPassword);
                        return RedirectToAction("Login", "Account");
                    }
                    else
                    {

                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }

                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Email not found!");
                    return View(model);
                }
            }
            else
            {
                ModelState.AddModelError("", "Something went wrong. try again.");
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult GoogleExternalLogin(string provider, string returnUrl = "/")
        {
            var redirectUrl = Url.Action("GoogleExternalLoginCallback", "Account", new { returnUrl });
            var properties = signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return Challenge(properties, provider);
        }

        public async Task<IActionResult> GoogleExternalLoginCallback(string returnUrl = "/")
        {
            var info = await signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return RedirectToAction("Login");
            }

 
            var result = await signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, false);
            if (result.Succeeded)
            {
                return LocalRedirect(returnUrl);
            }

            var email = info.Principal.FindFirstValue(System.Security.Claims.ClaimTypes.Email);
            var name = info.Principal.FindFirstValue(System.Security.Claims.ClaimTypes.Name);

            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
            {
                user = new Users
                {
                    UserName = name,
                    Email = email,
                    FullName = name
                };

                var createResult = await userManager.CreateAsync(user);

                if (!createResult.Succeeded)
                {
                    foreach (var error in createResult.Errors)
                        ModelState.AddModelError("", error.Description);

                    return RedirectToAction("Login");
                }
            }

            await userManager.AddLoginAsync(user, info);

            await signInManager.SignInAsync(user, false);

            return LocalRedirect(returnUrl);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
