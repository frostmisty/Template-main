using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Template.Domain.Base;

namespace Template.Domain.Additional
{
    public class DtoGetMenu
    {
        public string PageId { get; set; }
        public string ParentId { get; set; }
        public string MenuId { get; set; }
        public string MenuText { get; set; }
        public int Seq { get; set; }
    }
}

