
using ApplicationCore.Interface.Base;
using ApplicationCore.Spesification;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Template.Domain.Entity;
using Template.Features;
using Template.Interface;
using Template.ViewModels;

namespace Template.Controllers
{
    public class MsModuleController : Controller
    {
        public readonly IMsModuleService _msModuleService;

        public MsModuleController(IMsModuleService msModuleService)
        {
            _msModuleService = msModuleService;
        }
        public async Task<IActionResult> Index()
        {
            CreateorUpdate("M0001");
            var viewModels = await _msModuleService.Index();
            return View(viewModels);
        }

        public async Task<IActionResult> CreateorUpdate(string ModuleID)
        {
            var viewModels = await _msModuleService.GetMsModuleByID(ModuleID);
            return View(viewModels);
        }

    }
}
