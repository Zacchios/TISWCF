namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ObjAccession")]
    public partial class ObjAccession
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ObjectID { get; set; }

        [StringLength(64)]
        public string AcquisitionLot { get; set; }

        [StringLength(24)]
        public string AcquisitionNumber { get; set; }

        public int AccessionMethodID { get; set; }

        [Column(TypeName = "money")]
        public decimal AccessionValue { get; set; }

        [Column(TypeName = "money")]
        public decimal CurrencyAmount { get; set; }

        public int CurrencyID { get; set; }

        public decimal CurrencyRate { get; set; }

        [Column(TypeName = "money")]
        public decimal LocalAmount { get; set; }

        [StringLength(128)]
        public string Initiator { get; set; }

        public DateTime? InitDate { get; set; }

        [StringLength(128)]
        public string Authorizer { get; set; }

        public DateTime? AuthDate { get; set; }

        public DateTime? AccessionMinutes1 { get; set; }

        public DateTime? AccessionMinutes2 { get; set; }

        public string AcqJustification { get; set; }

        public string AcquisitionTerms { get; set; }

        public string ValuationNotes { get; set; }

        public string Source { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Budget { get; set; }

        public int? OriginalEntityID { get; set; }

        public int? CurrentEntityID { get; set; }

        [StringLength(48)]
        public string CapitalProgram { get; set; }

        [StringLength(19)]
        public string ApprovalISODate1 { get; set; }

        [StringLength(19)]
        public string ApprovalISODate2 { get; set; }

        [StringLength(19)]
        public string AccessionISODate { get; set; }

        [StringLength(19)]
        public string DeedOfGiftSentISO { get; set; }

        [StringLength(19)]
        public string DeedOfGiftReceivedISO { get; set; }

        public decimal? CurrPercentOwnership { get; set; }

        public int? AcquisitionLotID { get; set; }

        public int? RegistrationSetID { get; set; }

        [StringLength(64)]
        public string LotObjectNumber { get; set; }

        public string Remarks { get; set; }

        [Column(TypeName = "money")]
        public decimal? SuggestedAccValue { get; set; }

        public int? ObjectValueID { get; set; }

        [StringLength(19)]
        public string SuggestedValueISODate { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
