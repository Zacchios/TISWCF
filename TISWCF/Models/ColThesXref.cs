namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ColThesXref
    {
        [Key]
        [Column(Order = 0)]
        public int ColThesXrefID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ColThesXrefTypeID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ColumnID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TableID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TermID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ColThesXrefTableID { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short DisplayOrder { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool Include { get; set; }

        [StringLength(999)]
        public string DisplayText { get; set; }

        public int? TermConnectorID { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime EnteredDate { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(32)]
        public string LoginID { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime ModifiedDate { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(255)]
        public string ModifiedBy { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }
    }
}
