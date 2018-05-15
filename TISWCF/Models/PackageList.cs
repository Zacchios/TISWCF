namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PackageList")]
    public partial class PackageList
    {
        public int PackageListID { get; set; }

        public int PackageID { get; set; }

        public int ID { get; set; }

        [StringLength(255)]
        public string MainData { get; set; }

        public int OrderPos { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public string Notes { get; set; }

        public int TableID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
