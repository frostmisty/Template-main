using ApplicationCore.Interface;
using MediatR;
using Template.Features;
using Template.ViewModels;

namespace Template.Handler
{
    public class MsModuleHandler : IRequestHandler<MsModuleFeatures,IEnumerable<MsModuleViewModel>>
    {
        private readonly IMsModuleRepository _msModuleRepository;

        public MsModuleHandler(IMsModuleRepository msModuleRepository)
        {
            _msModuleRepository = msModuleRepository;
        }

        public async Task<IEnumerable<MsModuleViewModel>> Handle(MsModuleFeatures features, CancellationToken cancellationToken)
        {
            var msModule = await _msModuleRepository.GetAllAsync();
            var msModule1 = await _msModuleRepository.GetMsModuleCustom(features.WhereClause,features.OrderBy);
            var msModule2 = await _msModuleRepository.GetByIDAsync("M0001");
            if (msModule == null)
            {
                return null;
            }
            return msModule.Select(x => new MsModuleViewModel { 
                ModuleId = x.ModuleId,
                ModuleDesc = x.ModuleDesc,
                Info1 = x.Info1,
                Info2 = x.Info2,
                Info3 = x.Info3,
                CrtUsrId = x.CrtUsrId,
                TsCrt = x.TsCrt,
                ModUsrId = x.ModUsrId,
                TsMod = (DateTime)x.TsMod,
                ActiveFlag = x.ActiveFlag
            });
        }
    }
}