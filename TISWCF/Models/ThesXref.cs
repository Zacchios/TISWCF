namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ThesXref
    {
        public int ThesXrefID { get; set; }

        public int ThesXrefTypeID { get; set; }

        public int ID { get; set; }

        public int TableID { get; set; }

        public int TermID { get; set; }

        public int ThesXrefTableID { get; set; }

        public int? DisplayOrder { get; set; }

        [StringLength(255)]
        public string Remarks { get; set; }

        public bool Active { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        [StringLength(32)]
        public string RemovedLoginID { get; set; }

        public DateTime? RemovedDate { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }

        public int? PrimaryCNID { get; set; }
    }
}
