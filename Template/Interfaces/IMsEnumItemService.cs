using ApplicationCore.Base.Spesification;
using MediatR;
using Template.Domain.Entity;
using Template.ViewModels;
using Template.ViewModels.Base;

namespace Template.Interface
{
    public interface IMsEnumItemService
    {
        Task<IEnumerable<MsEnumItemViewModel>> Index();
        Task<MsEnumItemViewModel> GetMsEnumItemByID(int ItemID);
        Task<ReturnViewModel> Update(MsEnumItemViewModel viewModel);
        Task<ReturnViewModel> Delete(int ItemID);
    }
}