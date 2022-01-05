using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ef_core.Models
{
    public partial class AlibayoContext : DbContext
    {
        public AlibayoContext()
        {
        }

        public AlibayoContext(DbContextOptions<AlibayoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoryContext> CategoryContexts { get; set; }
        public virtual DbSet<ContextMappedBusiness> ContextMappedBusinesses { get; set; }
        public virtual DbSet<TblAddress> TblAddresses { get; set; }
        public virtual DbSet<TblBusiness> TblBusinesses { get; set; }
        public virtual DbSet<TblCarBusiness> TblCarBusinesses { get; set; }
        public virtual DbSet<TblCategory> TblCategories { get; set; }
        public virtual DbSet<TblCity> TblCities { get; set; }
        public virtual DbSet<TblCountry> TblCountries { get; set; }
        public virtual DbSet<TblPropertyBusiness> TblPropertyBusinesses { get; set; }
        public virtual DbSet<TblState> TblStates { get; set; }
        public virtual DbSet<VwGetBusiness> VwGetBusinesses { get; set; }
        public virtual DbSet<VwGetCarBusiness> VwGetCarBusinesses { get; set; }
        public virtual DbSet<VwGetPropertyBusiness> VwGetPropertyBusinesses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CategoryContext>(entity =>
            {
                entity.ToTable("CategoryContext");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContextKey)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("context_key");

                entity.Property(e => e.ContextType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("context_type");
            });

            modelBuilder.Entity<ContextMappedBusiness>(entity =>
            {
                entity.ToTable("ContextMappedBusiness");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddedBy).HasColumnName("added_by");

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("added_date");

                entity.Property(e => e.BusinessId).HasColumnName("business_id");

                entity.Property(e => e.ContextId).HasColumnName("context_id");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_date");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.ContextMappedBusinesses)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK__ContextMa__busin__619B8048");

                entity.HasOne(d => d.Context)
                    .WithMany(p => p.ContextMappedBusinesses)
                    .HasForeignKey(d => d.ContextId)
                    .HasConstraintName("FK__ContextMa__conte__60A75C0F");
            });

            modelBuilder.Entity<TblAddress>(entity =>
            {
                entity.HasKey(e => e.AdId)
                    .HasName("PK__tbl_Addr__CAA4A627440F05DB");

                entity.ToTable("tbl_Address");

                entity.Property(e => e.AdId).HasColumnName("ad_id");

                entity.Property(e => e.AdCity).HasColumnName("ad_city");

                entity.Property(e => e.AdEmail)
                    .HasMaxLength(50)
                    .HasColumnName("ad_email");

                entity.Property(e => e.AdPhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ad_phone");

                entity.Property(e => e.AdPhone2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ad_phone2");

                entity.Property(e => e.AdText)
                    .HasMaxLength(50)
                    .HasColumnName("ad_text");

                entity.Property(e => e.AdZipcode)
                    .HasMaxLength(50)
                    .HasColumnName("ad_zipcode");
            });

            modelBuilder.Entity<TblBusiness>(entity =>
            {
                entity.HasKey(e => e.BId)
                    .HasName("PK__tbl_Busi__4E29C30DDC418E48");

                entity.ToTable("tbl_Business");

                entity.Property(e => e.BId).HasColumnName("b_id");

                entity.Property(e => e.BAddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("b_AddedDate");

                entity.Property(e => e.BAddressId).HasColumnName("b_Address_id");

                entity.Property(e => e.BCatId).HasColumnName("b_cat_id");

                entity.Property(e => e.BImage)
                    .HasMaxLength(50)
                    .HasColumnName("b_image");

                entity.Property(e => e.BLongdesc)
                    .HasMaxLength(500)
                    .HasColumnName("b_longdesc");

                entity.Property(e => e.BMaxExperience)
                    .HasMaxLength(50)
                    .HasColumnName("b_maxExperience");

                entity.Property(e => e.BMaxSalary)
                    .HasMaxLength(50)
                    .HasColumnName("b_maxSalary");

                entity.Property(e => e.BMinExperience)
                    .HasMaxLength(50)
                    .HasColumnName("b_minExperience");

                entity.Property(e => e.BMinSalary)
                    .HasMaxLength(50)
                    .HasColumnName("b_minSalary");

                entity.Property(e => e.BModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("b_ModifiedDate");

                entity.Property(e => e.BName)
                    .HasMaxLength(100)
                    .HasColumnName("b_name");

                entity.Property(e => e.BShortdesc)
                    .HasMaxLength(500)
                    .HasColumnName("b_shortdesc");

                entity.Property(e => e.BStatus).HasColumnName("b_Status");

                entity.Property(e => e.BSubCategory).HasColumnName("b_SubCategory");

                entity.Property(e => e.BText)
                    .HasMaxLength(50)
                    .HasColumnName("b_text");
            });

            modelBuilder.Entity<TblCarBusiness>(entity =>
            {
                entity.HasKey(e => e.CarId);

                entity.ToTable("tbl_CarBusiness");

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.Property(e => e.CarAddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("car_AddedDate");

                entity.Property(e => e.CarAddressId).HasColumnName("car_Address_id");

                entity.Property(e => e.CarCatId).HasColumnName("car_cat_id");

                entity.Property(e => e.CarImage)
                    .HasMaxLength(50)
                    .HasColumnName("car_image");

                entity.Property(e => e.CarLongdesc)
                    .HasMaxLength(500)
                    .HasColumnName("car_longdesc");

                entity.Property(e => e.CarModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("car_ModifiedDate");

                entity.Property(e => e.CarPrice)
                    .HasMaxLength(50)
                    .HasColumnName("car_price");

                entity.Property(e => e.CarShortdesc)
                    .HasMaxLength(500)
                    .HasColumnName("car_shortdesc");

                entity.Property(e => e.CarSubCategory).HasColumnName("car_SubCategory");

                entity.Property(e => e.CarText)
                    .HasMaxLength(50)
                    .HasColumnName("car_text");

                entity.HasOne(d => d.CarAddress)
                    .WithMany(p => p.TblCarBusinesses)
                    .HasForeignKey(d => d.CarAddressId)
                    .HasConstraintName("FK_tbl_CarBusiness_tbl_Address");

                entity.HasOne(d => d.CarCat)
                    .WithMany(p => p.TblCarBusinesses)
                    .HasForeignKey(d => d.CarCatId)
                    .HasConstraintName("FK_tbl_CarBusiness_tbl_category");
            });

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PK__tbl_cate__DD5DDDBD22B0FB51");

                entity.ToTable("tbl_category");

                entity.HasIndex(e => e.CatName, "UQ__tbl_cate__FA8C1790483ECA69")
                    .IsUnique();

                entity.HasIndex(e => e.CatName, "UQ__tbl_cate__FA8C179067508325")
                    .IsUnique();

                entity.Property(e => e.CatId).HasColumnName("cat_id");

                entity.Property(e => e.CatAddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cat_addedDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CatFilter)
                    .HasMaxLength(500)
                    .HasColumnName("cat_Filter");

                entity.Property(e => e.CatIcon)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("cat_Icon");

                entity.Property(e => e.CatMasterCategory).HasColumnName("cat_MasterCategory");

                entity.Property(e => e.CatName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("cat_name");

                entity.Property(e => e.CatUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cat_UpdateDate");
            });

            modelBuilder.Entity<TblCity>(entity =>
            {
                entity.HasKey(e => e.CitiesId)
                    .HasName("PK__tbl_Citi__966E69632F008D6C");

                entity.ToTable("tbl_Cities");

                entity.HasIndex(e => e.CitiesName, "UQ__tbl_Citi__B235783333EB7BAD")
                    .IsUnique();

                entity.Property(e => e.CitiesId).HasColumnName("Cities_id");

                entity.Property(e => e.CitiesCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Cities_code");

                entity.Property(e => e.CitiesName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Cities_name");

                entity.Property(e => e.CitiesStateId).HasColumnName("Cities_state_id");

                entity.HasOne(d => d.CitiesState)
                    .WithMany(p => p.TblCities)
                    .HasForeignKey(d => d.CitiesStateId)
                    .HasConstraintName("FK__tbl_Citie__Citie__4F7CD00D");
            });

            modelBuilder.Entity<TblCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK__tbl_coun__7E8CD055C0C99945");

                entity.ToTable("tbl_country");

                entity.HasIndex(e => e.CountryName, "UQ__tbl_coun__F7018894F42B929A")
                    .IsUnique();

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("country_code");

                entity.Property(e => e.CountryFlag)
                    .HasMaxLength(50)
                    .HasColumnName("country_flag");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("country_name");
            });

            modelBuilder.Entity<TblPropertyBusiness>(entity =>
            {
                entity.HasKey(e => e.PId);

                entity.ToTable("tbl_PropertyBusiness");

                entity.Property(e => e.PId).HasColumnName("P_id");

                entity.Property(e => e.PAddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("p_AddedDate");

                entity.Property(e => e.PAddressId).HasColumnName("p_Address_id");

                entity.Property(e => e.PCatId).HasColumnName("p_cat_id");

                entity.Property(e => e.PImage)
                    .HasMaxLength(50)
                    .HasColumnName("p_image");

                entity.Property(e => e.PLongdesc)
                    .HasMaxLength(500)
                    .HasColumnName("p_longdesc");

                entity.Property(e => e.PModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("p_ModifiedDate");

                entity.Property(e => e.PPrice)
                    .HasMaxLength(50)
                    .HasColumnName("p_price");

                entity.Property(e => e.PShortdesc)
                    .HasMaxLength(500)
                    .HasColumnName("p_shortdesc");

                entity.Property(e => e.PSubCategory).HasColumnName("p_SubCategory");

                entity.Property(e => e.PText)
                    .HasMaxLength(50)
                    .HasColumnName("p_text");

                entity.HasOne(d => d.PAddress)
                    .WithMany(p => p.TblPropertyBusinesses)
                    .HasForeignKey(d => d.PAddressId)
                    .HasConstraintName("FK_tbl_PropertyBusiness_tbl_Address");

                entity.HasOne(d => d.PCat)
                    .WithMany(p => p.TblPropertyBusinesses)
                    .HasForeignKey(d => d.PCatId)
                    .HasConstraintName("FK_tbl_PropertyBusiness_tbl_category");
            });

            modelBuilder.Entity<TblState>(entity =>
            {
                entity.HasKey(e => e.StateId)
                    .HasName("PK__tbl_Stat__81A4741761FEE728");

                entity.ToTable("tbl_States");

                entity.HasIndex(e => e.StateName, "UQ__tbl_Stat__8D2CE19AE8F1082D")
                    .IsUnique();

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("state_code");

                entity.Property(e => e.StateCountryId).HasColumnName("state_country_id");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("state_name");

                entity.HasOne(d => d.StateCountry)
                    .WithMany(p => p.TblStates)
                    .HasForeignKey(d => d.StateCountryId)
                    .HasConstraintName("FK__tbl_State__state__52593CB8");
            });

            modelBuilder.Entity<VwGetBusiness>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_GetBusiness");

                entity.Property(e => e.BAddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("b_AddedDate");

                entity.Property(e => e.BModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("b_ModifiedDate");

                entity.Property(e => e.BusinessImage).HasMaxLength(50);

                entity.Property(e => e.BusinessName).HasMaxLength(100);

                entity.Property(e => e.BusinessTitle).HasMaxLength(50);

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CategoryIcon)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Filters).HasMaxLength(500);

                entity.Property(e => e.FullAddress).HasMaxLength(50);

                entity.Property(e => e.MaxExperience).HasMaxLength(50);

                entity.Property(e => e.MaxSalary).HasMaxLength(50);

                entity.Property(e => e.MinExperince).HasMaxLength(50);

                entity.Property(e => e.MinSalary).HasMaxLength(50);

                entity.Property(e => e.Phone1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Phone-1");

                entity.Property(e => e.Phone2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Phone-2");

                entity.Property(e => e.ShortDesc).HasMaxLength(500);

                entity.Property(e => e.ZipCode).HasMaxLength(50);
            });

            modelBuilder.Entity<VwGetCarBusiness>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_GetCarBusiness");

                entity.Property(e => e.BusinessImage).HasMaxLength(50);

                entity.Property(e => e.CarAddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("car_AddedDate");

                entity.Property(e => e.CarModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("car_ModifiedDate");

                entity.Property(e => e.CarPrice).HasMaxLength(50);

                entity.Property(e => e.CarTitle).HasMaxLength(50);

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CategoryIcon)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Filters).HasMaxLength(500);

                entity.Property(e => e.FullAddress).HasMaxLength(50);

                entity.Property(e => e.Phone1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Phone-1");

                entity.Property(e => e.Phone2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Phone-2");

                entity.Property(e => e.ShortDesc).HasMaxLength(500);

                entity.Property(e => e.ZipCode).HasMaxLength(50);
            });

            modelBuilder.Entity<VwGetPropertyBusiness>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_GetPropertyBusiness");

                entity.Property(e => e.BusinessImage).HasMaxLength(50);

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CategoryIcon)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Filters).HasMaxLength(500);

                entity.Property(e => e.FullAddress).HasMaxLength(50);

                entity.Property(e => e.PAddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("p_AddedDate");

                entity.Property(e => e.PModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("p_ModifiedDate");

                entity.Property(e => e.Phone1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Phone-1");

                entity.Property(e => e.Phone2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Phone-2");

                entity.Property(e => e.PropertyPrice).HasMaxLength(50);

                entity.Property(e => e.PropertyTitle).HasMaxLength(50);

                entity.Property(e => e.ShortDesc).HasMaxLength(500);

                entity.Property(e => e.ZipCode).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
