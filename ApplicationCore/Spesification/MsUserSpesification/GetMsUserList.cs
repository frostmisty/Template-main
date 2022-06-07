﻿using ApplicationCore.Base.Spesification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entity;

namespace ApplicationCore.Spesification.MsUserSpesification
{
    public class GetMsUserList : BaseSpesification<MsUser>
    {
        public GetMsUserList() : base(x => x.ActiveFlag.Equals("Y"))
        {
        }
    }
}