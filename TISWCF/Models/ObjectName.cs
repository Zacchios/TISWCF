namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ObjectName
    {
        public int ObjectNameID { get; set; }

        public int ObjectID { get; set; }

        public int ObjectNameTypeID { get; set; }

        [Column("ObjectName")]
        [Required]
        [StringLength(80)]
        public string ObjectName1 { get; set; }

        [StringLength(255)]
        public string Remarks { get; set; }

        public byte Active { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public short DisplayOrder { get; set; }

        public int? LanguageID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
