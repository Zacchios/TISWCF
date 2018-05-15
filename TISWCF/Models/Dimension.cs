namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dimension
    {
        public int DimensionID { get; set; }

        public int DimItemElemXrefID { get; set; }

        public int DimensionTypeID { get; set; }

        public int PrimaryUnitID { get; set; }

        public int SecondaryUnitID { get; set; }

        public bool Displayed { get; set; }

        public byte Rank { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        [Column("Dimension")]
        public decimal Dimension1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
