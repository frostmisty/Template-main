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
    public class GetMsMenuByMenuID : BaseSpesification<MsMenu>
    {
        public GetMsMenuByMenuID(string MenuID) : base(x => x.MenuId.Equals(MenuID))
        {
            //AddInclude(x => x.MenuId);
        }
    }
}
