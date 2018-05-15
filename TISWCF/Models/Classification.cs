namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Classification
    {
        public int ClassificationID { get; set; }

        [Column("Classification")]
        [Required]
        [StringLength(64)]
        public string Classification1 { get; set; }

        public int? AATID { get; set; }

        [StringLength(255)]
        public string AATCN { get; set; }

        public int? SourceID { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        [StringLength(32)]
        public string SubClassification { get; set; }

        [StringLength(32)]
        public string SubClassification2 { get; set; }

        [StringLength(32)]
        public string SubClassification3 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
