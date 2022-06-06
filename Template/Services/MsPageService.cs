using ApplicationCore.Interface.Base;
using ApplicationCore.Spesification.MsModuleSpesification;
using ApplicationCore.Spesification.MsPageSpesification;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;
using Template.Domain.Entity;
using Template.Interface;
using Template.ViewModels;
using Template.ViewModels.Base;

namespace Template.Services
{
    public class MsPageService : IMsPageService
    {
        private readonly IRepository<MsPage> _msPageRepository;
        private readonly IRepository<MsModule> _msModuleRepository;
        private readonly IMapper _mapper;
        public MsPageService(
            IRepository<MsPage> msPageRepository,
            IRepository<MsModule> msModuleRepository,
            IMapper mapper
            )
        {
            _msPageRepository = msPageRepository;
            _msModuleRepository = msModuleRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<MsPageViewModel>> Index()
        {
            var filterSpecification = new GetMsPageList();
            var MsPageList = _msPageRepository.GetAllAsync(filterSpecification);
            var ViewModel = _mapper.Map<IEnumerable<MsPage>, IEnumerable<MsPageViewModel>>(MsPageList);
            if (ViewModel == null)
            {
                ViewModel = new List<MsPageViewModel>();
            }
            return ViewModel;
        }

        public async Task<MsPageViewModel> GetMsPageByID(string PageID)
        {
            var filterSpecification = new GetMsPageByPageID(PageID);
            var msPage = _msPageRepository.GetByIDAsync(filterSpecification);
            var ViewModel = _mapper.Map<MsPage, MsPageViewModel>(msPage);
            ViewModel.GetModule = (await GetModuleList()).ToList();

            if (ViewModel == null)
            {
                ViewModel = new MsPageViewModel();
            }
            return ViewModel;
        }
        public async Task<ReturnViewModel> Update(MsPageViewModel viewModel)
        {
            bool IsNew = false;
            bool IsSuccess = false;
            var returnView = new ReturnViewModel();
            var checkPageID = new GetMsPageByPageID(viewModel.PageId);
            var msPage = _msPageRepository.GetByIDAsync(checkPageID);
            if (msPage == null)
            {
                msPage = new MsPage
                {
                    CrtUsrId = "SYSTEM",
                    //TsCrt = DateTime.Now,
                    //ActiveFlag = "Y"
                };
                IsNew = true;
            }
            else
            {
                msPage.ModUsrId = "SYSTEM";
                msPage.TsMod = DateTime.Now;
            }
            msPage.PageId = viewModel.PageId;
            msPage.PageDesc = viewModel.PageDesc;
            msPage.ModuleId = viewModel.ModuleId;
            msPage.PageName = viewModel.PageName;

            try
            {
                if (IsNew == true)
                {
                    await _msPageRepository.AddAsync(msPage);
                }
                else
                {
                    await _msPageRepository.UpdateAsync(msPage);
                }
                IsSuccess = true;
                returnView.IsSuccess = IsSuccess;
            }
            catch (Exception ex)
            {
                returnView.IsSuccess = IsSuccess;
                returnView.ReturnValue = ex.InnerException.Message;
            }

            return returnView;
        }
        public async Task<ReturnViewModel> Delete(string PageID)
        {
            bool IsSuccess = false;
            var filterSpesification = new GetMsPageByPageID(PageID);
            var msPage = _msPageRepository.GetByIDAsync(filterSpesification);
            var returnView = new ReturnViewModel();
            if (msPage != null)
            {
                msPage.ActiveFlag = "N";
            }
            try
            {
                await _msPageRepository.DeleteAsync(msPage);
                IsSuccess = true;
                returnView.IsSuccess = IsSuccess;
            }
            catch (Exception ex)
            {
                returnView.IsSuccess = IsSuccess;
                returnView.ReturnValue = ex.InnerException.Message;
            }
            return returnView;
        }

        //Additional Function

        public async Task<IEnumerable<SelectListItem>> GetModuleList()
        {
            var msModuleSpesification = new GetMsModuleList();
            var ModuleList = _msModuleRepository.GetAllAsync(msModuleSpesification);

            var items = ModuleList.Select(x => new SelectListItem()
            {
                Value = x.ModuleId,
                Text = x.ModuleId
            }).OrderBy(x => x.Text)
            .ToList();

            var allitems = new SelectListItem() { Value = null, Text = "Select Module", Selected = true };
            items.Insert(0, allitems);
            return items;
        }
    }
}