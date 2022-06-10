using ApplicationCore.Additional;
using ApplicationCore.Base.Spesification;
using Infrastructure.Context;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Additional;
using Template.Domain.Base;

namespace Infrastructure.Repository.RenderMenu
{
    public class GetMenu : IGetMenu
    {
        protected readonly MainTemplateContext _mainTemplateContext;
        public GetMenu(MainTemplateContext mainTemplateContext)
        {
            _mainTemplateContext = mainTemplateContext;
        }
        public DtoGetMenu GetMenuList(string UserId, string userRoleId)
        {
            var menu = new DtoGetMenu();
            var Param1 = new SqlParameter("@UserID", UserId);
            var Param2 = new SqlParameter("@UserRoleID", userRoleId);
            var getmenu = _mainTemplateContext.Database.ExecuteSqlRaw("EXEC GetMenu @UserID,@UserRoleID", Param1, Param2);
            return menu;
        }
    }
}
