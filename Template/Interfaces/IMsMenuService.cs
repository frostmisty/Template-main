using ApplicationCore.Base.Spesification;
using MediatR;
using Template.Domain.Entity;
using Template.ViewModels;
using Template.ViewModels.Base;

namespace Template.Interface
{
    public interface IMsMenuService
    {
        Task<IEnumerable<MsMenuViewModel>> Index();
        Task<MsMenuViewModel> GetMsMenuByID(string MenuID);
        Task<MsMenuViewModel> GetMenubyModuleIDPageID(string ModuleID, string PageID);
        Task<ReturnViewModel> Update(MsMenuViewModel viewModel);
        Task<ReturnViewModel> Delete(string MenuID);
    }
}