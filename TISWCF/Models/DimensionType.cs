namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DimensionType
    {
        public int DimensionTypeID { get; set; }

        [Column("DimensionType")]
        [Required]
        [StringLength(32)]
        public string DimensionType1 { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public byte UnitTypeID { get; set; }

        public int? PrimaryUnitID { get; set; }

        public int? SecondaryUnitID { get; set; }

        public byte System { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
