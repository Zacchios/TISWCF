namespace RESTHosting.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LiegeContext : DbContext
    {
        public LiegeContext()
            : base("name=LiegeContext")
        {
        }

        public virtual DbSet<AccessionMethod> AccessionMethods { get; set; }
        public virtual DbSet<AltNum> AltNums { get; set; }
        public virtual DbSet<ClassificationNotation> ClassificationNotations { get; set; }
        public virtual DbSet<Classification> Classifications { get; set; }
        public virtual DbSet<ClassificationXRef> ClassificationXRefs { get; set; }
        public virtual DbSet<ColThesXrefType> ColThesXrefTypes { get; set; }
        public virtual DbSet<ConAddress> ConAddresses { get; set; }
        public virtual DbSet<Condition> Conditions { get; set; }
        public virtual DbSet<CondLineItem> CondLineItems { get; set; }
        public virtual DbSet<Constituent> Constituents { get; set; }
        public virtual DbSet<ConXrefDetail> ConXrefDetails { get; set; }
        public virtual DbSet<ConXref> ConXrefs { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DimElemTypeXref> DimElemTypeXrefs { get; set; }
        public virtual DbSet<DimensionElement> DimensionElements { get; set; }
        public virtual DbSet<DimensionMethod> DimensionMethods { get; set; }
        public virtual DbSet<Dimension> Dimensions { get; set; }
        public virtual DbSet<DimensionType> DimensionTypes { get; set; }
        public virtual DbSet<DimensionUnit> DimensionUnits { get; set; }
        public virtual DbSet<DimItemElemXref> DimItemElemXrefs { get; set; }
        public virtual DbSet<DimUnitType> DimUnitTypes { get; set; }
        public virtual DbSet<LineItemType> LineItemTypes { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<LocPurpos> LocPurposes { get; set; }
        public virtual DbSet<MediaFile> MediaFiles { get; set; }
        public virtual DbSet<MediaMaster> MediaMasters { get; set; }
        public virtual DbSet<MediaPath> MediaPaths { get; set; }
        public virtual DbSet<MediaRendition> MediaRenditions { get; set; }
        public virtual DbSet<MediaSize> MediaSizes { get; set; }
        public virtual DbSet<MediaType> MediaTypes { get; set; }
        public virtual DbSet<MediaXref> MediaXrefs { get; set; }
        public virtual DbSet<ObjAccession> ObjAccessions { get; set; }
        public virtual DbSet<ObjDeaccession> ObjDeaccessions { get; set; }
        public virtual DbSet<ObjectName> ObjectNames { get; set; }
        public virtual DbSet<Objects> Objects { get; set; }
        public virtual DbSet<ObjectStatus> ObjectStatuses { get; set; }
        public virtual DbSet<ObjInsurance> ObjInsurances { get; set; }
        public virtual DbSet<ObjLocation> ObjLocations { get; set; }
        public virtual DbSet<ObjPrefix> ObjPrefixes { get; set; }
        public virtual DbSet<ObjTitle> ObjTitles { get; set; }
        public virtual DbSet<OverallCondition> OverallConditions { get; set; }
        public virtual DbSet<PackageFolder> PackageFolders { get; set; }
        public virtual DbSet<PackageList> PackageLists { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Relationship> Relationships { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleType> RoleTypes { get; set; }
        public virtual DbSet<StatusFlag> StatusFlags { get; set; }
        public virtual DbSet<StorageFormat> StorageFormats { get; set; }
        public virtual DbSet<StorageMethod> StorageMethods { get; set; }
        public virtual DbSet<SurveyAttrType> SurveyAttrTypes { get; set; }
        public virtual DbSet<SurveyType> SurveyTypes { get; set; }
        public virtual DbSet<TermMasterThe> TermMasterThes { get; set; }
        public virtual DbSet<Term> Terms { get; set; }
        public virtual DbSet<TextType> TextTypes { get; set; }
        public virtual DbSet<ThesXref> ThesXrefs { get; set; }
        public virtual DbSet<ThesXrefType> ThesXrefTypes { get; set; }
        public virtual DbSet<TitleType> TitleTypes { get; set; }
        public virtual DbSet<TransCode> TransCodes { get; set; }
        public virtual DbSet<TransLineItem> TransLineItems { get; set; }
        public virtual DbSet<TransStatu> TransStatus { get; set; }
        public virtual DbSet<TreatmentPriority> TreatmentPriorities { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ValuationPurpos> ValuationPurposes { get; set; }
        public virtual DbSet<ColThesXref> ColThesXrefs { get; set; }
        public virtual DbSet<ObjComponent> ObjComponents { get; set; }
        public virtual DbSet<PackageFolderXref> PackageFolderXrefs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessionMethod>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<AltNum>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<ClassificationNotation>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<Classification>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<ClassificationXRef>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<ColThesXrefType>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<ConAddress>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<Condition>()
                .Property(e => e.DurationDays)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Condition>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Condition>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<CondLineItem>()
                .Property(e => e.DurationDays)
                .HasPrecision(6, 2);

            modelBuilder.Entity<CondLineItem>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<Constituent>()
                .Property(e => e.LastSoundEx)
                .IsFixedLength();

            modelBuilder.Entity<Constituent>()
                .Property(e => e.FirstSoundEx)
                .IsFixedLength();

            modelBuilder.Entity<Constituent>()
                .Property(e => e.InstitutionSoundEx)
                .IsFixedLength();

            modelBuilder.Entity<Constituent>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<ConXrefDetail>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<ConXref>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<Department>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<DimElemTypeXref>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<DimensionElement>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<DimensionMethod>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<Dimension>()
                .Property(e => e.Dimension1)
                .HasPrecision(22, 10);

            modelBuilder.Entity<Dimension>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<DimensionType>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<DimensionUnit>()
                .Property(e => e.ConversionFactor)
                .HasPrecision(26, 14);

            modelBuilder.Entity<DimensionUnit>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<DimItemElemXref>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<DimUnitType>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<LineItemType>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<Location>()
                .Property(e => e.UnitHeightCM)
                .HasPrecision(16, 4);

            modelBuilder.Entity<Location>()
                .Property(e => e.UnitWidthCM)
                .HasPrecision(16, 4);

            modelBuilder.Entity<Location>()
                .Property(e => e.UnitDepthCM)
                .HasPrecision(16, 4);

            modelBuilder.Entity<Location>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<LocPurpos>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<MediaFile>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<MediaMaster>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<MediaPath>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<MediaRendition>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<MediaSize>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<MediaType>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<MediaXref>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<ObjAccession>()
                .Property(e => e.AccessionValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ObjAccession>()
                .Property(e => e.CurrencyAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ObjAccession>()
                .Property(e => e.CurrencyRate)
                .HasPrecision(12, 4);

            modelBuilder.Entity<ObjAccession>()
                .Property(e => e.LocalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ObjAccession>()
                .Property(e => e.Budget)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ObjAccession>()
                .Property(e => e.CurrPercentOwnership)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ObjAccession>()
                .Property(e => e.SuggestedAccValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ObjAccession>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<ObjDeaccession>()
                .Property(e => e.EstimateHigh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ObjDeaccession>()
                .Property(e => e.EstimateLow)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ObjDeaccession>()
                .Property(e => e.NetSaleAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ObjDeaccession>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<ObjectName>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<Objects>()
                .Property(e => e.SortNumber)
                .IsFixedLength();

            modelBuilder.Entity<Objects>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<ObjectStatus>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<ObjInsurance>()
                .Property(e => e.Value)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ObjInsurance>()
                .Property(e => e.FrameMountPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ObjInsurance>()
                .Property(e => e.DealerPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ObjInsurance>()
                .Property(e => e.DealerPercent)
                .HasPrecision(4, 2);

            modelBuilder.Entity<ObjInsurance>()
                .Property(e => e.CurrencyRate2)
                .HasPrecision(38, 19);

            modelBuilder.Entity<ObjInsurance>()
                .Property(e => e.CurrencyValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ObjInsurance>()
                .Property(e => e.FrameCurrencyPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ObjInsurance>()
                .Property(e => e.AdjustedValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ObjInsurance>()
                .Property(e => e.RiskFactor)
                .HasPrecision(14, 6);

            modelBuilder.Entity<ObjInsurance>()
                .Property(e => e.RoundedValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ObjInsurance>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<ObjLocation>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<ObjPrefix>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<ObjTitle>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<OverallCondition>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<PackageFolder>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<PackageList>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<Package>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<Relationship>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<Role>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<RoleType>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<StatusFlag>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<StorageFormat>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<StorageMethod>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<SurveyAttrType>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<SurveyType>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<TermMasterThe>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<Term>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<TextType>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<ThesXref>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<ThesXrefType>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<TitleType>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<TransCode>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<TransLineItem>()
                .Property(e => e.GrossAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TransLineItem>()
                .Property(e => e.DiscountPercent)
                .HasPrecision(4, 2);

            modelBuilder.Entity<TransLineItem>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TransLineItem>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<TransStatu>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<TreatmentPriority>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<ValuationPurpos>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<ColThesXref>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<ObjComponent>()
                .Property(e => e.SortNumber)
                .IsFixedLength();

            modelBuilder.Entity<ObjComponent>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<PackageFolderXref>()
                .Property(e => e.GSRowVersion)
                .IsFixedLength();
        }
    }
}
