using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Template.Domain.Base;

namespace Template.Domain.Entity
{
    public partial class MsEnumItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemID { get; set; }
        [StringLength(50)]
        public string? ItemCategory { get; set; }
        public int? Sequence { get; set; }
        [StringLength(50)]
        public string? ItemValue { get; set; }
        [StringLength(100)]
        public string? ItemDesc { get; set; }
        [StringLength(50)]
        public string? ParentId { get; set; }
        [StringLength(250)]
        public string? Remark { get; set; }
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
