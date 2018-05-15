namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ColThesXrefType
    {
        public int ColThesXrefTypeID { get; set; }

        public int ColumnID { get; set; }

        [Column("ColThesXrefType")]
        [Required]
        [StringLength(64)]
        public string ColThesXrefType1 { get; set; }

        public int TermMasterID { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public bool DefaultRoot { get; set; }

        public bool TermSearchRoot { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
