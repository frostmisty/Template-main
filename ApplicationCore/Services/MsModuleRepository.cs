using ApplicationCore.Interface;
using Infrastructure.Context;
using Infrastructure.Repository.Base;
using Infrastructure.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entity;

namespace ApplicationCore.Services
{
    public class MsModuleRepository : MainTemplateRepository<MsModule>, IMsModuleRepository
    {
        public MsModuleRepository(MainTemplateContext mainTemplateContext) : base(mainTemplateContext)
        {
        }

        public Task<MsModule> AddAsync(MsModule module)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(MsModule module)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MsModule>> GetAllAsync()
        {
            return _mainTemplateContext.MsModules
                .Where("Activeflag == \"Y\"")
                .ToList();
        }

        public async Task<MsModule> GetByIDAsync(string id)
        {
             var context = _mainTemplateContext.MsModules
                .Where("ModuleID == @0 && Activeflag == \"Y\"", id).FirstOrDefault();
            return context;
        }

        public async Task<List<MsModule>> GetMsModuleCustom(string whereclause, string orderby)
        {
            whereclause = whereclause + " && Activeflag == \"Y\"";
            var context = _mainTemplateContext.MsModules.Where(whereclause).OrderBy(orderby).ToList();
            return context;
        }
    }
}
