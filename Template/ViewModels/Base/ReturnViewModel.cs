using MediatR;
using Template.ViewModels;

namespace Template.ViewModels.Base
{
    public class ReturnViewModel
    {
        public bool IsSuccess { get; set; }
        public string ReturnValue { get; set; }
    }
}