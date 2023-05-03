using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.data
{
    public partial class Context : DbContext
    {
        public Context()
        {

        }
        public Context(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<TplusBranch> TplusBranches { get; set; } = null!;
        public virtual DbSet<TplusCity> TplusCities { get; set; } = null!;
        public virtual DbSet<TplusCustomer> TplusCustomers { get; set; } = null!;
        public virtual DbSet<TplusCustomerreason> TplusCustomerreasons { get; set; } = null!;
        public virtual DbSet<TplusPlan> TplusPlans { get; set; } = null!;
        public virtual DbSet<TplusPlanDetails> TplusPlanDetails { get; set; } = null!;
        public virtual DbSet<TplusProvince> TplusProvinces { get; set; } = null!;
        public virtual DbSet<TplusRequest> TplusRequests { get; set; } = null!;
        public virtual DbSet<TplusRequesthistory> TplusRequesthistories { get; set; } = null!;
        public virtual DbSet<TplusRequeststatus> TplusRequeststatuses { get; set; } = null!;
        public virtual DbSet<TplusSupervision> TplusSupervisions { get; set; } = null!;
        public virtual DbSet<TplusUser> TplusUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("User Id=etf;Password=rvkpdUgxmetR71Yk3dK7;Server=172.16.11.96;Direct=True;Service Name=mrsdb;Persist Security Info=True;License Key=6EmH1NS2Smmdj6qyRovS30D8WGvRd53muawdBC/+JaMTl27uNQlBxHKEprv4Ot4yh6SldDlAjiJwmGhC47npgZW3kYUiArfUEPLD8IzaiPGcksWQHDtzXcOlA81Z6WLoOhyAFP8USFQrBip+P8YnG6E5xUlaeP60jrqInfWzLGU4eBjy3QkJOsfnL1kQxLPscxp0AWwHlff/+pNHFmFuOJj/Ou48JSoQKwxmZXzN3FY0Qyua+rzxuACv10YAozfrGEW0vcYRtuMQDMLJwnJwWg==");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TplusBranch>(entity =>
            {
                entity.ToTable("TPLUS_BRANCH", "ETF");

                entity.HasIndex(e => e.Id, "TPLUS_BRANCH_PK")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasPrecision(20)
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar2")
                    .HasMaxLength(1000)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Branchcode)
                    .HasColumnType("nvarchar2")
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHCODE");

                entity.Property(e => e.Phone)
                    .HasColumnType("varchar2")
                    .HasMaxLength(20)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Provinceid)
                    .HasPrecision(20)
                    .HasColumnName("PROVINCEID");

                entity.Property(e => e.Supervisionid)
                    .HasPrecision(20)
                    .HasColumnName("SUPERVISIONID");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar2")
                    .HasMaxLength(200)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Username)
                    .HasColumnType("nvarchar2")
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.TplusBranches)
                    .HasForeignKey(d => d.Provinceid)
                    .HasConstraintName("TPLUS_BRANCH_FK2");

                entity.HasOne(d => d.Supervision)
                    .WithMany(p => p.TplusBranches)
                    .HasForeignKey(d => d.Supervisionid)
                    .HasConstraintName("TPLUS_BRANCH_FK1");
            });

            modelBuilder.Entity<TplusCity>(entity =>
            {
                entity.ToTable("TPLUS_CITY", "ETF");

                entity.HasIndex(e => e.Id, "TPLUS_CITY_PK")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasPrecision(20)
                    .HasColumnName("ID");

                entity.Property(e => e.Provinceid)
                    .HasPrecision(20)
                    .HasColumnName("PROVINCEID");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar2")
                    .HasMaxLength(200)
                    .HasColumnName("TITLE");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.TplusCities)
                    .HasForeignKey(d => d.Provinceid)
                    .HasConstraintName("TPLUS_CITY_FK1");
            });

            modelBuilder.Entity<TplusCustomer>(entity =>
            {
                entity.ToTable("TPLUS_CUSTOMER", "ETF");

                entity.HasIndex(e => e.Id, "TPLUS_CUSTOMER_PK")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasPrecision(20)
                    .HasColumnName("ID");

                entity.Property(e => e.Ceoname)
                    .HasColumnType("nvarchar2")
                    .HasMaxLength(100)
                    .HasColumnName("CEONAME");

                entity.Property(e => e.Companyname)
                    .HasColumnType("nvarchar2")
                    .HasMaxLength(200)
                    .HasColumnName("COMPANYNAME");

                entity.Property(e => e.Createddate)
                    .HasColumnType("date")
                    .HasColumnName("CREATEDDATE");

                entity.Property(e => e.Customergrade)
                    .HasColumnType("varchar2")
                    .HasMaxLength(20)
                    .HasColumnName("CUSTOMERGRADE");

                entity.Property(e => e.Customertype).HasColumnName("CUSTOMERTYPE");

                entity.Property(e => e.Entrytype).HasColumnName("ENTRYTYPE");

                entity.Property(e => e.Familyname)
                    .HasColumnType("nvarchar2")
                    .HasMaxLength(50)
                    .HasColumnName("FAMILYNAME");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Iscurrent).HasColumnName("ISCURRENT");

                entity.Property(e => e.Mobilenumber)
                    .HasColumnType("varchar2")
                    .HasMaxLength(11)
                    .HasColumnName("MOBILENUMBER");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("date")
                    .HasColumnName("MODIFIEDDATE");

                entity.Property(e => e.Name)
                    .HasColumnType("nvarchar2")
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Nationalcode)
                    .HasColumnType("varchar2")
                    .HasMaxLength(10)
                    .HasColumnName("NATIONALCODE");

                entity.Property(e => e.Nationalid)
                    .HasColumnType("varchar2")
                    .HasMaxLength(20)
                    .HasColumnName("NATIONALID");

                entity.Property(e => e.Registrationnumber)
                    .HasColumnType("varchar2")
                    .HasMaxLength(20)
                    .HasColumnName("REGISTRATIONNUMBER");

                entity.Property(e => e.Statustype)
                    .HasPrecision(20)
                    .HasColumnName("STATUSTYPE");

                entity.Property(e => e.Storename)
                    .HasColumnType("nvarchar2")
                    .HasMaxLength(200)
                    .HasColumnName("STORENAME");

                entity.Property(e => e.PurchaseVolume)
                    .HasColumnType("varchar2")
                    .HasMaxLength(20)
                    .HasColumnName("PURCHASEVOLUME");

                entity.Property(e => e.Validity)
                    .HasColumnType("varchar2")
                    .HasMaxLength(20)
                    .HasColumnName("VALIDITY");

                entity.Property(e => e.TrackingCode)
                   .HasColumnType("varchar2")
                   .HasMaxLength(20)
                   .HasColumnName("TRACKINGCODE");

                entity.Property(e => e.Description)
                    .HasColumnType("nvarchar2")
                    .HasMaxLength(1000)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.ReferenceNationalCode)
                    .HasColumnType("varchar2")
                    .HasMaxLength(10)
                    .HasColumnName("REFERENCENATIONALCODE");

                entity.Property(e => e.Userid)
                    .HasPrecision(20)
                    .HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TplusCustomers)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("TPLUS_CUSTOMER_FK1");
            });

            modelBuilder.Entity<TplusCustomerreason>(entity =>
            {
                entity.ToTable("TPLUS_CUSTOMERREASON", "ETF");

                entity.HasIndex(e => e.Id, "TPLUS_CUSTOMERREASON_PK")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasPrecision(20)
                    .HasColumnName("ID");

                entity.Property(e => e.Customerid)
                    .HasPrecision(20)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Reasonid).HasColumnName("REASONID");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100)
                    .HasColumnName("TITLE");

                entity.HasOne(d => d.Customer)
                     .WithMany(p => p.TplusCustomerreasons)
                     .HasForeignKey(d => d.Customerid)
                     .HasConstraintName("TPLUS_CUSTOMER_FK1");
            });

            modelBuilder.Entity<TplusPlan>(entity =>
            {
                entity.ToTable("TPLUS_PLAN", "ETF");

                entity.HasIndex(e => e.Id, "TPLUS_PLAN_PK")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasPrecision(20)
                    .HasColumnName("ID");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar2")
                    .HasMaxLength(200)
                    .HasColumnName("TITLE");

                entity.Property(e => e.IsActicve)
                .HasColumnName("ISACTIVE");

                entity.Property(e => e.ImageName)
                   .HasColumnType("varchar2")
                   .HasMaxLength(200)
                   .HasColumnName("IMAGENAME");

                entity.Property(e => e.Description)
                   .HasColumnType("nvarchar2")
                   .HasMaxLength(200)
                   .HasColumnName("DESCRIPTION");

            });

            modelBuilder.Entity<TplusPlanDetails>(entity =>
            {
                entity.ToTable("TPLUS_PLANDETAILS", "ETF");

                entity.HasIndex(e => e.Id, "TPLUS_PLANDETAILS_PK")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasPrecision(20)
                    .HasColumnName("ID");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar2")
                    .HasMaxLength(200)
                    .HasColumnName("TITLE");

                entity.Property(e => e.URL)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100)
                    .HasColumnName("URL");

                entity.Property(e => e.LatinTitle)
                    .HasColumnType("varchar2")
                    .HasMaxLength(20)
                    .HasColumnName("LATINTITLE");

                entity.Property(e => e.Logo)
                   .HasColumnType("varchar2")
                   .HasMaxLength(100)
                   .HasColumnName("LOGO");

                entity.Property(e => e.PlanId)
                    .HasPrecision(20)
                    .HasColumnName("PLANID");

            });

            modelBuilder.Entity<TplusProvince>(entity =>
            {
                entity.ToTable("TPLUS_PROVINCE", "ETF");

                entity.HasIndex(e => e.Id, "TPLUS_PROVINCE_PK")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasPrecision(20)
                    .HasColumnName("ID");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar2")
                    .HasMaxLength(200)
                    .HasColumnName("TITLE");
            });

            modelBuilder.Entity<TplusRequest>(entity =>
            {
                entity.ToTable("TPLUS_REQUEST", "ETF");

                entity.HasIndex(e => e.Id, "TPLUS_REQUEST_PK")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasPrecision(20)
                    .HasColumnName("ID");

                entity.Property(e => e.Branchid)
                    .HasPrecision(20)
                    .HasColumnName("BRANCHID");

                entity.Property(e => e.SupervisionId)
                    .HasPrecision(20)
                    .HasColumnName("SUPERVISIONID");

                entity.Property(e => e.Customerid)
                    .HasPrecision(20)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Depositamount)
                    .HasPrecision(20)
                    .HasColumnName("DEPOSITAMOUNT");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar2")
                    .HasMaxLength(1000)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("date")
                    .HasColumnName("INSERTDATE");

                entity.Property(e => e.Insertuser)
                    .HasPrecision(20)
                    .HasColumnName("INSERTUSER");

                entity.Property(e => e.Loanamount)
                    .HasPrecision(20)
                    .HasColumnName("LOANAMOUNT");

                entity.Property(e => e.Modifydate)
                    .HasColumnType("date")
                    .HasColumnName("MODIFYDATE");

                entity.Property(e => e.Modifyuser)
                    .HasPrecision(20)
                    .HasColumnName("MODIFYUSER");

                entity.Property(e => e.Planid)
                    .HasPrecision(20)
                    .HasColumnName("PLANID");

                entity.Property(e => e.Requestdate)
                    .HasColumnType("date")
                    .HasColumnName("REQUESTDATE");

                entity.Property(e => e.Statusid)
                    .HasPrecision(20)
                    .HasColumnName("STATUSID");

                entity.Property(e => e.Trackingcode)
                    .HasColumnType("varchar2")
                    .HasMaxLength(20)
                    .HasColumnName("TRACKINGCODE");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TplusRequests)
                    .HasForeignKey(d => d.Branchid)
                    .HasConstraintName("TPLUS_REQUEST_FK5");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TplusRequests)
                    .HasForeignKey(d => d.Customerid)
                    .HasConstraintName("TPLUS_REQUEST_FK2");

                entity.HasOne(d => d.InsertuserNavigation)
                    .WithMany(p => p.TplusRequests)
                    .HasForeignKey(d => d.Insertuser)
                    .HasConstraintName("TPLUS_REQUEST_FK3");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.TplusRequests)
                    .HasForeignKey(d => d.Planid)
                    .HasConstraintName("TPLUS_REQUEST_FK1");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TplusRequests)
                    .HasForeignKey(d => d.Statusid)
                    .HasConstraintName("TPLUS_REQUEST_FK4");

                entity.HasOne(d => d.Supervision)
                    .WithMany(p => p.TplusRequests)
                    .HasForeignKey(d => d.SupervisionId)
                    .HasConstraintName("TPLUS_REQUEST_FK6");
            });

            modelBuilder.Entity<TplusRequesthistory>(entity =>
            {
                entity.ToTable("TPLUS_REQUESTHISTORY", "ETF");

                entity.HasIndex(e => e.Id, "TPLUS_REQUESTHISTORY_PK")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasPrecision(20)
                    .HasColumnName("ID");

                entity.Property(e => e.Branchid)
                    .HasPrecision(20)
                    .HasColumnName("BRANCHID");

                entity.Property(e => e.Customerid)
                    .HasPrecision(20)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Depositamount)
                    .HasPrecision(20)
                    .HasColumnName("DEPOSITAMOUNT");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar2")
                    .HasMaxLength(1000)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Historyinsertdate)
                    .HasColumnType("date")
                    .HasColumnName("HISTORYINSERTDATE");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("date")
                    .HasColumnName("INSERTDATE");

                entity.Property(e => e.Insertuser)
                    .HasPrecision(20)
                    .HasColumnName("INSERTUSER");

                entity.Property(e => e.Loanamount)
                    .HasPrecision(20)
                    .HasColumnName("LOANAMOUNT");

                entity.Property(e => e.Modifydate)
                    .HasColumnType("date")
                    .HasColumnName("MODIFYDATE");

                entity.Property(e => e.Modifyuser)
                    .HasPrecision(20)
                    .HasColumnName("MODIFYUSER");

                entity.Property(e => e.Planid)
                    .HasPrecision(20)
                    .HasColumnName("PLANID");

                entity.Property(e => e.Requestdate)
                    .HasColumnType("date")
                    .HasColumnName("REQUESTDATE");

                entity.Property(e => e.Requestid)
                    .HasPrecision(20)
                    .HasColumnName("REQUESTID");

                entity.Property(e => e.Statusid)
                    .HasPrecision(20)
                    .HasColumnName("STATUSID");

                entity.Property(e => e.Trackingcode)
                    .HasColumnType("varchar2")
                    .HasMaxLength(20)
                    .HasColumnName("TRACKINGCODE");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TplusRequesthistories)
                    .HasForeignKey(d => d.Branchid)
                    .HasConstraintName("TPLUS_REQUESTHISTORY_FK6");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TplusRequesthistories)
                    .HasForeignKey(d => d.Customerid)
                    .HasConstraintName("TPLUS_REQUESTHISTORY_FK3");

                entity.HasOne(d => d.InsertuserNavigation)
                    .WithMany(p => p.TplusRequesthistories)
                    .HasForeignKey(d => d.Insertuser)
                    .HasConstraintName("TPLUS_REQUESTHISTORY_FK4");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.TplusRequesthistories)
                    .HasForeignKey(d => d.Planid)
                    .HasConstraintName("TPLUS_REQUESTHISTORY_FK2");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.TplusRequesthistories)
                    .HasForeignKey(d => d.Requestid)
                    .HasConstraintName("TPLUS_REQUESTHISTORY_FK1");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TplusRequesthistories)
                    .HasForeignKey(d => d.Statusid)
                    .HasConstraintName("TPLUS_REQUESTHISTORY_FK5");
            });

            modelBuilder.Entity<TplusRequeststatus>(entity =>
            {
                entity.ToTable("TPLUS_REQUESTSTATUS", "ETF");

                entity.HasIndex(e => e.Id, "TPLUS_REQUESTSTATUS_PK")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasPrecision(20)
                    .HasColumnName("ID");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar2")
                    .HasMaxLength(200)
                    .HasColumnName("TITLE");
            });

            modelBuilder.Entity<TplusSupervision>(entity =>
            {
                entity.ToTable("TPLUS_SUPERVISION", "ETF");

                entity.HasIndex(e => e.Id, "TPLUS_SUPERVISION_PK")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasPrecision(20)
                    .HasColumnName("ID");

                entity.Property(e => e.Provinceid)
                    .HasPrecision(20)
                    .HasColumnName("PROVINCEID");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar2")
                    .HasMaxLength(200)
                    .HasColumnName("TITLE");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.TplusSupervisions)
                    .HasForeignKey(d => d.Provinceid)
                    .HasConstraintName("TPLUS_SUPERVISION_FK1");
            });

            modelBuilder.Entity<TplusUser>(entity =>
            {
                entity.ToTable("TPLUS_USER", "ETF");

                entity.HasIndex(e => e.Id, "TPLUS_USER_PK")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasPrecision(20)
                    .HasColumnName("ID");

                entity.Property(e => e.Branchid)
                    .HasPrecision(20)
                    .HasColumnName("BRANCHID");

                entity.Property(e => e.Createdate)
                    .HasColumnType("date")
                    .HasColumnName("CREATEDATE");

                entity.Property(e => e.Customerid)
                    .HasPrecision(20)
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Isfirsttime).HasColumnName("ISFIRSTTIME");

                entity.Property(e => e.Modifydate)
                    .HasColumnType("date")
                    .HasColumnName("MODIFYDATE");

                entity.Property(e => e.Password)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Role).HasColumnName("ROLE");

                entity.Property(e => e.Username)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TplusUsers)
                    .HasForeignKey(d => d.Branchid)
                    .HasConstraintName("TPLUS_USER_FK2");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TplusUsers)
                    .HasForeignKey(d => d.Customerid)
                    .HasConstraintName("TPLUS_USER_FK1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
