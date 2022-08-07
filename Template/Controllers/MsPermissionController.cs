
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
    public class MsPermissionController : BaseController
    {
        public readonly IMsPermissionService _msPermissionService;

        public MsPermissionController(IMsPermissionService msPermissionService)
        {
            _msPermissionService = msPermissionService;
        }
        public async Task<IActionResult> Index()
        {
            var viewModels = await _msPermissionService.Index();
            return View(viewModels);
        }
        //[HttpGet("PermissionID")]
        public async Task<IActionResult> AddOrUpdate(int PermissionID)
        {
            var viewModels = await _msPermissionService.GetMsPermissionByID(PermissionID);
            return View(viewModels);
        }

        public async Task<IActionResult> Delete(int id)
        {
            
            ReturnViewModel viewModel = new ReturnViewModel();
            viewModel = await _msPermissionService.Delete(id);

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
        public async Task<IActionResult> AddOrUpdate(MsPermissionViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(ViewModel.PermissionDesc))
                {
                    Error("Permission Desc tidak boleh kosong");
                    return View(ViewModel);
                }
            }
            ReturnViewModel returnView = new ReturnViewModel();
            returnView = await _msPermissionService.Update(ViewModel);

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
