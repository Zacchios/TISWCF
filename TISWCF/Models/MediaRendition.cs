namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MediaRendition
    {
        [Key]
        public int RenditionID { get; set; }

        public int MediaMasterID { get; set; }

        public int? PrimaryFileID { get; set; }

        public int? ParentRendID { get; set; }

        public int MediaTypeID { get; set; }

        public int? MediaStatusID { get; set; }

        [StringLength(19)]
        public string MediaStatusDate { get; set; }

        [StringLength(64)]
        public string RenditionNumber { get; set; }

        [StringLength(80)]
        public string SortNumber { get; set; }

        [StringLength(19)]
        public string RenditionDate { get; set; }

        public int MediaSizeID { get; set; }

        [StringLength(255)]
        public string Technique { get; set; }

        public int? Duration { get; set; }

        public byte IsColor { get; set; }

        [StringLength(255)]
        public string Quality { get; set; }

        [StringLength(19)]
        public string QualityDate { get; set; }

        public int? QualityConID { get; set; }

        public string Remarks { get; set; }

        [Column(TypeName = "image")]
        public byte[] ThumbBLOB { get; set; }

        public int? ThumbPathID { get; set; }

        [StringLength(450)]
        public string ThumbFileName { get; set; }

        public int? ThumbExtensionID { get; set; }

        public int? ThumbBlobSize { get; set; }

        public int? LocTermID { get; set; }

        public int? QuantityMade { get; set; }

        public int? QuantityAvailable { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }

        public int? PhotographerConxrefID { get; set; }
    }
}
