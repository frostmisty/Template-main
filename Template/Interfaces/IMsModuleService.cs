using ApplicationCore.Base.Spesification;
using MediatR;
using Template.Domain.Entity;
using Template.ViewModels;
using Template.ViewModels.Base;

namespace Template.Interface
{
    public interface IMsModuleService
    {
        Task<IEnumerable<MsModuleViewModel>> Index();
        Task<IEnumerable<MsModuleViewModel>> GetMsModuleByMsModuleDesc(string ModuleDesc);
        Task<MsModuleViewModel> GetMsModuleByID(string ModuleID);
        Task<ReturnViewModel> Update(MsModuleViewModel viewModel);
        Task<ReturnViewModel> Delete(string ModuleID);
    }
}