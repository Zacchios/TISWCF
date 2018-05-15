namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ConXrefDetail
    {
        public int ConXrefDetailID { get; set; }

        public int ConXrefID { get; set; }

        public int? RoleTypeID { get; set; }

        public int NameID { get; set; }

        public int ConstituentID { get; set; }

        public int? AddressID { get; set; }

        public int? DateBegin { get; set; }

        public int? DateEnd { get; set; }

        [StringLength(64)]
        public string Prefix { get; set; }

        [StringLength(512)]
        public string Remarks { get; set; }

        public string ConStatement { get; set; }

        [StringLength(64)]
        public string Suffix { get; set; }

        [StringLength(255)]
        public string Amount { get; set; }

        [StringLength(80)]
        public string DisplayDate { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public int DepartmentID { get; set; }

        public bool? UnMasked { get; set; }

        public int DisplayBioID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
