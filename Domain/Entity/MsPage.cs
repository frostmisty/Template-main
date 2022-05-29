using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Template.Domain.Base;

namespace Template.Domain.Entity
{
    public partial class MsPage
    {
        [StringLength(10)]
        public string ModuleId { get; set; } = null!;
        [Key]
        [StringLength(10)]
        public string PageId { get; set; } = null!;
        [StringLength(100)]
        public string PageName { get; set; } = null!;
        [StringLength(100)]
        public string? PageDesc { get; set; }
        [StringLength(100)]
        public string? PageIcon { get; set; }
        [StringLength(25)]
        public string CrtUsrId { get; set; } = null!;
        public DateTime TsCrt { get; set; }
        [StringLength(25)]
        public string? ModUsrId { get; set; }
        public DateTime? TsMod { get; set; }
        [StringLength(1)]
        public string ActiveFlag { get; set; }
    }
}
