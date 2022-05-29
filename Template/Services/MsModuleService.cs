using ApplicationCore.Interface.Base;
using ApplicationCore.Spesification;
using ApplicationCore.Spesification.MsModuleSpesification;
using AutoMapper;
using MediatR;
using Template.Domain.Entity;
using Template.Interface;
using Template.ViewModels;

namespace Template.Services
{
    public class MsModuleService : IMsModuleService
    {
        private readonly IRepository<MsModule> _msModuleRepository;
        private readonly IMapper _mapper;
        public MsModuleService(
            IRepository<MsModule> msModuleRepository, 
            IMapper mapper
            )
        {
            _msModuleRepository = msModuleRepository;
            _mapper = mapper;
        }
        public Task Delete(string ModuleID)
        {
            throw new NotImplementedException();
        }

        public async Task<MsModuleViewModel> GetMsModuleByID(string ModuleID)
        {
            var filterSpecification = new GetMsModuleByModuleID(ModuleID);
            var msModule = _msModuleRepository.GetByIDAsync(filterSpecification);
            var ViewModel = _mapper.Map<MsModule, MsModuleViewModel>(msModule);
            return ViewModel;
        }

        public async Task<IEnumerable<MsModuleViewModel>> GetMsModuleByMsModuleDesc(string ModuleDesc)
        {
            var filterSpecification = new GetMsModuleByModuleNameSpec(ModuleDesc);
            var MsModuleList = _msModuleRepository.GetItemBySpesification(filterSpecification);
            var ViewModel = _mapper.Map<IEnumerable<MsModule>, IEnumerable<MsModuleViewModel>>(MsModuleList);
            return ViewModel;
        }

        public async Task<IEnumerable<MsModuleViewModel>> Index()
        {
            var filterSpecification = new GetMsModuleList();
            var MsModuleList = _msModuleRepository.GetAllAsync(filterSpecification);
            var ViewModel = _mapper.Map<IEnumerable<MsModule>, IEnumerable<MsModuleViewModel>>(MsModuleList);
            return ViewModel;
        }

        public Task Update(MsModuleViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}