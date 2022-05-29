using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Template.Domain.Base
{
    public partial class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(25)]
        public string CrtUsrId { get; set; } = null!;
        [DefaultValue("getdate()")]
        public DateTime TsCrt { get; set; }
        [StringLength(25)]
        public string? ModUsrId { get; set; }
        [DefaultValue("getdate()")]
        public DateTime? TsMod { get; set; }
        [StringLength(1)]
        [DefaultValue("Y")]
        public string ActiveFlag { get; set; }

    }
}
