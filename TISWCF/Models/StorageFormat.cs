namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StorageFormat
    {
        public int StorageFormatID { get; set; }

        [Column("StorageFormat")]
        [Required]
        [StringLength(32)]
        public string StorageFormat1 { get; set; }

        [StringLength(64)]
        public string BitmapName { get; set; }

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
