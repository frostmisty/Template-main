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
    public class GetMsMenuList : BaseSpesification<MsMenu>
    {
        public GetMsMenuList() : base(x => x.ActiveFlag.Equals("Y"))
        {
        }
    }
}
