namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PackageFolder
    {
        [Key]
        public int FolderID { get; set; }

        [Required]
        [StringLength(128)]
        public string FolderName { get; set; }

        public int FolderTypeID { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public int? TableID { get; set; }

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
