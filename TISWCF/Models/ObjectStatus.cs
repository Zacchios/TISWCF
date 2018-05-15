namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ObjectStatuses")]
    public partial class ObjectStatus
    {
        public int ObjectStatusID { get; set; }

        [Column("ObjectStatus")]
        [Required]
        [StringLength(48)]
        public string ObjectStatus1 { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public bool? InPermanentJurisdiction { get; set; }

        public bool System { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
