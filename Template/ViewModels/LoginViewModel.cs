using Microsoft.AspNetCore.Mvc.Rendering;
using Template.ViewModels.Base;

namespace Template.ViewModels
{
    public class LoginViewModel
    {
        public string userID { get; set; }
        public string Password { get; set; }
        public string Lokasi { get; set; }
        public ReturnViewModel ReturnViewModel { get; set; }
        public List<SelectListItem> GetItemCategory { get; set; }
    }
}