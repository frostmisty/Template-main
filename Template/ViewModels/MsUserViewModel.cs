using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using Template.ViewModels.Base;

namespace Template.ViewModels
{
    public class MsUserViewModel
    {
        public string ModuleId { get; set; }
        public string UserId { get; set; }
        public string UserRoleId { get; set; }
        public string Area { get; set; }
        public string FullName { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string Info3 { get; set; }
        public string CrtUsrId { get; set; }
        public DateTime TsCrt { get; set; }
        public string ModUsrId { get; set; }
        public DateTime TsMod { get; set; }
        public string ActiveFlag { get; set; }
        public ReturnViewModel ReturnViewModel { get; set; }
        public List<SelectListItem> GetModule { get; set; }
        public List<SelectListItem> GetUserRole { get; set; }
    }
}