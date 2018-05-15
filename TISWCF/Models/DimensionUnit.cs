namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DimensionUnit
    {
        [Key]
        public int UnitID { get; set; }

        [Required]
        [StringLength(32)]
        public string UnitName { get; set; }

        public decimal ConversionFactor { get; set; }

        public int UnitTypeID { get; set; }

        public bool UnitLabelAtEnd { get; set; }

        public bool IsFractional { get; set; }

        public byte BaseDenominator { get; set; }

        public byte DecimalPlaces { get; set; }

        public short UnitCutoff { get; set; }

        public short UnitsPerSuperUnit { get; set; }

        [StringLength(32)]
        public string UnitLabel { get; set; }

        [StringLength(32)]
        public string SuperUnitLabel { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public byte? IsSuperUnit { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
