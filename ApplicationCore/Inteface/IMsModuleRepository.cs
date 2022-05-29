using Infrastructure.Context;
using Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entity;

namespace ApplicationCore.Interface
{
    public interface IMsModuleRepository : IRepository<MsModule>
    { 
        Task<List<MsModule>> GetAllAsync();

        Task<List<MsModule>> GetMsModuleCustom(string whereclause, string orderby);
        Task<MsModule> GetByIDAsync(string id);
        Task<MsModule> AddAsync(MsModule module);
        Task DeleteAsync(MsModule module);
    }
}
