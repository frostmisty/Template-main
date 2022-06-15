using ApplicationCore.Additional;
using Infrastructure.Repository.RenderMenu;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Additional;

namespace Template.MVC.Helpers
{
    public static class MenuNavigation
    {
        public static HtmlString NavBar(HtmlHelper helper,string menus)
        {
            return new HtmlString(menus);
        }
    }
}
