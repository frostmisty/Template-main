using ApplicationCore.Base.Spesification;
using MediatR;
using Template.Domain.Entity;
using Template.ViewModels;
using Template.ViewModels.Base;

namespace Template.Interface
{
    public interface IMsPermissionService
    {
        Task<IEnumerable<MsPermissionViewModel>> Index();
        Task<MsPermissionViewModel> GetMsPermissionByID(int PermissionID);
        Task<ReturnViewModel> Update(MsPermissionViewModel viewModel);
        Task<ReturnViewModel> Delete(int PermissionID);
    }
}