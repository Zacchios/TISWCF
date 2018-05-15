namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PackageFolderXref
    {
        [Key]
        [Column(Order = 0)]
        public int PackageFolderXrefID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FolderID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PackageID { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool ShortCut { get; set; }

        public int? RBHistoryFolderID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(32)]
        public string LoginID { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime EnteredDate { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
