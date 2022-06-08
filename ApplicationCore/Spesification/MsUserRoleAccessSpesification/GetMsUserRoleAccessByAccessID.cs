using ApplicationCore.Base.Spesification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entity;

namespace ApplicationCore.Spesification.MsUserRoleAccessSpesification
{ 
    public class GetMsUserRoleAccessByUserRoleAccessID : BaseSpesification<MsUserRoleAccess>
    {
        public GetMsUserRoleAccessByUserRoleAccessID(int AccessID) : base(x => x.AccessID.Equals(AccessID))
        {
            //AddInclude(x => x.UserRoleAccessId);
        }
    }
}
