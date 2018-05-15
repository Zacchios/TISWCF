namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public int UserID { get; set; }

        [Required]
        [StringLength(32)]
        public string Login { get; set; }

        public int SecurityGroupID { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public DateTime? PWChangedDate { get; set; }

        public bool IsMustChangePW { get; set; }

        public bool IsDisabled { get; set; }

        [StringLength(255)]
        public string DisplayName { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }

        [StringLength(255)]
        public string DomainName { get; set; }

        public int? ConstituentID { get; set; }
    }
}
