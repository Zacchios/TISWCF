namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Term
    {
        public int TermID { get; set; }

        public int TermMasterID { get; set; }

        public int TermTypeID { get; set; }

        [Column("Term")]
        [Required]
        [StringLength(255)]
        public string Term1 { get; set; }

        public int LanguageID { get; set; }

        public bool CandidateTerm { get; set; }

        public bool LocalTerm { get; set; }

        public DateTime EnteredDate { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public byte DisplayOrder { get; set; }

        public bool Approved { get; set; }

        [StringLength(255)]
        public string Modifier { get; set; }

        [StringLength(255)]
        public string Qualifier { get; set; }

        public bool? Vernacular { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }

        public bool SystemGenerated { get; set; }

        [StringLength(450)]
        public string SourceTermID { get; set; }
    }
}
