using ApplicationCore.Base.Spesification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entity;

namespace ApplicationCore.Spesification.MsUserSpesification
{
    public class GetMsUserByUserID : BaseSpesification<MsUser>
    {
        public GetMsUserByUserID(string ModuleID, string UserID, string UserRoleId) 
            : base(x => (x.UserId.Equals(UserID) && x.ModuleId.Equals(ModuleID) && x.UserRoleId.Equals(UserRoleId)))
        {
            //AddInclude(x => x.UserId);
        }
    }
}
