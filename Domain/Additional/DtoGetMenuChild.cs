using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Template.Domain.Base;

namespace Template.Domain.Additional
{
    public class DtoGetMenuChild
    {
        public string PageId { get; set; }
        public string PageName { get; set; }

        public string PageIcon { get; set; }
        public string ParentId { get; set; }
        public string MenuId { get; set; }
        public string MenuText { get; set; }
        public int Seq { get; set; }
    }
}

