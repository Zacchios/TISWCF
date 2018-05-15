namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RoleType
    {
        public int RoleTypeID { get; set; }

        [Column("RoleType")]
        [Required]
        [StringLength(32)]
        public string RoleType1 { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public int? DefaultRoleID { get; set; }

        public int? PrimaryRoleID { get; set; }

        public bool AllowsAnonymousAccess { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
