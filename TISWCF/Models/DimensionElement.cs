namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DimensionElement
    {
        [Key]
        public int ElementID { get; set; }

        [Required]
        [StringLength(32)]
        public string Element { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public byte Displayed { get; set; }

        public byte ShowElementName { get; set; }

        public byte ShowDescription { get; set; }

        public short Position { get; set; }

        public byte ShowSecondaryUnit { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
