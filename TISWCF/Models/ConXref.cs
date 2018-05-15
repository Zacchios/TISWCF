namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ConXref
    {
        public int ConXrefID { get; set; }

        public int ID { get; set; }

        public int RoleID { get; set; }

        public int TableID { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public short? DisplayOrder { get; set; }

        public byte? Displayed { get; set; }

        public byte? Active { get; set; }

        public int? RoleTypeID { get; set; }

        public int ConXrefSetID { get; set; }

        public bool IsDefaultDisplayBio { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
