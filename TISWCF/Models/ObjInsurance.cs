namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ObjInsurance")]
    public partial class ObjInsurance
    {
        public int ObjInsuranceID { get; set; }

        public int ObjectID { get; set; }

        public int? AppraiserID { get; set; }

        [Column(TypeName = "money")]
        public decimal Value { get; set; }

        public int Code { get; set; }

        [StringLength(999)]
        public string ValueNotes { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public int? ValuationPurposeID { get; set; }

        [Column(TypeName = "money")]
        public decimal? FrameMountPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? DealerPrice { get; set; }

        public decimal? DealerPercent { get; set; }

        public int? CurrencyID { get; set; }

        public decimal? CurrencyRate2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CurrencyValue { get; set; }

        [Column(TypeName = "money")]
        public decimal? FrameCurrencyPrice { get; set; }

        [StringLength(19)]
        public string ValueISODate { get; set; }

        [Column(TypeName = "money")]
        public decimal? AdjustedValue { get; set; }

        [StringLength(19)]
        public string CurrencyRateISODate { get; set; }

        public decimal? RiskFactor { get; set; }

        [StringLength(19)]
        public string RiskFactorISODate { get; set; }

        public bool IsArchived { get; set; }

        public bool IsRateLocked { get; set; }

        public bool IsCurrent { get; set; }

        [Column(TypeName = "money")]
        public decimal RoundedValue { get; set; }

        public short? RoundedDecimals { get; set; }

        [StringLength(19)]
        public string RoundedISODate { get; set; }

        public byte SystemValueType { get; set; }

        public int LocalCurrencyID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
