namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ObjComponent
    {
        [Key]
        [Column(Order = 0)]
        public int ComponentID { get; set; }

        [StringLength(64)]
        public string ComponentNumber { get; set; }

        [StringLength(80)]
        public string ComponentName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ObjectID { get; set; }

        public int? StorageMethodID { get; set; }

        public int? StorageFormatID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HomeLocationID { get; set; }

        public short? HomeLevel { get; set; }

        [StringLength(32)]
        public string SearchHomeContainer { get; set; }

        public int? CurrentObjLocID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ToBeCombined { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ReadyStorage { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ReadyExhibit { get; set; }

        public string StorageComments { get; set; }

        public string InstallComments { get; set; }

        public string PrepComments { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(32)]
        public string LoginID { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime EnteredDate { get; set; }

        public string PhysDesc { get; set; }

        public byte? ComponentType { get; set; }

        public int? ObjCompStatusID { get; set; }

        public int? CostMethodID { get; set; }

        [StringLength(80)]
        public string SortNumber { get; set; }

        public int? CompCount { get; set; }

        public DateTime? ReceivedDate { get; set; }

        public byte? Inactive { get; set; }

        public int? HomeCrateID { get; set; }

        [StringLength(64)]
        public string HomeSublevel { get; set; }

        public bool? InJurisdiction { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConservationEntityID { get; set; }
    }
}
