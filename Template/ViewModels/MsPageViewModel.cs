using Microsoft.AspNetCore.Mvc.Rendering;
using Template.ViewModels.Base;

namespace Template.ViewModels
{
    public class MsPageViewModel
    {
        public string ModuleId { get; set; }
        public string PageId { get; set; }
        public string PageDesc { get; set; }
        public string PageName { get; set; }
        public string PageIcon { get; set; }
        public string CrtUsrId { get; set; }
        public DateTime TsCrt { get; set; }
        public string ModUsrId { get; set; }
        public DateTime TsMod { get; set; }
        public string ActiveFlag { get; set; }
        public ReturnViewModel ReturnViewModel { get; set; }
        public List<SelectListItem> GetModule { get; set; }
    }
}