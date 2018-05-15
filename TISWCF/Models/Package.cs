namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Package
    {
        public int PackageID { get; set; }

        [Required]
        [StringLength(259)]
        public string Name { get; set; }

        public string Notes { get; set; }

        [Required]
        [StringLength(32)]
        public string Owner { get; set; }

        public short PackageType { get; set; }

        public short Global { get; set; }

        public short Locked { get; set; }

        [StringLength(64)]
        public string BitmapName { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public int? DisplayRecID { get; set; }

        public int TableID { get; set; }

        public DateTime ModifiedDate { get; set; }

        [Required]
        [StringLength(32)]
        public string ModifiedLoginID { get; set; }

        public DateTime LastUsedDate { get; set; }

        [Required]
        [StringLength(32)]
        public string LastUsedLoginID { get; set; }

        public int PackagePurposeID { get; set; }

        public int ItemCount { get; set; }

        public int? TemplateRecID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
