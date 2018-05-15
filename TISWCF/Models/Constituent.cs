namespace RESTHosting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Constituent
    {
        public int ConstituentID { get; set; }

        public int ConstituentTypeID { get; set; }

        public short Active { get; set; }

        [StringLength(450)]
        public string AlphaSort { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(48)]
        public string NameTitle { get; set; }

        [StringLength(128)]
        public string Institution { get; set; }

        [StringLength(4)]
        public string LastSoundEx { get; set; }

        [StringLength(4)]
        public string FirstSoundEx { get; set; }

        [StringLength(4)]
        public string InstitutionSoundEx { get; set; }

        [StringLength(450)]
        public string DisplayName { get; set; }

        public int BeginDate { get; set; }

        public int EndDate { get; set; }

        [StringLength(128)]
        public string DisplayDate { get; set; }

        public string Biography { get; set; }

        [StringLength(32)]
        public string Code { get; set; }

        [StringLength(64)]
        public string Nationality { get; set; }

        [StringLength(64)]
        public string School { get; set; }

        [Required]
        [StringLength(32)]
        public string LoginID { get; set; }

        public DateTime EnteredDate { get; set; }

        public string Remarks { get; set; }

        [StringLength(128)]
        public string Position { get; set; }

        [StringLength(30)]
        public string MiddleName { get; set; }

        [StringLength(100)]
        public string Suffix { get; set; }

        [StringLength(64)]
        public string CultureGroup { get; set; }

        public string N_DisplayName { get; set; }

        public string N_DisplayDate { get; set; }

        [StringLength(128)]
        public string salutation { get; set; }

        public bool Approved { get; set; }

        public bool PublicAccess { get; set; }

        public bool IsPrivate { get; set; }

        public int DefaultNameID { get; set; }

        public int? SystemFlag { get; set; }

        public byte InternalStatus { get; set; }

        public int DefaultDisplayBioID { get; set; }

        [StringLength(19)]
        public string BeginDateISO { get; set; }

        [StringLength(19)]
        public string EndDateISO { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] GSRowVersion { get; set; }

        public bool IsLocked { get; set; }

        public bool IsStaff { get; set; }
    }
}
