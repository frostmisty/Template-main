using ApplicationCore.Base.Spesification;
using MediatR;
using Template.Domain.Entity;
using Template.ViewModels;
using Template.ViewModels.Base;

namespace Template.Interface
{
    public interface IMsUserService
    {
        Task<IEnumerable<MsUserViewModel>> Index();
        Task<MsUserViewModel> GetMsUserByID(string ModuleID, string UserID, string UserRoleId);
        Task<ReturnViewModel> Update(MsUserViewModel viewModel);
        Task<ReturnViewModel> Delete(string ModuleID, string UserID, string UserRoleId);
    }
}