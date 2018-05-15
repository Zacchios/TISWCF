namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Role
    {
        public int RoleID { get; set; }

        public int RoleTypeID { get; set; }

        [Column("Role")]
        [Required]
        [StringLength(32)]
        public string Role1 { get; set; }

        [Required]
        [StringLength(64)]
        public string Prepositional { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public int? AnonymousNameID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
