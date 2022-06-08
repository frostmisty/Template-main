using ApplicationCore.Interface.Base;
using ApplicationCore.Spesification.MsPermissionSpesification;
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
    public class MsPermissionService : IMsPermissionService
    {
        private readonly IRepository<MsPermission> _msPermissionRepository;
        private readonly IMapper _mapper;
        public MsPermissionService(
            IRepository<MsPermission> msPermissionRepository, 
            IMapper mapper
            )
        {
            _msPermissionRepository = msPermissionRepository;
            _mapper = mapper;
        }
        public async Task<ReturnViewModel> Delete(int PermissionID)
        {
            bool IsSuccess = false;
            var filterSpesification = new GetMsPermissionByPermissionID(PermissionID);
            var msPermission = _msPermissionRepository.GetByIDAsync(filterSpesification);
            var returnView = new ReturnViewModel();
            if (msPermission != null)
            {
                msPermission.ActiveFlag = "N";
            }
            try
            {
                await _msPermissionRepository.DeleteAsync(msPermission);
                IsSuccess = true;
                returnView.IsSuccess = IsSuccess;
            }
            catch(Exception ex)
            {
                returnView.IsSuccess = IsSuccess;
                returnView.ReturnValue = ex.InnerException.Message;
            }
            return returnView;
        }

        public async Task<MsPermissionViewModel> GetMsPermissionByID(int PermissionID)
        {
            var filterSpecification = new GetMsPermissionByPermissionID(PermissionID);
            var msPermission = _msPermissionRepository.GetByIDAsync(filterSpecification);
            var ViewModel = _mapper.Map<MsPermission, MsPermissionViewModel>(msPermission);
            if(ViewModel == null)
            {
                ViewModel = new MsPermissionViewModel();
            }
            return ViewModel;
        }

        //public async Task<IEnumerable<MsPermissionViewModel>> GetMsPermissionByMsPermissionDesc(string PermissionDesc)
        //{
        //    var filterSpecification = new GetMsPermissionByPermissionID(PermissionDesc);
        //    var MsPermissionList = _msPermissionRepository.GetItemBySpesification(filterSpecification);
        //    var ViewModel = _mapper.Map<IEnumerable<MsPermission>, IEnumerable<MsPermissionViewModel>>(MsPermissionList);
        //    if (ViewModel == null)
        //    {
        //        ViewModel = new List<MsPermissionViewModel>();
        //    }
        //    return ViewModel;
        //}

        public async Task<IEnumerable<MsPermissionViewModel>> Index()
        {
            var filterSpecification = new GetMsPermissionList();
            var MsPermissionList = _msPermissionRepository.GetAllAsync(filterSpecification);
            var ViewModel = _mapper.Map<IEnumerable<MsPermission>, IEnumerable<MsPermissionViewModel>>(MsPermissionList);
            if (ViewModel == null)
            {
                ViewModel = new List<MsPermissionViewModel>();
            }
            return ViewModel;
        }



        public async Task<ReturnViewModel> Update(MsPermissionViewModel viewModel)
        {
            bool IsNew = false;
            bool IsSuccess = false;
            var returnView = new ReturnViewModel();
            var checkPermissionID = new GetMsPermissionByPermissionID(viewModel.PermissionID);
            var msPermission = _msPermissionRepository.GetByIDAsync(checkPermissionID);
            if (msPermission == null)
            {
                msPermission = new MsPermission
                {
                    CrtUsrId = "SYSTEM",
                    //TsCrt = DateTime.Now,
                    //ActiveFlag = "Y"
                };
                IsNew = true;
            }
            else
            {
                msPermission.ModUsrId = "SYSTEM";
                msPermission.TsMod = DateTime.Now;
            }
            msPermission.PermissionID = viewModel.PermissionID;
            msPermission.PermissionDesc = viewModel.PermissionDesc;

            try
            {
                if (IsNew == true)
                {
                    await _msPermissionRepository.AddAsync(msPermission);
                }
                else
                {
                    await _msPermissionRepository.UpdateAsync(msPermission);
                }
                IsSuccess = true;
                returnView.IsSuccess = IsSuccess;
            }
            catch (Exception ex)
            {
                returnView.IsSuccess = IsSuccess;
                returnView.ReturnValue = ex.InnerException.Message;
            }

            return returnView;
        }
    }
}