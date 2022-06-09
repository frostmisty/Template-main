using ApplicationCore.Interface.Base;
using ApplicationCore.Spesification.MsModuleSpesification;
using ApplicationCore.Spesification.MsUserRoleSpesification;
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
    public class MsUserRoleService : IMsUserRoleService
    {
        private readonly IRepository<MsUserRole> _msUserRoleRepository;
        private readonly IGeneralService _generalService;
        private readonly IMapper _mapper;
        public MsUserRoleService(
            IRepository<MsUserRole> msUserRoleRepository,
            IGeneralService generalService,
            IMapper mapper
            )
        {
            _msUserRoleRepository = msUserRoleRepository;
            _generalService = generalService;
            _mapper = mapper;
        }
        public async Task<IEnumerable<MsUserRoleViewModel>> Index()
        {
            var filterSpecification = new GetMsUserRoleList();
            var MsUserRoleList = _msUserRoleRepository.GetAllAsync(filterSpecification);
            var ViewModel = _mapper.Map<IEnumerable<MsUserRole>, IEnumerable<MsUserRoleViewModel>>(MsUserRoleList);
            if (ViewModel == null)
            {
                ViewModel = new List<MsUserRoleViewModel>();
            }
            return ViewModel;
        }

        public async Task<MsUserRoleViewModel> GetMsUserRoleByID(string UserRoleID)
        {
            var filterSpecification = new GetMsUserRoleByUserRoleID(UserRoleID);
            var msUserRole = _msUserRoleRepository.GetByIDAsync(filterSpecification);
            var ViewModel = _mapper.Map<MsUserRole, MsUserRoleViewModel>(msUserRole);
            

            if (ViewModel == null)
            {
                ViewModel = new MsUserRoleViewModel();
            }
            ViewModel.GetModule = (await _generalService.GetModuleList()).ToList();
            return ViewModel;
        }
        public async Task<ReturnViewModel> Update(MsUserRoleViewModel viewModel)
        {
            bool IsNew = false;
            bool IsSuccess = false;
            var returnView = new ReturnViewModel();
            var checkUserRoleID = new GetMsUserRoleByUserRoleID(viewModel.UserRoleId);
            var msUserRole = _msUserRoleRepository.GetByIDAsync(checkUserRoleID);
            if (msUserRole == null)
            {
                msUserRole = new MsUserRole
                {
                    CrtUsrId = "SYSTEM",
                    //TsCrt = DateTime.Now,
                    //ActiveFlag = "Y"
                };
                IsNew = true;
            }
            else
            {
                msUserRole.ModUsrId = "SYSTEM";
                msUserRole.TsMod = DateTime.Now;
            }
            msUserRole.UserRoleId = viewModel.UserRoleId;
            msUserRole.UserRoleDesc = viewModel.UserRoleDesc;
            msUserRole.ModuleId = viewModel.ModuleId;

            try
            {
                if (IsNew == true)
                {
                    await _msUserRoleRepository.AddAsync(msUserRole);
                }
                else
                {
                    await _msUserRoleRepository.UpdateAsync(msUserRole);
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
        public async Task<ReturnViewModel> Delete(string UserRoleID)
        {
            bool IsSuccess = false;
            var filterSpesification = new GetMsUserRoleByUserRoleID(UserRoleID);
            var msUserRole = _msUserRoleRepository.GetByIDAsync(filterSpesification);
            var returnView = new ReturnViewModel();
            if (msUserRole != null)
            {
                msUserRole.ActiveFlag = "N";
            }
            else
            {
                returnView.IsSuccess = IsSuccess;
                return returnView;
            }
            try
            {
                await _msUserRoleRepository.DeleteAsync(msUserRole);
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

        //Additional Function

    }
}