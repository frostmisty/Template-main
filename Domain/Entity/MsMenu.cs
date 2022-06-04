using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Template.Domain.Base;

namespace Template.Domain.Entity
{
    public partial class MsMenu
    {
        [Key]
        public string MenuId { get; set; }
        [StringLength(10)]
        public string ModuleId { get; set; }
        [StringLength(10)]
        public string PageId { get; set; }
        public string? ParentId { get; set; }
        public int? Seq { get; set; }
        [StringLength(50)]
        public string? MenuText { get; set; }
        [StringLength(25)]
        public string CrtUsrId { get; set; }
        public DateTime TsCrt { get; set; }
        [StringLength(25)]
        public string? ModUsrId { get; set; }
        public DateTime? TsMod { get; set; }
        [StringLength(1)]
        public string ActiveFlag { get; set; }
    }
}
