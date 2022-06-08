using ApplicationCore.Interface.Base;
using ApplicationCore.Spesification.MsModuleSpesification;
using ApplicationCore.Spesification.MsUserSpesification;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;
using Template.Domain.Entity;
using Template.Interface;
using Template.ViewModels;
using Template.ViewModels.Base;
using ApplicationCore.Spesification.MsUserRoleSpesification;

namespace Template.Services
{
    public class MsUserService : IMsUserService
    {
        private readonly IRepository<MsUser> _msUserRepository;
        private readonly IRepository<MsUserRole> _msUserRoleRepository;
        private readonly IRepository<MsModule> _msModuleRepository;
        private readonly IMapper _mapper;
        public MsUserService(
            IRepository<MsUser> msUserRepository,
            IRepository<MsUserRole> msUserRoleRepository,
            IRepository<MsModule> msModuleRepository,
            IMapper mapper
            )
        {
            _msUserRepository = msUserRepository;
            _msUserRoleRepository = msUserRoleRepository;
            _msModuleRepository = msModuleRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<MsUserViewModel>> Index()
        {
            var filterSpecification = new GetMsUserList();
            var MsUserList = _msUserRepository.GetAllAsync(filterSpecification);
            var ViewModel = _mapper.Map<IEnumerable<MsUser>, IEnumerable<MsUserViewModel>>(MsUserList);
            if (ViewModel == null)
            {
                ViewModel = new List<MsUserViewModel>();
            }
            return ViewModel;
        }

        public async Task<MsUserViewModel> GetMsUserByID(string ModuleID,string UserID,string UserRoleID)
        {
            var filterSpecification = new GetMsUserByUserID(ModuleID, UserID, UserRoleID);
            var msUser = _msUserRepository.GetByIDAsync(filterSpecification);
            var ViewModel = _mapper.Map<MsUser, MsUserViewModel>(msUser);
            if (ViewModel == null)
            {
                ViewModel = new MsUserViewModel();
            }
            ViewModel.GetModule = (await GetModuleList()).ToList();
            ViewModel.GetUserRole = (await GetUserRoleList()).ToList();
            return ViewModel;
        }
        public async Task<ReturnViewModel> Update(MsUserViewModel viewModel)
        {
            bool IsNew = false;
            bool IsSuccess = false;
            var returnView = new ReturnViewModel();
            var checkUserID = new GetMsUserByUserID(viewModel.ModuleId,viewModel.UserId,viewModel.UserRoleId);
            var msUser = _msUserRepository.GetByIDAsync(checkUserID);
            if (msUser == null)
            {
                msUser = new MsUser
                {
                    CrtUsrId = "SYSTEM",
                };
                IsNew = true;
            }
            else
            {
                msUser.ModUsrId = "SYSTEM";
                msUser.TsMod = DateTime.Now;
            }
            msUser.UserId = viewModel.UserId;
            msUser.UserRoleId = viewModel.UserRoleId;
            msUser.ModuleId = viewModel.ModuleId;
            msUser.Area = viewModel.Area;
            msUser.FullName = viewModel.FullName;
            msUser.Email = viewModel.Email;
            msUser.Info1 = viewModel.Info1;
            msUser.Info2 = viewModel.Info2;
            msUser.Info3 = viewModel.Info3;
            try
            {
                if (IsNew == true)
                {
                    await _msUserRepository.AddAsync(msUser);
                }
                else
                {
                    await _msUserRepository.UpdateAsync(msUser);
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
        public async Task<ReturnViewModel> Delete(string ModuleID, string UserID, string UserRoleID)
        {
            bool IsSuccess = false;
            var filterSpecification = new GetMsUserByUserID(ModuleID, UserID, UserRoleID);
            var msUser = _msUserRepository.GetByIDAsync(filterSpecification);
            var returnView = new ReturnViewModel();
            if (msUser != null)
            {
                msUser.ActiveFlag = "N";
            }
            try
            {
                await _msUserRepository.DeleteAsync(msUser);
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
        public async Task<IEnumerable<SelectListItem>> GetUserRoleList()
        {
            var msUserRoleSpesification = new GetMsUserRoleList();
            var UserRoleList = _msUserRoleRepository.GetAllAsync(msUserRoleSpesification);

            var items = UserRoleList.Select(x => new SelectListItem()
            {
                Value = x.UserRoleId,
                Text = x.UserRoleDesc
            }).OrderBy(x => x.Text)
            .ToList();

            var allitems = new SelectListItem() { Value = null, Text = "Select UserRole", Selected = true };
            items.Insert(0, allitems);
            return items;
        }
    }
}