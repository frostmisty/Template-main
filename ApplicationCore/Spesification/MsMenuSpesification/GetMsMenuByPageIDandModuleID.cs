using ApplicationCore.Base.Spesification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entity;

namespace ApplicationCore.Spesification.MsMenuSpesification
{
    public class GetMsMenuByPageIDandModuleID : BaseSpesification<MsMenu>
    {
        public GetMsMenuByPageIDandModuleID(string PageID,string ModuleID) 
            : base(x => (x.PageId.Equals(PageID) && x.ModuleId.Equals(ModuleID)))
        {
            //AddInclude(x => x.MenuId);
        }
    }
}
