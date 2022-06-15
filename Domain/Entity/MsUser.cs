using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Template.Domain.Base;

namespace Template.Domain.Entity
{
    public partial class MsUser
    {
        [Key,Column(Order = 0)]
        [StringLength(10)]
        public string ModuleId { get; set; }
        [Key, Column(Order = 1)]
        [StringLength(10)]
        public string UserId { get; set; }
        [Key,Column(Order = 2)]
        [StringLength(50)]
        public string UserRoleId { get; set; }
        [StringLength(50)]
        public string? Area { get; set; }
        [StringLength(50)]
        public string? FullName { get; set; }
        public string? Password { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        public string? Info1 { get; set; }
        public string? Info2 { get; set; }
        public string? Info3 { get; set; }
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
