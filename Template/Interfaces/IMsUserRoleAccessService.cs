using ApplicationCore.Base.Spesification;
using MediatR;
using Template.Domain.Entity;
using Template.ViewModels;
using Template.ViewModels.Base;

namespace Template.Interface
{
    public interface IMsUserRoleAccessService
    {
        Task<IEnumerable<MsUserRoleAccessViewModel>> Index();
        Task<MsUserRoleAccessViewModel> GetMsUserRoleAccessByID(int AccessID);
        Task<ReturnViewModel> Update(MsUserRoleAccessViewModel viewModel);
        Task<ReturnViewModel> Delete(int AccessID);
    }
}