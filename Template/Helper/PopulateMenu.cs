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
    public class PopulateMenu
    {
        private readonly IGetMenu _getMenu;

        public PopulateMenu()
        {
        }

        public PopulateMenu(IGetMenu getMenu)
        {
            _getMenu = getMenu;
        }

        public string Menus()
        {
            var menu = _getMenu.GetMenuList("01135702", "");
            return menu;
        }
    }
}
