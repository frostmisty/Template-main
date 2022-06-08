
using ApplicationCore.Interface.Base;
using ApplicationCore.Spesification;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Template.Domain.Entity;
using Template.Interface;
using Template.ViewModels;
using Template.ViewModels.Base;

namespace Template.Controllers
{
    public class MsUserController : BaseController
    {
        public readonly IMsUserService _msUserService;

        public MsUserController(IMsUserService msUserService)
        {
            _msUserService = msUserService;
        }
        public async Task<IActionResult> Index()
        {
            var viewModels = await _msUserService.Index();
            return View(viewModels);
        }
        //[HttpGet("UserID")]
        public async Task<IActionResult> AddOrUpdate(string ModuleID,string UserID, string UserRoleID)
        {
            var viewModels = await _msUserService.GetMsUserByID(ModuleID, UserID, UserRoleID);
            return View(viewModels);
        }

        public async Task<IActionResult> Delete(string ModuleID, string UserID, string UserRoleID)
        {
            
            ReturnViewModel viewModel = new ReturnViewModel();
            viewModel = await _msUserService.Delete(ModuleID, UserID, UserRoleID);

            if(viewModel.IsSuccess == true)
            {
                Success("Data berhasil DiHapus");
            }
            else
            {
                Error(viewModel.ReturnValue);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrUpdate(MsUserViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(ViewModel.UserId) || string.IsNullOrEmpty(ViewModel.ModuleId) || string.IsNullOrEmpty(ViewModel.UserRoleId))
                {
                    Error("User ID dan User Desc tidak boleh kosong");
                    return View(ViewModel);
                }
            }
            ReturnViewModel returnView = new ReturnViewModel();
            returnView = await _msUserService.Update(ViewModel);

            if(returnView.IsSuccess == true)
            {
                Success("Data Berhasil Disimpan");
                return RedirectToAction("Index");
            }
            else
            {
                Error(returnView.ReturnValue);
                return View(ViewModel);
            }
        }
    }
}
