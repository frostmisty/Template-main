
using ApplicationCore.Interface.Base;
using ApplicationCore.Spesification;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Template.Domain.Entity;
using Template.Interface;
using Template.ViewModels;
using Template.ViewModels.Base;

namespace Template.Controllers
{
    [Authorize]
    public class MsUserRoleController : BaseController
    {
        public readonly IMsUserRoleService _msUserRoleService;

        public MsUserRoleController(IMsUserRoleService msUserRoleService)
        {
            _msUserRoleService = msUserRoleService;
        }
        public async Task<IActionResult> Index()
        {
            var viewModels = await _msUserRoleService.Index();
            return View(viewModels);
        }
        //[HttpGet("UserRoleID")]
        public async Task<IActionResult> AddOrUpdate(string UserRoleID)
        {
            var viewModels = await _msUserRoleService.GetMsUserRoleByID(UserRoleID);
            return View(viewModels);
        }

        public async Task<IActionResult> Delete(string id)
        {
            
            ReturnViewModel viewModel = new ReturnViewModel();
            viewModel = await _msUserRoleService.Delete(id);

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
        public async Task<IActionResult> AddOrUpdate(MsUserRoleViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(ViewModel.UserRoleDesc) || string.IsNullOrEmpty(ViewModel.ModuleId))
                {
                    Error("UserRole ID dan UserRole Desc tidak boleh kosong");
                    return View(ViewModel);
                }
            }
            ReturnViewModel returnView = new ReturnViewModel();
            returnView = await _msUserRoleService.Update(ViewModel);

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
