namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CondLineItem
    {
        public int CondLineItemID { get; set; }

        public int ConditionID { get; set; }

        [StringLength(32)]
        public string LineItemType { get; set; }

        [StringLength(255)]
        public string BriefDescription { get; set; }

        public string Statement { get; set; }

        public string Proposal { get; set; }

        public byte ActionRequired { get; set; }

        public byte ActionTaken { get; set; }

        public DateTime? DateCompleted { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public string Treatment { get; set; }

        public int AttributeTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DurationDays { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
