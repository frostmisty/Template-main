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
    public class GetMsMenuHeaderList : BaseSpesification<MsMenu>
    {
        public GetMsMenuHeaderList() : base(x => x.ActiveFlag.Equals("Y"))
        {
            AddInclude(x => x.ParentId.Equals(null));
        }
    }
}
