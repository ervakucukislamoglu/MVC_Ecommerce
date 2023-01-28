using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Ecommerce.Models;
using MVC_Ecommerce.Models.Entity;
using MVC_Ecommerce.Repositoy;
using MVC_Ecommerce.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        private SignInManager<AppUser> _signInManager;

        private UserManager<AppUser> _userManager { get; }
        private IProductRepository _productService;

        public HomeController(IProductRepository productService, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _productService = productService;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View(_productService.GetAllProducts());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {

                //1-parametrede tanımlı olan RegisterVM tipindeki model içerisine View'den gönderilen veriler aşağıda AppUser classından instance alınarak ilgili propertylere taşındı. Bunun sebebi ise usermanager sınıfı içerisinde bulunana CreateAsync() parametre olarak identityUser istemesinden kaynaklı. AppUser özünde identityuser olduğu için VM değerlerini özünde idendityUser olarak ram üzerinde örneğini oluşturduk.
                AppUser newUser = new AppUser
                {
                    UserName = model.Username,
                    Email = model.Email,

                };

                //result değişkeni içerisine CreateAsync() metodundan dönen mesajı aktardık. (tavsiye: uygulamayı çalıştırıp breakpoint kullanarak dönen tipi inceleyin.)

                var result = await _userManager.CreateAsync(newUser, model.ConfirmPassword);
                if (result.Succeeded)
                {

                    return RedirectToAction("Index");
                }
                else
                {
                    //todo:Eğer şifre varsayılan kurallara uygun değil ise alınan hata mesajı ilgili view'da (asp-for-validation-summary) gösterilmiyor!!!!
                    return View(model);
                }


            }
            else
            {

                return View(model);
            }

        }

        //Login
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                AppUser login = await _userManager.FindByEmailAsync(model.Email);
                if (login != null)
                {


                    var result = await _signInManager.PasswordSignInAsync(login, model.Password, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(model);
                    }

                }
                else
                {
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }
    }
}
