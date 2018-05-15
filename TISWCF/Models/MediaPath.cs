namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MediaPath
    {
        [Key]
        public int PathID { get; set; }

        [Required]
        [StringLength(450)]
        public string Path { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        [StringLength(450)]
        public string PhysicalPath { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
