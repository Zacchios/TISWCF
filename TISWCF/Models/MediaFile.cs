namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MediaFile
    {
        [Key]
        public int FileID { get; set; }

        public int RenditionID { get; set; }

        public int PathID { get; set; }

        [StringLength(450)]
        public string FileName { get; set; }

        public int FormatID { get; set; }

        public int PixelH { get; set; }

        public int PixelW { get; set; }

        public int ColorDepthID { get; set; }

        public int Duration { get; set; }

        public int FileSize { get; set; }

        public int MemorySize { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public DateTime? FileDate { get; set; }

        public int? ArchTypeID { get; set; }

        [StringLength(32)]
        public string ArchIDNum { get; set; }

        [StringLength(32)]
        public string ArchCatNum { get; set; }

        [StringLength(32)]
        public string ArchVolName { get; set; }

        [StringLength(64)]
        public string ArchSubDir { get; set; }

        [StringLength(64)]
        public string ArchFilename { get; set; }

        public int SemanticTypeID { get; set; }

        [StringLength(256)]
        public string Checksum { get; set; }

        public bool LockChecksum { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }

        public bool IsConfidential { get; set; }

        public bool RequireTiling { get; set; }
    }
}
