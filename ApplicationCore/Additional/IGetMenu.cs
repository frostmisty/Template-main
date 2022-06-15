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
        public string GetMenuList(string UserId, string userRoleId);
        public List<DtoGetMenu> GetMenuListDto(string UserId, string userRoleId);
        public List<DtoGetMenuChild> GetMenuListChild(string UserId, string userRoleId);
    }
}
