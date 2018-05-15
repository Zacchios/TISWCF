namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Objects
    {
        public Objects() { }
        public Objects(int id,string numeroobj)
        {
            ObjectID = id;
            ObjectNumber = numeroobj;
        }
        [Key]
        public int ObjectID { get; set; }

        [Required]
        [StringLength(64)]
        public string ObjectNumber { get; set; }

        [Required]
        [StringLength(80)]
        public string SortNumber { get; set; }

        public int ObjectCount { get; set; }

        public int DepartmentID { get; set; }

        public int ObjectStatusID { get; set; }

        public int ClassificationID { get; set; }

        public Classification Classification { get; set; }

        public int SubClassID { get; set; }

        public int Type { get; set; }

        public int LoanClassID { get; set; }

        public int DateBegin { get; set; }

        public int DateEnd { get; set; }

        [StringLength(80)]
        public string ObjectName { get; set; }

        [StringLength(255)]
        public string Dated { get; set; }

        [StringLength(450)]
        public string Title { get; set; }

        public string Medium { get; set; }

        public string Dimensions { get; set; }

        public string Signed { get; set; }

        public string Inscribed { get; set; }

        public string Markings { get; set; }

        public string CreditLine { get; set; }

        public string Chat { get; set; }

        public string DimensionRemarks { get; set; }

        public string Description { get; set; }

        public string Exhibitions { get; set; }

        public string Provenance { get; set; }

        public string PubReferences { get; set; }

        public string Notes { get; set; }

        public string CuratorialRemarks { get; set; }

        public string RelatedWorks { get; set; }

        public string Portfolio { get; set; }

        public short PublicAccess { get; set; }

        public short CuratorApproved { get; set; }

        public short OnView { get; set; }

        public int TextSearchID { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public short? Accountability { get; set; }

        [StringLength(450)]
        public string PaperFileRef { get; set; }

        public int? ObjectLevelID { get; set; }

        public int? ObjectTypeID { get; set; }

        public int? ObjectScreenID { get; set; }

        [StringLength(24)]
        public string UserNumber1 { get; set; }

        [StringLength(24)]
        public string UserNumber2 { get; set; }

        [StringLength(255)]
        public string UserNumber3 { get; set; }

        [StringLength(24)]
        public string UserNumber4 { get; set; }

        public int? ObjectNameID { get; set; }

        public int? ObjectNameAltID { get; set; }

        public DateTime? UserDate1 { get; set; }

        public DateTime? UserDate2 { get; set; }

        public DateTime? UserDate3 { get; set; }

        public DateTime? UserDate4 { get; set; }

        [StringLength(128)]
        public string State { get; set; }

        [StringLength(255)]
        public string CatRais { get; set; }

        public string HistAttributions { get; set; }

        public string Bibliography { get; set; }

        [StringLength(32)]
        public string Negative { get; set; }

        [StringLength(16)]
        public string LoanClass { get; set; }

        public string Edition { get; set; }

        [StringLength(32)]
        public string Cataloguer { get; set; }

        [StringLength(32)]
        public string Curator { get; set; }

        [StringLength(255)]
        public string PaperSupport { get; set; }

        public byte? IsVirtual { get; set; }

        [StringLength(19)]
        public string CatalogueISODate { get; set; }

        [StringLength(19)]
        public string CuratorRevISODate { get; set; }

        public byte? IsTemplate { get; set; }

        [StringLength(64)]
        public string ObjectNumber2 { get; set; }

        [StringLength(80)]
        public string SortNumber2 { get; set; }

        [StringLength(512)]
        public string DateRemarks { get; set; }

        [StringLength(19)]
        public string DateEffectiveISODate { get; set; }

        public int? PhysicalParentID { get; set; }

        public bool? InJurisdiction { get; set; }

        [Required]
        [StringLength(64)]
        public string SearchObjectNumber { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }

        [StringLength(80)]
        public string SortSearchNumber { get; set; }

        public int ConservationEntityID { get; set; }
    }
}
