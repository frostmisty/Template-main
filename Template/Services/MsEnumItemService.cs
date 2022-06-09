using ApplicationCore.Interface.Base;
using ApplicationCore.Spesification.MsEnumItemSpesification;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Data;
using Template.Domain.Entity;
using Template.Interface;
using Template.ViewModels;
using Template.ViewModels.Base;

namespace Template.Services
{
    public class MsEnumItemService : IMsEnumItemService
    {
        private readonly IRepository<MsEnumItem> _msEnumItemRepository;
        private readonly IGeneralService _generalService;
        private readonly IMapper _mapper;
        public MsEnumItemService(
            IRepository<MsEnumItem> msEnumItemRepository,
            IGeneralService generalService,
            IMapper mapper
            )
        {
            _msEnumItemRepository = msEnumItemRepository;
            _generalService = generalService;
            _mapper = mapper;
        }
        public async Task<ReturnViewModel> Delete(int EnumItemID)
        {
            bool IsSuccess = false;
            var filterSpesification = new GetMsEnumItemByEnumItemID(EnumItemID);
            var msEnumItem = _msEnumItemRepository.GetByIDAsync(filterSpesification);
            var returnView = new ReturnViewModel();
            if (msEnumItem != null)
            {
                msEnumItem.ActiveFlag = "N";
            }
            else
            {
                returnView.IsSuccess = IsSuccess;
                return returnView;
            }
            try
            {
                await _msEnumItemRepository.DeleteAsync(msEnumItem);
                IsSuccess = true;
                returnView.IsSuccess = IsSuccess;
            }
            catch(Exception ex)
            {
                returnView.IsSuccess = IsSuccess;
                returnView.ReturnValue = ex.InnerException == null ? ex.Message : ex.InnerException.Message;
            }
            return returnView;
        }

        public async Task<MsEnumItemViewModel> GetMsEnumItemByID(int EnumItemID)
        {
            var filterSpecification = new GetMsEnumItemByEnumItemID(EnumItemID);
            var msEnumItem = _msEnumItemRepository.GetByIDAsync(filterSpecification);
            var ViewModel = _mapper.Map<MsEnumItem, MsEnumItemViewModel>(msEnumItem);
            if(ViewModel == null)
            {
                ViewModel = new MsEnumItemViewModel();
            }
            ViewModel.GetItemCategory = (await _generalService.GetItemCategoryList()).ToList();
            return ViewModel;
        }

        public async Task<IEnumerable<MsEnumItemViewModel>> GetMsEnumItemByItemValue(string EnumItemDesc)
        {
            var filterSpecification = new GetMsEnumItemByItemValue(EnumItemDesc);
            var MsEnumItemList = _msEnumItemRepository.GetItemBySpesification(filterSpecification);
            var ViewModel = _mapper.Map<IEnumerable<MsEnumItem>, IEnumerable<MsEnumItemViewModel>>(MsEnumItemList);
            if (ViewModel == null)
            {
                ViewModel = new List<MsEnumItemViewModel>();
            }
            return ViewModel;
        }

        public async Task<IEnumerable<MsEnumItemViewModel>> Index()
        {
            var filterSpecification = new GetMsEnumItemList();
            var MsEnumItemList = _msEnumItemRepository.GetAllAsync(filterSpecification);
            var ViewModel = _mapper.Map<IEnumerable<MsEnumItem>, IEnumerable<MsEnumItemViewModel>>(MsEnumItemList);
            if (ViewModel == null)
            {
                ViewModel = new List<MsEnumItemViewModel>();
            }
            return ViewModel;
        }

        public async Task<ReturnViewModel> Update(MsEnumItemViewModel viewModel)
        {
            bool IsNew = false;
            bool IsSuccess = false;
            var returnView = new ReturnViewModel();
            var checkEnumItemID = new GetMsEnumItemByEnumItemID(viewModel.ItemID);
            var msEnumItem = _msEnumItemRepository.GetByIDAsync(checkEnumItemID);
            if (msEnumItem == null)
            {
                msEnumItem = new MsEnumItem
                {
                    CrtUsrId = "SYSTEM",
                    //TsCrt = DateTime.Now,
                    //ActiveFlag = "Y"
                };
                IsNew = true;
            }
            else
            {
                msEnumItem.ModUsrId = "SYSTEM";
                msEnumItem.TsMod = DateTime.Now;
            }
            msEnumItem.ItemID = viewModel.ItemID;
            msEnumItem.ItemCategory = viewModel.ItemCategory;
            msEnumItem.Sequence = viewModel.Sequence;
            msEnumItem.ItemValue = viewModel.ItemValue;
            msEnumItem.ItemDesc = viewModel.ItemDesc;
            msEnumItem.ParentId = viewModel.ParentId;
            msEnumItem.Remark = viewModel.Remark;
            try
            {
                if (IsNew == true)
                {
                    await _msEnumItemRepository.AddAsync(msEnumItem);
                }
                else
                {
                    await _msEnumItemRepository.UpdateAsync(msEnumItem);
                }
                IsSuccess = true;
                returnView.IsSuccess = IsSuccess;
            }
            catch (Exception ex)
            {
                returnView.IsSuccess = IsSuccess;
                returnView.ReturnValue = ex.InnerException == null ? ex.Message : ex.InnerException.Message;
            }

            return returnView;
        }
    }
}