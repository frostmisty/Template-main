using ApplicationCore.Base.Spesification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entity;

namespace ApplicationCore.Spesification.MsPageSpesification
{
    public class GetMsPageByPageID : BaseSpesification<MsPage>
    {
        public GetMsPageByPageID(string PageID) : base(x => x.PageId.Equals(PageID))
        {
            //AddInclude(x => x.PageId);
        }
    }
}
