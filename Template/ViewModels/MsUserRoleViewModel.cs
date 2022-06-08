using Microsoft.AspNetCore.Mvc.Rendering;
using Template.ViewModels.Base;

namespace Template.ViewModels
{
    public class MsUserRoleViewModel
    {
        public string ModuleId { get; set; }
        public string UserRoleId { get; set; }
        public string UserRoleDesc { get; set; }
        public string CrtUsrId { get; set; }
        public DateTime TsCrt { get; set; }
        public string ModUsrId { get; set; }
        public DateTime TsMod { get; set; }
        public string ActiveFlag { get; set; }
        public ReturnViewModel ReturnViewModel { get; set; }
        public List<SelectListItem> GetModule { get; set; }
    }
}