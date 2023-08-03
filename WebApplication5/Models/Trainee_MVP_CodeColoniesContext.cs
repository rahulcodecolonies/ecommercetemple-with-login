using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication5.Models
{
    public partial class Trainee_MVP_CodeColoniesContext : DbContext
    {
        public Trainee_MVP_CodeColoniesContext()
        {
        }

        public Trainee_MVP_CodeColoniesContext(DbContextOptions<Trainee_MVP_CodeColoniesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<HSkil> HSkils { get; set; } = null!;
        public virtual DbSet<HSkill> HSkills { get; set; } = null!;
        public virtual DbSet<LoginTable> LoginTables { get; set; } = null!;
        public virtual DbSet<MAddress> MAddresses { get; set; } = null!;
        public virtual DbSet<MCity> MCities { get; set; } = null!;
        public virtual DbSet<MCompany> MCompanies { get; set; } = null!;
        public virtual DbSet<MCountry> MCountries { get; set; } = null!;
        public virtual DbSet<MExperience> MExperiences { get; set; } = null!;
        public virtual DbSet<MJob> MJobs { get; set; } = null!;
        public virtual DbSet<MJobType> MJobTypes { get; set; } = null!;
        public virtual DbSet<MLocation> MLocations { get; set; } = null!;
        public virtual DbSet<MProjectStatus> MProjectStatuses { get; set; } = null!;
        public virtual DbSet<MSkill> MSkills { get; set; } = null!;
        public virtual DbSet<MState> MStates { get; set; } = null!;
        public virtual DbSet<MSubscriptionPlan> MSubscriptionPlans { get; set; } = null!;
        public virtual DbSet<MUser> MUsers { get; set; } = null!;
        public virtual DbSet<MUserType> MUserTypes { get; set; } = null!;
        public virtual DbSet<Partner> Partners { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<Registration> Registrations { get; set; } = null!;
        public virtual DbSet<ScheduleAssessment> ScheduleAssessments { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Student1> Students1 { get; set; } = null!;
        public virtual DbSet<Talent> Talents { get; set; } = null!;
        public virtual DbSet<UserLogin> UserLogins { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=185.227.134.118\\\\\\\\VMI1302816,1433;Database=Trainee_MVP_CodeColonies;Persist Security Info=True;User ID=sa;Password=Admin@codeup;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_Clients_M_Company");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.PartnerId)
                    .HasConstraintName("FK_Clients_Partners");

                entity.HasOne(d => d.Talent)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.TalentId)
                    .HasConstraintName("FK_Clients_Talent");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Clients_M_Users");
            });

            modelBuilder.Entity<HSkil>(entity =>
            {
                entity.HasKey(e => e.SkillId)
                    .HasName("PK__H_Skil__DFA091870DF63C54");

                entity.ToTable("H_Skil");

                entity.Property(e => e.SkillId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SkillName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HSkill>(entity =>
            {
                entity.HasKey(e => e.SkillId)
                    .HasName("PK__H_Skill__DFA0918752C8CC43");

                entity.ToTable("H_Skill");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SkillName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LoginTable>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Login_Table");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("User_Name");
            });

            modelBuilder.Entity<MAddress>(entity =>
            {
                entity.HasKey(e => e.AddressId);

                entity.ToTable("M_Address");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.MAddresses)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_M_Address_M_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.MAddresses)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_M_Address_M_Country");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.MAddresses)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_M_Address_M_State");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MAddresses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_M_Address_M_Users");
            });

            modelBuilder.Entity<MCity>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PK__M_City__F2D21B7630826F3C");

                entity.ToTable("M_City");

                entity.Property(e => e.CityName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("PK__M_Compan__2D971C4CC3622EAA");

                entity.ToTable("M_Company");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyWebsite)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.MCompanies)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_M_Company_M_Address");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MCompanies)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_M_Company_M_Users");
            });

            modelBuilder.Entity<MCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK__M_Countr__10D1609F87876DFF");

                entity.ToTable("M_Country");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CountryShortName)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MExperience>(entity =>
            {
                entity.HasKey(e => e.ExperienceId);

                entity.ToTable("M_Experience");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExperienceName).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MJob>(entity =>
            {
                entity.HasKey(e => e.JobId);

                entity.ToTable("M_Jobs");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MJobType>(entity =>
            {
                entity.HasKey(e => e.JobTypeId);

                entity.ToTable("M_JobType");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.JobType).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MLocation>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.ToTable("M_Location");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MProjectStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK_ProjectStatus");

                entity.ToTable("M_ProjectStatus");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusType).HasMaxLength(50);
            });

            modelBuilder.Entity<MSkill>(entity =>
            {
                entity.HasKey(e => e.SkillId)
                    .HasName("PK__M_Skill__DFA0918752C8CC42");

                entity.ToTable("M_Skill");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SkillName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MState>(entity =>
            {
                entity.HasKey(e => e.StateId)
                    .HasName("PK__M_State__C3BA3B3AD6DED606");

                entity.ToTable("M_State");

                entity.Property(e => e.StateName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.MStates)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__M_State__Country__76969D2E");
            });

            modelBuilder.Entity<MSubscriptionPlan>(entity =>
            {
                entity.HasKey(e => e.PlanId)
                    .HasName("PK__Subscrip__755C22B734587258");

                entity.ToTable("M_SubscriptionPlans");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PlanDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlanName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlanPrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<MUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("M_Users");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.MUsers)
                    .HasForeignKey(d => d.UserTypeId)
                    .HasConstraintName("FK_M_Users_M_UserType");
            });

            modelBuilder.Entity<MUserType>(entity =>
            {
                entity.HasKey(e => e.UserTypeId);

                entity.ToTable("M_UserType");

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserTypeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.Property(e => e.Company)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PartnerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectEndDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectName).HasMaxLength(100);

                entity.Property(e => e.ProjectStartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Projects_Projects");
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Registration");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Hobbies)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ScheduleAssessment>(entity =>
            {
                entity.HasKey(e => e.AssessmentId);

                entity.ToTable("ScheduleAssessment");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ScheduleDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Student");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Hobbies)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Student1>(entity =>
            {
                entity.ToTable("Students");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Course)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Hobbies)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Talent>(entity =>
            {
                entity.ToTable("Talent");

                entity.Property(e => e.CommunicationRate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentPayout).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cvurl).HasColumnName("CVURL");

                entity.Property(e => e.DegreeTitle).HasMaxLength(50);

                entity.Property(e => e.ExpectedPayout).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GithubUrl).HasColumnName("GithubURL");

                entity.Property(e => e.LinkedInUrl).HasColumnName("LinkedInURL");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PreferredWorkLocation).HasMaxLength(20);

                entity.Property(e => e.UniversityName).HasMaxLength(100);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Talents)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_Talent_M_Address");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Talents)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Talent_M_Users");
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserLogin");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
