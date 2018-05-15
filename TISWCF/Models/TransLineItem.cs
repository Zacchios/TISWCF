namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TransLineItem
    {
        public int TransLineItemID { get; set; }

        public int TransactionID { get; set; }

        public int LineItemTypeID { get; set; }

        public int? ComponentID { get; set; }

        [StringLength(32)]
        public string Project { get; set; }

        [StringLength(16)]
        public string VendorRefNum { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(255)]
        public string Remarks { get; set; }

        [Column(TypeName = "money")]
        public decimal GrossAmount { get; set; }

        public decimal? DiscountPercent { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmount { get; set; }

        public bool Taxable { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
