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
    public class GetMsEnumItemByItemCategory : BaseSpesification<MsEnumItem>
    {
        public GetMsEnumItemByItemCategory(string ItemCategory) : base(x => x.ItemCategory.Equals(ItemCategory))
        {
            AddInclude(x => x.ActiveFlag.Equals("Y"));
        }
    }
}
