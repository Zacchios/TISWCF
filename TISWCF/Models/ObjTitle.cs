namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ObjTitle
    {
        [Key]
        public int TitleID { get; set; }

        public int ObjectID { get; set; }

        public int TitleTypeID { get; set; }

        [Required]
        [StringLength(850)]
        public string Title { get; set; }

        public string Remarks { get; set; }

        public short Active { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public short? DisplayOrder { get; set; }

        public byte? Displayed { get; set; }

        public int? LanguageID { get; set; }

        [StringLength(19)]
        public string DateEffectiveISODate { get; set; }

        public bool IsExhTitle { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
