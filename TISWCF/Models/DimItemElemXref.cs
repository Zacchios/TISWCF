namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DimItemElemXref
    {
        public int DimItemElemXrefID { get; set; }

        public int TableID { get; set; }

        public int ID { get; set; }

        public int ElementID { get; set; }

        public int MethodID { get; set; }

        public bool Displayed { get; set; }

        public byte Rank { get; set; }

        [StringLength(19)]
        public string DimensionDate { get; set; }

        [StringLength(255)]
        public string DisplayDimensions { get; set; }

        [StringLength(64)]
        public string Description { get; set; }

        public string Remarks { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
