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
    public class GetMsModuleByModuleNameSpec : BaseSpesification<MsModule>
    {
        public GetMsModuleByModuleNameSpec(string ModuleName) : base(x => x.Equals(ModuleName))
        {
            //AddInclude(x => x.ModuleDesc);
        }
    }
}
