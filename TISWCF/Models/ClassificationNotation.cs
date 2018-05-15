namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClassificationNotation
    {
        public int ClassificationNotationID { get; set; }

        [Required]
        [StringLength(255)]
        public string CN { get; set; }

        public DateTime DateEntered { get; set; }

        public int TermMasterID { get; set; }

        public byte NodeDepth { get; set; }

        public byte Children { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public int? RootLevelTMID { get; set; }

        public int ThesaurusBaseID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }

        public bool Local { get; set; }

        [Required]
        [StringLength(32)]
        public string SortType { get; set; }

        public int Rank { get; set; }
    }
}
