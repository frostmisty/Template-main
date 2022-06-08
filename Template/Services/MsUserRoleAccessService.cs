using ApplicationCore.Interface.Base;
using ApplicationCore.Spesification.MsUserRoleSpesification;
using ApplicationCore.Spesification.MsUserRoleAccessSpesification;
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
using ApplicationCore.Spesification.MsPermissionSpesification;

namespace Template.Services
{
    public class MsUserRoleAccessService : IMsUserRoleAccessService
    {
        private readonly IRepository<MsUserRoleAccess> _msUserRoleAccessRepository;
        private readonly IRepository<MsPage> _msPageRepository;
        private readonly IRepository<MsUserRole> _msUserRoleRepository;
        private readonly IRepository<MsPermission> _msPermissionRespository;
        private readonly IMapper _mapper;
        public MsUserRoleAccessService(
            IRepository<MsUserRoleAccess> msUserRoleAccessRepository,
            IRepository<MsPage> msPageRepository,
            IRepository<MsUserRole> msUserRoleRepository,
            IRepository<MsPermission> msPermissionRepository,
            IMapper mapper
            )
        {
            _msUserRoleAccessRepository = msUserRoleAccessRepository;
            _msPageRepository = msPageRepository;
            _msUserRoleRepository = msUserRoleRepository;
            _msPermissionRespository = msPermissionRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<MsUserRoleAccessViewModel>> Index()
        {
            var filterSpecification = new GetMsUserRoleAccessList();
            var MsUserRoleAccessList = _msUserRoleAccessRepository.GetAllAsync(filterSpecification);
            var ViewModel = _mapper.Map<IEnumerable<MsUserRoleAccess>, IEnumerable<MsUserRoleAccessViewModel>>(MsUserRoleAccessList);
            if (ViewModel == null)
            {
                ViewModel = new List<MsUserRoleAccessViewModel>();
            }
            return ViewModel;
        }

        public async Task<MsUserRoleAccessViewModel> GetMsUserRoleAccessByID(int UserRoleAccessID)
        {
            var filterSpecification = new GetMsUserRoleAccessByUserRoleAccessID(UserRoleAccessID);
            var msUserRoleAccess = _msUserRoleAccessRepository.GetByIDAsync(filterSpecification);
            var ViewModel = _mapper.Map<MsUserRoleAccess, MsUserRoleAccessViewModel>(msUserRoleAccess);
            if (ViewModel == null)
            {
                ViewModel = new MsUserRoleAccessViewModel();
            }
            ViewModel.GetUserRole = (await GetUserRoleList()).ToList();
            ViewModel.GetPage = (await GetPageList()).ToList();
            ViewModel.GetPermission = (await GetPermissionList()).ToList();
            return ViewModel;
        }
        public async Task<ReturnViewModel> Update(MsUserRoleAccessViewModel viewModel)
        {
            bool IsNew = false;
            bool IsSuccess = false;
            var returnView = new ReturnViewModel();
            var checkUserRoleAccessID = new GetMsUserRoleAccessByUserRoleAccessID(viewModel.AccessID);
            var msUserRoleAccess = _msUserRoleAccessRepository.GetByIDAsync(checkUserRoleAccessID);
            if (msUserRoleAccess == null)
            {
                msUserRoleAccess = new MsUserRoleAccess
                {
                    CrtUsrId = "SYSTEM",
                };
                IsNew = true;
            }
            else
            {
                msUserRoleAccess.ModUsrId = "SYSTEM";
                msUserRoleAccess.TsMod = DateTime.Now;
            }
            msUserRoleAccess.AccessID = viewModel.AccessID;
            msUserRoleAccess.PageId = viewModel.PageId;
            msUserRoleAccess.UserRoleId = viewModel.UserRoleId;
            msUserRoleAccess.Permission = viewModel.Permission;

            try
            {
                if (IsNew == true)
                {
                    await _msUserRoleAccessRepository.AddAsync(msUserRoleAccess);
                }
                else
                {
                    await _msUserRoleAccessRepository.UpdateAsync(msUserRoleAccess);
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
        public async Task<ReturnViewModel> Delete(int UserRoleAccessID)
        {
            bool IsSuccess = false;
            var filterSpesification = new GetMsUserRoleAccessByUserRoleAccessID(UserRoleAccessID);
            var msUserRoleAccess = _msUserRoleAccessRepository.GetByIDAsync(filterSpesification);
            var returnView = new ReturnViewModel();
            if (msUserRoleAccess != null)
            {
                msUserRoleAccess.ActiveFlag = "N";
            }
            try
            {
                await _msUserRoleAccessRepository.DeleteAsync(msUserRoleAccess);
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
        public async Task<IEnumerable<SelectListItem>> GetUserRoleList()
        {
            var msUserRoleSpesification = new GetMsUserRoleList();
            var UserRoleList = _msUserRoleRepository.GetAllAsync(msUserRoleSpesification);

            var items = UserRoleList.Select(x => new SelectListItem()
            {
                Value = x.UserRoleId,
                Text = x.UserRoleId
            }).OrderBy(x => x.Text)
            .ToList();

            var allitems = new SelectListItem() { Value = null, Text = "Select UserRole", Selected = true };
            items.Insert(0, allitems);
            return items;
        }
        public async Task<IEnumerable<SelectListItem>> GetPageList()
        {
            var msPageSpesification = new GetMsPageList();
            var PageList = _msPageRepository.GetAllAsync(msPageSpesification);

            var items = PageList.Select(x => new SelectListItem()
            {
                Value = x.PageId,
                Text = x.PageName
            }).OrderBy(x => x.Text)
            .ToList();

            var allitems = new SelectListItem() { Value = null, Text = "Select Page", Selected = true };
            items.Insert(0, allitems);
            return items;
        }

        public async Task<IEnumerable<SelectListItem>> GetPermissionList()
        {
            var msPermissionSpesification = new GetMsPermissionList();
            var MsPermissionList = _msPermissionRespository.GetAllAsync(msPermissionSpesification);

            var items = MsPermissionList.Select(x => new SelectListItem()
            {
                Value = x.PermissionDesc,
                Text = x.PermissionDesc
            }).OrderBy(x => x.Text)
            .ToList();

            var allItems = new SelectListItem() { Value = null, Text = "Select Permission" };
            items.Insert(0,allItems);
            return items;
        }
    }
}