using ApplicationCore.Base.Spesification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entity;

namespace ApplicationCore.Spesification.MsPermissionSpesification
{
    public class GetMsPermissionByPermissionID : BaseSpesification<MsPermission>
    {
        public GetMsPermissionByPermissionID(string PermissionID) : base(x => x.PermissionID.Equals(PermissionID))
        {
            //AddInclude(x => x.PermissionId);
        }
    }
}
