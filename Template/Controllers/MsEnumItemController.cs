
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
    public class MsEnumItemController : BaseController
    {
        public readonly IMsEnumItemService _msEnumItemService;

        public MsEnumItemController(IMsEnumItemService msEnumItemService)
        {
            _msEnumItemService = msEnumItemService;
        }
        public async Task<IActionResult> Index()
        {
            var viewModels = await _msEnumItemService.Index();
            return View(viewModels);
        }
        //[HttpGet("EnumItemID")]
        public async Task<IActionResult> AddOrUpdate(int ItemID)
        {
            var viewModels = await _msEnumItemService.GetMsEnumItemByID(ItemID);
            return View(viewModels);
        }

        public async Task<IActionResult> Delete(int id)
        {
            
            ReturnViewModel viewModel = new ReturnViewModel();
            viewModel = await _msEnumItemService.Delete(id);

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
        public async Task<IActionResult> AddOrUpdate(MsEnumItemViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(ViewModel.ItemValue) || string.IsNullOrEmpty(ViewModel.ItemDesc))
                {
                    Error("EnumItem ID dan EnumItem Desc tidak boleh kosong");
                    return View(ViewModel);
                }
            }
            ReturnViewModel returnView = new ReturnViewModel();
            returnView = await _msEnumItemService.Update(ViewModel);

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
