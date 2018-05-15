namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MediaMaster")]
    public partial class MediaMaster
    {
        public int MediaMasterID { get; set; }

        public int DisplayRendID { get; set; }

        public int PrimaryRendID { get; set; }

        [StringLength(64)]
        public string MediaView { get; set; }

        public string Description { get; set; }

        public short? PublicAccess { get; set; }

        public string PublicCaption { get; set; }

        public string Remarks { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public string Copyright { get; set; }

        public string Restrictions { get; set; }

        [StringLength(19)]
        public string AgreementSignedDate { get; set; }

        public bool ApprovedForWeb { get; set; }

        public int? DepartmentID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }

        public int ConservationEntityID { get; set; }

        public int? AnnotationID { get; set; }
    }
}
