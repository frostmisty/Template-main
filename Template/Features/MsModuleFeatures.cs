using MediatR;
using Template.ViewModels;

namespace Template.Features
{
    public class MsModuleFeatures : IRequest<IEnumerable<MsModuleViewModel>>
    {
        public string WhereClause { get; set; }
        public string OrderBy { get; set; } = null;

        //public MsModuleFeatures(string whereClause, string orderBy = null) 
        //{ 
        //    WhereClause = whereClause; 
        //    OrderBy = orderBy; 
        //}
    }
}