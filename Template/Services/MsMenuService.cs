using ApplicationCore.Interface.Base;
using ApplicationCore.Spesification.MsModuleSpesification;
using ApplicationCore.Spesification.MsMenuSpesification;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;
using Template.Domain.Entity;
using Template.Interface;
using Template.ViewModels;
using Template.ViewModels.Base;
using ApplicationCore.Spesification.MsPageSpesification;

namespace Template.Services
{
    public class MsMenuService : IMsMenuService
    {
        private readonly IRepository<MsMenu> _msMenuRepository;
        private readonly IGeneralService _generalService;
        private readonly IMapper _mapper;
        public MsMenuService(
            IRepository<MsMenu> msMenuRepository,
            IGeneralService generalService,
            IMapper mapper
            )
        {
            _msMenuRepository = msMenuRepository;
            _generalService = generalService;
            _mapper = mapper;
        }
        public async Task<IEnumerable<MsMenuViewModel>> Index()
        {
            var filterSpecification = new GetMsMenuList();
            var MsMenuList = _msMenuRepository.GetAllAsync(filterSpecification);
            var ViewModel = _mapper.Map<IEnumerable<MsMenu>, IEnumerable<MsMenuViewModel>>(MsMenuList);
            if (ViewModel == null)
            {
                ViewModel = new List<MsMenuViewModel>();
            }
            return ViewModel;
        }

        public async Task<MsMenuViewModel> GetMsMenuByID(string MenuID)
        {
            var filterSpecification = new GetMsMenuByMenuID(MenuID);
            var msMenu = _msMenuRepository.GetByIDAsync(filterSpecification);
            var ViewModel = _mapper.Map<MsMenu, MsMenuViewModel>(msMenu);
            if (ViewModel == null)
            {
                ViewModel = new MsMenuViewModel();
            }
            ViewModel.GetModule = (await _generalService.GetModuleList()).ToList();
            ViewModel.GetPage = (await _generalService.GetPageList()).ToList();
            ViewModel.GetMenu = (await _generalService.GetMenuParentList()).ToList();

            return ViewModel;
        }
        public async Task<ReturnViewModel> Update(MsMenuViewModel viewModel)
        {
            bool IsNew = false;
            bool IsSuccess = false;
            var returnView = new ReturnViewModel();
            var checkMenuID = new GetMsMenuByMenuID(viewModel.MenuId);
            var msMenu = _msMenuRepository.GetByIDAsync(checkMenuID);
            if (msMenu == null)
            {
                msMenu = new MsMenu
                {
                    CrtUsrId = "SYSTEM",
                };
                IsNew = true;
            }
            else
            {
                msMenu.ModUsrId = "SYSTEM";
                msMenu.TsMod = DateTime.Now;
            }
            msMenu.MenuId = viewModel.MenuId;
            msMenu.PageId = viewModel.PageId;
            msMenu.ModuleId = viewModel.ModuleId;
            msMenu.ParentId = viewModel.ParentId;
            msMenu.Seq = viewModel.Seq;
            msMenu.MenuText = viewModel.MenuText;

            try
            {
                if (IsNew == true)
                {
                    await _msMenuRepository.AddAsync(msMenu);
                }
                else
                {
                    await _msMenuRepository.UpdateAsync(msMenu);
                }
                IsSuccess = true;
                returnView.IsSuccess = IsSuccess;
            }
            catch (Exception ex)
            {
                returnView.IsSuccess = IsSuccess;
                returnView.ReturnValue = ex.InnerException == null ? ex.Message : ex.InnerException.Message;
            }

            return returnView;
        }
        public async Task<ReturnViewModel> Delete(string MenuID)
        {
            bool IsSuccess = false;
            var filterSpesification = new GetMsMenuByMenuID(MenuID);
            var msMenu = _msMenuRepository.GetByIDAsync(filterSpesification);
            var returnView = new ReturnViewModel();
            if (msMenu != null)
            {
                msMenu.ActiveFlag = "N";
            }
            else
            {
                returnView.IsSuccess = IsSuccess;
                return returnView;
            }
            try
            {
                await _msMenuRepository.DeleteAsync(msMenu);
                IsSuccess = true;
                returnView.IsSuccess = IsSuccess;
            }
            catch (Exception ex)
            {
                returnView.IsSuccess = IsSuccess;
                returnView.ReturnValue = ex.InnerException == null ? ex.Message : ex.InnerException.Message;
            }
            return returnView;
        }
    }
}