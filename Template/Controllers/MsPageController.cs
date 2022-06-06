
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
    public class MsPageController : BaseController
    {
        public readonly IMsPageService _msPageService;

        public MsPageController(IMsPageService msPageService)
        {
            _msPageService = msPageService;
        }
        public async Task<IActionResult> Index()
        {
            var viewModels = await _msPageService.Index();
            return View(viewModels);
        }
        //[HttpGet("PageID")]
        public async Task<IActionResult> AddOrUpdate(string PageID)
        {
            var viewModels = await _msPageService.GetMsPageByID(PageID);
            return View(viewModels);
        }

        public async Task<IActionResult> Delete(string id)
        {
            
            ReturnViewModel viewModel = new ReturnViewModel();
            viewModel = await _msPageService.Delete(id);

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
        public async Task<IActionResult> AddOrUpdate(MsPageViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(ViewModel.PageId) || string.IsNullOrEmpty(ViewModel.PageDesc))
                {
                    Error("Page ID dan Page Desc tidak boleh kosong");
                    return View(ViewModel);
                }
            }
            ReturnViewModel returnView = new ReturnViewModel();
            returnView = await _msPageService.Update(ViewModel);

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
