namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MediaXref
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MediaXrefID { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MediaMasterID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TableID { get; set; }

        public int Rank { get; set; }

        public short PrimaryDisplay { get; set; }

        [StringLength(255)]
        public string Remarks { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }

        public int DisplayOrder { get; set; }

        public bool DisplayInReport { get; set; }

        [StringLength(128)]
        public string Relation { get; set; }
    }
}
