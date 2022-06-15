using ApplicationCore.Interface.Base;
using ApplicationCore.Spesification.MsUserSpesification;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Template.Domain.Entity;
using Template.Models;
using Template.ViewModels;

namespace Template.Controllers
{
    public class LoginController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository<MsUser> _msUserRespository;

        public LoginController(ILogger<HomeController> logger, IRepository<MsUser> msUserRepository)
        {
            _logger = logger;
            _msUserRespository = msUserRepository;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(LoginViewModel viewModel)
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
            var msUserSpesification = new GetMsUserLogin(viewModel.userID, viewModel.Password);
            var user = _msUserRespository.GetItemBySpesification(msUserSpesification);
            if (user != null)
            {
                error = "Login Berhasil";
                return RedirectToAction("Index", "Home");
            }

            return View(viewModel);
        }

        public IActionResult LogOut()
        {
            return View();
        }
    }
}