﻿using ApplicationCore.Base.Spesification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entity;

namespace ApplicationCore.Spesification.MsEnumItemSpesification
{
    public class GetMsEnumItemByEnumItemID : BaseSpesification<MsEnumitem>
    {
        public GetMsEnumItemByEnumItemID(string ItemID) : base(x => x.ItemID.Equals(ItemID))
        {
            //AddInclude(x => x.EnumItemId);
        }
    }
}
