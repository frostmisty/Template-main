using Microsoft.AspNetCore.Mvc.Rendering;
using Template.ViewModels.Base;

namespace Template.ViewModels
{
    public class MsUserRoleAccessViewModel
    {
        public int AccessID { get; set; }
        public string UserRoleId { get; set; }
        public string PageId { get; set; }
        public string Permission { get; set; }
        public string PageIcon { get; set; }
        public string CrtUsrId { get; set; }
        public DateTime TsCrt { get; set; }
        public string ModUsrId { get; set; }
        public DateTime TsMod { get; set; }
        public string ActiveFlag { get; set; }
        public ReturnViewModel ReturnViewModel { get; set; }
        public List<SelectListItem> GetUserRole { get; set; }
        public List<SelectListItem> GetPage { get; set; }
        public List<SelectListItem> GetPermission { get; set; }
    }
}