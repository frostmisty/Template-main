using Microsoft.AspNetCore.Mvc.Rendering;
using Template.ViewModels.Base;

namespace Template.ViewModels
{
    public class MsEnumItemViewModel
    {
        public int ItemID { get; set; }
        public string ItemCategory { get; set; }
        public int Sequence { get; set; }
        public string ParentId { get; set; }
        public string ItemValue { get; set; }
        public string ItemDesc { get; set; }
        public string Remark { get; set; }
        public string CrtUsrId { get; set; }
        public DateTime TsCrt { get; set; }
        public string ModUsrId { get; set; }
        public DateTime TsMod { get; set; }
        public string ActiveFlag { get; set; }
        public ReturnViewModel ReturnViewModel { get; set; }
        public List<SelectListItem> GetItemCategory { get; set; }
    }
}