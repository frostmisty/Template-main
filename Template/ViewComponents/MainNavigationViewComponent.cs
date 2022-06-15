using ApplicationCore.Additional;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Template.Domain.Additional;
using Template.ViewModels.Base;

namespace Template.ViewComponents
{
    public class MainNavigationViewComponent : ViewComponent
    {
        private readonly IGetMenu _getMenu;
        public MainNavigationViewComponent(IGetMenu getMenu)
        {
            _getMenu = getMenu;

        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            var menuList = new List<DtoGetMenu>();
            var header = _getMenu.GetMenuListDto("01135702", "");
            var child = _getMenu.GetMenuListChild("01135702", "");

            foreach(var item in header)
            {
                menuList.Add(new DtoGetMenu(){
                    PageId = item.PageId,
                    ParentId = item.ParentId,
                    MenuId = item.MenuId,
                    PageIcon = item.PageIcon,
                    PageName = item.PageName,
                    MenuText = item.MenuText,
                    Seq = item.Seq,
                    Children = child.Where(x=> x.ParentId.Equals(item.MenuId)).ToList(),
                });
            }

            return Task.FromResult((IViewComponentResult)View("MainNavigation", menuList)) ;

        }
    }
}