using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Additional;

namespace ApplicationCore.Additional
{
    public interface IGetMenu
    {
        public DtoGetMenu GetMenuList(string UserId, string userRoleId);
    }
}
