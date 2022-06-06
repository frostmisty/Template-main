using ApplicationCore.Base.Spesification;
using MediatR;
using Template.Domain.Entity;
using Template.ViewModels;
using Template.ViewModels.Base;

namespace Template.Interface
{
    public interface IMsPageService
    {
        Task<IEnumerable<MsPageViewModel>> Index();
        Task<MsPageViewModel> GetMsPageByID(string PageID);
        Task<ReturnViewModel> Update(MsPageViewModel viewModel);
        Task<ReturnViewModel> Delete(string PageID);
    }
}