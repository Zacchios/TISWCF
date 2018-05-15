namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TermMasterThe
    {
        [Key]
        public int TermMasterID { get; set; }

        public DateTime DateEntered { get; set; }

        public DateTime DateModified { get; set; }

        public int TermClassID { get; set; }

        public string Description { get; set; }

        public byte GuideTerm { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public bool? MultiParent { get; set; }

        public int PrimaryCNID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }

        [StringLength(256)]
        public string TermSource { get; set; }

        public int? displayDescriptorId { get; set; }

        public int PreferredTermId { get; set; }

        [StringLength(450)]
        public string SourceTermID { get; set; }
    }
}
