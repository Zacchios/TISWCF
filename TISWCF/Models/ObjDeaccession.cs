namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ObjDeaccession")]
    public partial class ObjDeaccession
    {
        [Key]
        public int DeaccessionID { get; set; }

        public int ObjectID { get; set; }

        public int RecipientConID { get; set; }

        [StringLength(16)]
        public string SaleNumber { get; set; }

        [StringLength(16)]
        public string LotNumber { get; set; }

        public int DispositionMethod { get; set; }

        [Column(TypeName = "money")]
        public decimal EstimateHigh { get; set; }

        [Column(TypeName = "money")]
        public decimal EstimateLow { get; set; }

        [Column(TypeName = "money")]
        public decimal NetSaleAmount { get; set; }

        public string Remarks { get; set; }

        public string Terms { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        [StringLength(19)]
        public string SaleISODate { get; set; }

        [StringLength(19)]
        public string ProceedsRcvdISODate { get; set; }

        [StringLength(19)]
        public string ApprovalISODate1 { get; set; }

        [StringLength(19)]
        public string ApprovalISODate2 { get; set; }

        [StringLength(19)]
        public string ApprovalISODate3 { get; set; }

        [StringLength(19)]
        public string ReportISODate { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
