using ApplicationCore.Interface.Base;
using ApplicationCore.Spesification.MsUserSpesification;
using Infrastructure.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Template.Domain.Entity;
using Template.Models;
using Template.ViewModels;

namespace Template.Controllers
{
    [AllowAnonymous]
    public class LoginController : BaseController
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository<MsUser> _msUserRespository;

        public LoginController(ILogger<HomeController> logger, IRepository<MsUser> msUserRepository, SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
            _logger = logger;
            _msUserRespository = msUserRepository;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(LoginViewModel viewModel)
        {
            string error = "";
            if (string.IsNullOrEmpty(viewModel.userID))
            {
                error="User ID tidak boleh Kosong";
            }
            if (string.IsNullOrEmpty(viewModel.Password))
            {
                error = "User Password tidak boleh kosong";
            }
            if (string.IsNullOrEmpty(viewModel.Lokasi))
            {
                error = "Lokasi tidak boleh Kosong";
            }
            if(error != "")
            {
                Console.WriteLine(error);
                return View(viewModel);
            }
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(viewModel.userID, viewModel.Password, false, true);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User Logged In");

                    var msUserSpesification = new GetMsUserLogin(viewModel.userID, viewModel.Password);

                    var user = _msUserRespository.GetItemBySpesification(msUserSpesification);
                    if (user != null)
                    {
                        error = "Login Berhasil";
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        error = "You don't have authority";
                        return View(viewModel);
                    }
                    return RedirectToAction("Index", "Home");
                }
            }
            

            return View(viewModel);
        }

        public IActionResult LogOut()
        {
            return View();
        }
    }
}