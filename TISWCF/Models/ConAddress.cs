namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConAddress")]
    public partial class ConAddress
    {
        public int ConAddressID { get; set; }

        public int ConstituentID { get; set; }

        [StringLength(64)]
        public string StreetLine1 { get; set; }

        [StringLength(64)]
        public string StreetLine2 { get; set; }

        [StringLength(64)]
        public string StreetLine3 { get; set; }

        [StringLength(64)]
        public string City { get; set; }

        [StringLength(32)]
        public string State { get; set; }

        [StringLength(16)]
        public string ZipCode { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public short? Active { get; set; }

        public int? AddressTypeID { get; set; }

        public byte? DefaultShipping { get; set; }

        public byte? DefaultBilling { get; set; }

        public byte? DefaultMailing { get; set; }

        [StringLength(128)]
        public string DisplayName1 { get; set; }

        [StringLength(128)]
        public string DisplayName2 { get; set; }

        [StringLength(24)]
        public string BeginDate { get; set; }

        [StringLength(24)]
        public string EndDate { get; set; }

        public byte? Rank { get; set; }

        [StringLength(255)]
        public string Remarks { get; set; }

        public int? LastSalesTaxID { get; set; }

        public int? CountryID { get; set; }

        public int? AddressFormatID { get; set; }

        [StringLength(800)]
        public string DisplayAddress { get; set; }

        public bool? IsLocation { get; set; }

        [StringLength(64)]
        public string ShortName { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
