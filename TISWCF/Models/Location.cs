namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Location
    {
        public int LocationID { get; set; }

        [StringLength(64)]
        public string UnitType { get; set; }

        [StringLength(16)]
        public string UnitSizeCode { get; set; }

        public short? UnitMaxLevels { get; set; }

        [StringLength(16)]
        public string UnitConfig { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UnitHeightCM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UnitWidthCM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UnitDepthCM { get; set; }

        public short SecurityCode { get; set; }

        [StringLength(64)]
        public string BitmapName { get; set; }

        public short? XCoord { get; set; }

        public short? YCoord { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        [StringLength(128)]
        public string Site { get; set; }

        [StringLength(128)]
        public string Room { get; set; }

        public byte? Active { get; set; }

        [StringLength(64)]
        public string UnitPosition { get; set; }

        public byte? PublicAccess { get; set; }

        [StringLength(64)]
        public string UnitNumber { get; set; }

        [StringLength(512)]
        public string LocationString { get; set; }

        public bool External { get; set; }

        public int AddressID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }

        public int ConservationEntityID { get; set; }
    }
}
