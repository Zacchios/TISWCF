namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ThesXrefType
    {
        public int ThesXrefTypeID { get; set; }

        [Column("ThesXrefType")]
        [Required]
        [StringLength(64)]
        public string ThesXrefType1 { get; set; }

        public int TableID { get; set; }

        public int ThesXrefTableID { get; set; }

        public bool MultiSelect { get; set; }

        public bool ArchiveDeletes { get; set; }

        public int? TermMasterID { get; set; }

        public bool ShowGuideTerms { get; set; }

        public bool BroadestTermFirst { get; set; }

        public short NumLevels { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }

        public int? PrimaryCNID { get; set; }

        public bool AlwaysDisplayFullPath { get; set; }
    }
}
