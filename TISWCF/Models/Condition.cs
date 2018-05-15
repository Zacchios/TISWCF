namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Condition
    {
        public int ConditionID { get; set; }

        public int ID { get; set; }

        public int? ExaminerID { get; set; }

        public DateTime? AnalysisDate { get; set; }

        [Required]
        [StringLength(32)]
        public string SurveyType { get; set; }

        public string OverallAnalysis { get; set; }

        public string Remarks { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public byte? DisplaySurvey { get; set; }

        public int SurveyTypeID { get; set; }

        public int OverallConditionID { get; set; }

        [StringLength(19)]
        public string SurveyISODate { get; set; }

        [StringLength(19)]
        public string ReportISODate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DurationDays { get; set; }

        [StringLength(180)]
        public string Project { get; set; }

        [StringLength(19)]
        public string RequestDate { get; set; }

        [StringLength(19)]
        public string DueDate { get; set; }

        public int TreatmentPriorityID { get; set; }

        [Column(TypeName = "money")]
        public decimal Cost { get; set; }

        public int? Examiner2ID { get; set; }

        public int TableID { get; set; }

        [StringLength(24)]
        public string ConditionNumber { get; set; }

        [StringLength(32)]
        public string SortNumber { get; set; }

        [StringLength(255)]
        public string ShortText01 { get; set; }

        [StringLength(255)]
        public string ShortText02 { get; set; }

        [StringLength(255)]
        public string ShortText03 { get; set; }

        [StringLength(255)]
        public string ShortText04 { get; set; }

        [StringLength(255)]
        public string ShortText05 { get; set; }

        [StringLength(255)]
        public string ShortText06 { get; set; }

        [StringLength(255)]
        public string ShortText07 { get; set; }

        [StringLength(255)]
        public string ShortText08 { get; set; }

        public bool? InvoicePaid { get; set; }

        [StringLength(32)]
        public string ModifiedLoginID { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(32)]
        public string CompletedLoginID { get; set; }

        public DateTime? CompletedDate { get; set; }

        public bool? Completed { get; set; }

        public bool LockedForEdit { get; set; }

        public int? PackageID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
