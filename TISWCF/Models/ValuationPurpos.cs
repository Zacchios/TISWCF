namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ValuationPurposes")]
    public partial class ValuationPurpos
    {
        [Key]
        public int ValuationPurposeID { get; set; }

        [Required]
        [StringLength(60)]
        public string ValuationPurpose { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginId { get; set; }

        public DateTime EnteredDate { get; set; }

        public byte? System { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
