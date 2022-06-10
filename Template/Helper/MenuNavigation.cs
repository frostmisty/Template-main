using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template.MVC.Helpers
{
    public static class MenuNavigation
    {
        public static string NavBar(this HtmlHelper helper, string menu)
        {
            return new string(menu);
        }
    }
}
