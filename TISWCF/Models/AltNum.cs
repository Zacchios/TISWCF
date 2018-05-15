namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AltNum
    {
        public int AltNumID { get; set; }

        public int ID { get; set; }

        public int TableID { get; set; }

        [Column("AltNum")]
        [StringLength(450)]
        public string AltNum1 { get; set; }

        [StringLength(80)]
        public string Description { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        [StringLength(255)]
        public string Remarks { get; set; }

        [StringLength(19)]
        public string BeginISODate { get; set; }

        [StringLength(19)]
        public string EndISODate { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
