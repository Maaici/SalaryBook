using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SalaryBook.Models;

namespace SalaryBook.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        public AccountController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(login.UserName);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, login.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "密码不正确");
                    }
                }
                else {
                    ModelState.AddModelError("", "用户不存在");
                }
            }
            return View(login);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel register) {
            if (ModelState.IsValid) {
                IdentityUser user = new IdentityUser {
                    UserName = register.UserName
                };
                var result = await _userManager.CreateAsync(user, register.Password);
                if (result.Succeeded)
                {
                    return View("Login");
                }
                else {
                    ModelState.AddModelError("", result.Errors.FirstOrDefault().Description);
                }
            }
            return View(register);
        }
    }
}