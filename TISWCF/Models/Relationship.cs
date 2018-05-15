namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Relationship
    {
        public int RelationshipID { get; set; }

        [StringLength(50)]
        public string Relation1 { get; set; }

        [StringLength(50)]
        public string Relation2 { get; set; }

        public int TableID { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public byte? RelationshipTypeID { get; set; }

        [StringLength(50)]
        public string Relation1Plural { get; set; }

        [StringLength(50)]
        public string Relation2Plural { get; set; }

        [StringLength(64)]
        public string Rel1Prep { get; set; }

        [StringLength(64)]
        public string Rel1PluralPrep { get; set; }

        [StringLength(64)]
        public string Rel2Prep { get; set; }

        [StringLength(64)]
        public string Rel2PluralPrep { get; set; }

        public bool MoveCoLocated { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }

        public bool? Transitive { get; set; }
    }
}
