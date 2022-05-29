using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Template.Domain.Base;

namespace Template.Domain.Entity
{
    public partial class MsUserRoleAccess
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccessID { get; set; }
        [StringLength(10)]
        public string ModuleId { get; set; } = null!;
        [StringLength(50)]
        public string UserRoleId { get; set; } = null!;
        [StringLength(10)]
        public string PageId { get; set; } = null!;
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
