
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
    public class MsUserRoleAccessController : BaseController
    {
        public readonly IMsUserRoleAccessService _msUserRoleAccessService;

        public MsUserRoleAccessController(IMsUserRoleAccessService msUserRoleAccessService)
        {
            _msUserRoleAccessService = msUserRoleAccessService;
        }
        public async Task<IActionResult> Index()
        {
            var viewModels = await _msUserRoleAccessService.Index();
            return View(viewModels);
        }
        public async Task<IActionResult> AddOrUpdate(int AccessID)
        {
            var viewModels = await _msUserRoleAccessService.GetMsUserRoleAccessByID(AccessID);
            return View(viewModels);
        }

        public async Task<IActionResult> Delete(int id)
        {
            
            ReturnViewModel viewModel = new ReturnViewModel();
            viewModel = await _msUserRoleAccessService.Delete(id);

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
        public async Task<IActionResult> AddOrUpdate(MsUserRoleAccessViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(ViewModel.UserRoleId))
                {
                    Error("UserRoleID Desc tidak boleh kosong");
                    return View(ViewModel);
                }
            }
            ReturnViewModel returnView = new ReturnViewModel();
            returnView = await _msUserRoleAccessService.Update(ViewModel);

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
