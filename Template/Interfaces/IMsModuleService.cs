using ApplicationCore.Base.Spesification;
using MediatR;
using Template.ViewModels;

namespace Template.Interface
{
    public interface IMsModuleService
    {
        Task<IEnumerable<MsModuleViewModel>> Index();
        Task<IEnumerable<MsModuleViewModel>> GetMsModuleByMsModuleDesc(string ModuleDesc);
        Task<MsModuleViewModel> GetMsModuleByID(string ModuleID);
        Task Update(MsModuleViewModel viewModel);
        Task Delete(string ModuleID);
    }
}