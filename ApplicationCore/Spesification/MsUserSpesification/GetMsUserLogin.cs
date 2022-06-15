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
    public class GetMsUserLogin : BaseSpesification<MsUser>
    {
        public GetMsUserLogin(string UserID, string Password) 
            : base(x => (x.UserId.Equals(UserID) && x.Password.Equals(Password)))
        {
            //AddInclude(x => x.UserId);
        }
    }
}
