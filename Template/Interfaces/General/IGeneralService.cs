using ApplicationCore.Base.Spesification;
using MediatR;
using Microsoft.AspNetCore.Mvc.Rendering;
using Template.Domain.Entity;
using Template.ViewModels;
using Template.ViewModels.Base;

namespace Template.Interface
{
    public interface IGeneralService
    {
        Task<IEnumerable<SelectListItem>> GetModuleList();
        Task<IEnumerable<SelectListItem>> GetPageList();
        Task<IEnumerable<SelectListItem>> GetMenuParentList();
        Task<IEnumerable<SelectListItem>> GetUserRoleList();
        Task<IEnumerable<SelectListItem>> GetPermissionList();
        Task<IEnumerable<SelectListItem>> GetItemCategoryList();

    }
}