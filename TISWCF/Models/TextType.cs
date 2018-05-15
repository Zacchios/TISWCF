namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TextType
    {
        public int TextTypeID { get; set; }

        public int TableID { get; set; }

        [Column("TextType")]
        [Required]
        [StringLength(64)]
        public string TextType1 { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }

        public int? UseAsField { get; set; }
    }
}
