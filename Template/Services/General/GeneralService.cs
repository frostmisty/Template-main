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
using ApplicationCore.Spesification.MsUserRoleSpesification;
using ApplicationCore.Spesification.MsPermissionSpesification;
using ApplicationCore.Spesification.MsEnumItemSpesification;

namespace Template.Services
{
    public class GeneralService :IGeneralService
    {
        private readonly IRepository<MsMenu> _msMenuRepository;
        private readonly IRepository<MsPage> _msPageRepository;
        private readonly IRepository<MsModule> _msModuleRepository;
        private readonly IRepository<MsUserRole> _msUserRoleRepository;
        private readonly IRepository<MsPermission> _msPermissionRespository;
        private readonly IRepository<MsEnumItem> _msEnumitemRespository;
        private readonly IMapper _mapper;
        public GeneralService(
            IRepository<MsMenu> msMenuRepository,
            IRepository<MsPage> msPageRepository,
            IRepository<MsModule> msModuleRepository,
            IRepository<MsUserRole> msUserRoleRepository,
            IRepository<MsPermission> msPermissionRepository,
            IRepository<MsEnumItem> msEnumitemRespository,
            IMapper mapper
            )
        {
            _msMenuRepository = msMenuRepository;
            _msPageRepository = msPageRepository;
            _msModuleRepository = msModuleRepository;
            _msUserRoleRepository = msUserRoleRepository;
            _msPermissionRespository = msPermissionRepository;
            _msEnumitemRespository = msEnumitemRespository;
            _mapper = mapper;
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

        public async Task<IEnumerable<SelectListItem>> GetMenuParentList()
        {
            var msMenuSpesification = new GetMsMenuHeaderList();
            var msMenuList = _msMenuRepository.GetAllAsync(msMenuSpesification);

            var items = msMenuList.Select(x => new SelectListItem()
            {
                Text = x.MenuText,
                Value = x.MenuId
            }).OrderBy(x => x.Value)
            .ToList();

            var allItems = new SelectListItem() { Value = null, Text = "Select Parent" };
            items.Insert(0,allItems);
            return items;
        }

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
            items.Insert(0, allItems);
            return items;
        }

        public async Task<IEnumerable<SelectListItem>> GetItemCategoryList()
        {
            var msenumitemspesification = new GetMsEnumItemList();
            var MsEnumItemList = _msEnumitemRespository.GetAllAsync(msenumitemspesification);

            var items = MsEnumItemList.Select(x => new SelectListItem()
            {
                Text = x.ItemCategory,
                Value = x.ItemCategory
            }).OrderBy(x => x.Text).ToList();

            var allitems = new SelectListItem() { Value = null, Text = "Select Item Category" };
            items.Insert(0,allitems);
            return items;
        }
    }
}