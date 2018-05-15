namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ObjLocation
    {
        public int ObjLocationID { get; set; }

        public int ComponentID { get; set; }

        public int LocationID { get; set; }

        public short? LocLevel { get; set; }

        [StringLength(32)]
        public string SearchContainer { get; set; }

        public int? TransCodeID { get; set; }

        public DateTime? TransDate { get; set; }

        public int? TransStatusID { get; set; }

        [StringLength(32)]
        public string Handler { get; set; }

        public int? LocPurposeID { get; set; }

        public short TempFlag { get; set; }

        [StringLength(255)]
        public string TempText { get; set; }

        public DateTime? TempTicklerDate { get; set; }

        [StringLength(120)]
        public string RequestedBy { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        [StringLength(32)]
        public string Approver { get; set; }

        public DateTime? DateOut { get; set; }

        public int? PrevObjLocID { get; set; }

        public int? NextObjLocID { get; set; }

        public int? SchedObjLocID { get; set; }

        public int? ShipmentID { get; set; }

        [StringLength(19)]
        public string AnticipEndDate { get; set; }

        public bool Inactive { get; set; }

        public int? CrateID { get; set; }

        [StringLength(64)]
        public string Sublevel { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
