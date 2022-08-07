
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
    public class MsMenuController : BaseController
    {
        public readonly IMsMenuService _msMenuService;

        public MsMenuController(IMsMenuService msMenuService)
        {
            _msMenuService = msMenuService;
        }
        public async Task<IActionResult> Index()
        {
            var viewModels = await _msMenuService.Index();
            return View(viewModels);
        }
        //[HttpGet("MenuID")]
        public async Task<IActionResult> AddOrUpdate(string MenuID)
        {
            var viewModels = await _msMenuService.GetMsMenuByID(MenuID);
            return View(viewModels);
        }

        public async Task<IActionResult> Delete(string id)
        {
            
            ReturnViewModel viewModel = new ReturnViewModel();
            viewModel = await _msMenuService.Delete(id);

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
        public async Task<IActionResult> AddOrUpdate(MsMenuViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(ViewModel.PageId) || string.IsNullOrEmpty(ViewModel.ModuleId))
                {
                    Error("Menu ID dan Menu Desc tidak boleh kosong");
                    return View(ViewModel);
                }
            }
            //check pageid dan moduleid

            var msmenuviewmodel = await _msMenuService.GetMenubyModuleIDPageID(ViewModel.ModuleId, ViewModel.PageId);
            if(msmenuviewmodel != null)
            {
                Error("Page ID dan Module ID sudah pernah diinput");
                return View(ViewModel);
            }

            ReturnViewModel returnView = new ReturnViewModel();
            returnView = await _msMenuService.Update(ViewModel);

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
