using Microsoft.AspNetCore.Mvc.Rendering;
using Template.ViewModels.Base;

namespace Template.ViewModels
{
    public class MsMenuViewModel
    {
        public string ModuleId { get; set; }
        public string PageId { get; set; }
        public string MenuId { get; set; }
        public string ParentId { get; set; }
        public int Seq { get; set; }
        public string MenuText { get; set; }
        public string CrtUsrId { get; set; }
        public DateTime TsCrt { get; set; }
        public string ModUsrId { get; set; }
        public DateTime TsMod { get; set; }
        public string ActiveFlag { get; set; }
        public ReturnViewModel ReturnViewModel { get; set; }
        public List<SelectListItem> GetModule { get; set; }
        public List<SelectListItem> GetPage{ get; set; }
        public List<SelectListItem> GetMenu { get; set; }
    }
}