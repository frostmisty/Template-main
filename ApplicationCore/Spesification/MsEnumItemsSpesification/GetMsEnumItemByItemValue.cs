using ApplicationCore.Base.Spesification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entity;

namespace ApplicationCore.Spesification.MsEnumItemSpesification
{
    public class GetMsEnumItemByItemValue : BaseSpesification<MsEnumItem>
    {
        public GetMsEnumItemByItemValue(string ItemValue) : base(x => x.ItemValue.Equals(ItemValue))
        {
            AddInclude(x => x.ActiveFlag.Equals("Y"));
        }
    }
}
