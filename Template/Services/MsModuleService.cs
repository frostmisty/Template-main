using ApplicationCore.Interface.Base;
using ApplicationCore.Spesification.MsModuleSpesification;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Data;
using Template.Domain.Entity;
using Template.Interface;
using Template.ViewModels;
using Template.ViewModels.Base;

namespace Template.Services
{
    public class MsModuleService : IMsModuleService
    {
        private readonly IRepository<MsModule> _msModuleRepository;
        private readonly IMapper _mapper;
        public MsModuleService(
            IRepository<MsModule> msModuleRepository, 
            IMapper mapper
            )
        {
            _msModuleRepository = msModuleRepository;
            _mapper = mapper;
        }
        public async Task<ReturnViewModel> Delete(string ModuleID)
        {
            bool IsSuccess = false;
            var filterSpesification = new GetMsModuleByModuleID(ModuleID);
            var msModule = _msModuleRepository.GetByIDAsync(filterSpesification);
            var returnView = new ReturnViewModel();
            if (msModule != null)
            {
                msModule.ActiveFlag = "N";
            }
            try
            {
                await _msModuleRepository.DeleteAsync(msModule);
                IsSuccess = true;
                returnView.IsSuccess = IsSuccess;
            }
            catch(Exception ex)
            {
                returnView.IsSuccess = IsSuccess;
                returnView.ReturnValue = ex.InnerException.Message;
            }
            return returnView;
        }

        public async Task<MsModuleViewModel> GetMsModuleByID(string ModuleID)
        {
            var filterSpecification = new GetMsModuleByModuleID(ModuleID);
            var msModule = _msModuleRepository.GetByIDAsync(filterSpecification);
            var ViewModel = _mapper.Map<MsModule, MsModuleViewModel>(msModule);
            if(ViewModel == null)
            {
                ViewModel = new MsModuleViewModel();
            }
            return ViewModel;
        }

        public async Task<IEnumerable<MsModuleViewModel>> GetMsModuleByMsModuleDesc(string ModuleDesc)
        {
            var filterSpecification = new GetMsModuleByModuleNameSpec(ModuleDesc);
            var MsModuleList = _msModuleRepository.GetItemBySpesification(filterSpecification);
            var ViewModel = _mapper.Map<IEnumerable<MsModule>, IEnumerable<MsModuleViewModel>>(MsModuleList);
            if (ViewModel == null)
            {
                ViewModel = new List<MsModuleViewModel>();
            }
            return ViewModel;
        }

        public async Task<IEnumerable<MsModuleViewModel>> Index()
        {
            var filterSpecification = new GetMsModuleList();
            var MsModuleList = _msModuleRepository.GetAllAsync(filterSpecification);
            var ViewModel = _mapper.Map<IEnumerable<MsModule>, IEnumerable<MsModuleViewModel>>(MsModuleList);
            if (ViewModel == null)
            {
                ViewModel = new List<MsModuleViewModel>();
            }
            return ViewModel;
        }



        public async Task<ReturnViewModel> Update(MsModuleViewModel viewModel)
        {
            bool IsNew = false;
            bool IsSuccess = false;
            var returnView = new ReturnViewModel();
            var checkModuleID = new GetMsModuleByModuleID(viewModel.ModuleId);
            var msModule = _msModuleRepository.GetByIDAsync(checkModuleID);
            if (msModule == null)
            {
                msModule = new MsModule
                {
                    CrtUsrId = "SYSTEM",
                    TsCrt = DateTime.Now,
                    ActiveFlag = "Y"
                };
                IsNew = true;
            }
            else
            {
                msModule.ModUsrId = "SYSTEM";
                msModule.TsMod = DateTime.Now;
            }
            msModule.ModuleId = viewModel.ModuleId;
            msModule.ModuleDesc = viewModel.ModuleDesc;
            msModule.Info1 = viewModel.Info1;
            msModule.Info2 = viewModel.Info2;
            msModule.Info3 = viewModel.Info3;

            try
            {
                if (IsNew == true)
                {
                    await _msModuleRepository.AddAsync(msModule);
                }
                else
                {
                    await _msModuleRepository.UpdateAsync(msModule);
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
    }
}