using ApplicationCore.Base.Spesification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entity;

namespace ApplicationCore.Spesification.MsUserRoleSpesification
{
    public class GetMsUserRoleByUserRoleID : BaseSpesification<MsUserRole>
    {
        public GetMsUserRoleByUserRoleID(string UserRoleID) : base(x => x.UserRoleId.Equals(UserRoleID))
        {
            //AddInclude(x => x.UserRoleId);
        }
    }
}
