namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Department
    {
        public int DepartmentID { get; set; }

        [Column("Department")]
        [Required]
        [StringLength(64)]
        public string Department1 { get; set; }

        [Required]
        [StringLength(16)]
        public string Mnemonic { get; set; }

        public int InputID { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public int? NumRandomObjs { get; set; }

        public int? DefaultFormID { get; set; }

        public int MainTableID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
