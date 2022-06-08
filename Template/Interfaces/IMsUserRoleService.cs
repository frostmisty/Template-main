using ApplicationCore.Base.Spesification;
using MediatR;
using Template.Domain.Entity;
using Template.ViewModels;
using Template.ViewModels.Base;

namespace Template.Interface
{
    public interface IMsUserRoleService
    {
        Task<IEnumerable<MsUserRoleViewModel>> Index();
        Task<MsUserRoleViewModel> GetMsUserRoleByID(string UserRoleID);
        Task<ReturnViewModel> Update(MsUserRoleViewModel viewModel);
        Task<ReturnViewModel> Delete(string UserRoleID);
    }
}