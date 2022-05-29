﻿using ApplicationCore.Base.Spesification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entity;

namespace ApplicationCore.Spesification.MsModuleSpesification
{ 
    public class GetMsModuleByModuleID : BaseSpesification<MsModule>
    {
        public GetMsModuleByModuleID(string ModuleID) : base(x => x.ModuleId.Equals(ModuleID))
        {
            //AddInclude(x => x.ModuleId);
        }
    }
}
