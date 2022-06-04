using Template.ViewModels.Base;

namespace Template.ViewModels
{
    public class MsModuleViewModel
    {
        public string ModuleId { get; set; }
        public string ModuleDesc { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string Info3 { get; set; }
        public string CrtUsrId { get; set; }
        public DateTime TsCrt { get; set; }
        public string ModUsrId { get; set; }
        public DateTime TsMod { get; set; }
        public string ActiveFlag { get; set; }
        public ReturnViewModel ReturnViewModel { get; set; }
    }
}