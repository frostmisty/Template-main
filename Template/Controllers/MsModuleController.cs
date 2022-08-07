
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
    public class MsModuleController : BaseController
    {
        public readonly IMsModuleService _msModuleService;

        public MsModuleController(IMsModuleService msModuleService)
        {
            _msModuleService = msModuleService;
        }
        public async Task<IActionResult> Index()
        {
            var viewModels = await _msModuleService.Index();
            return View(viewModels);
        }
        //[HttpGet("ModuleID")]
        public async Task<IActionResult> AddOrUpdate(string ModuleID)
        {
            var viewModels = await _msModuleService.GetMsModuleByID(ModuleID);
            return View(viewModels);
        }

        public async Task<IActionResult> Delete(string id)
        {
            
            ReturnViewModel viewModel = new ReturnViewModel();
            viewModel = await _msModuleService.Delete(id);

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
        public async Task<IActionResult> AddOrUpdate(MsModuleViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(ViewModel.ModuleId) || string.IsNullOrEmpty(ViewModel.ModuleDesc))
                {
                    Error("Module ID dan Module Desc tidak boleh kosong");
                    return View(ViewModel);
                }
            }
            ReturnViewModel returnView = new ReturnViewModel();
            returnView = await _msModuleService.Update(ViewModel);

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
