﻿// <auto-generated />
using System;
using Inter.Core.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Inter.Core.Infra.Data.Migrations
{
    [DbContext(typeof(MySQLContext))]
    [Migration("20190705130426_changeLimitFromTables")]
    partial class changeLimitFromTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Inter.Core.Domain.Entities.Accomodation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("Available");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasMaxLength(13);

                    b.Property<Guid>("EnvironmentId");

                    b.Property<string>("Identifier")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("NumberOfPlaces");

                    b.HasKey("Id");

                    b.HasIndex("EnvironmentId");

                    b.ToTable("Accomodation");
                });

            modelBuilder.Entity("Inter.Core.Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<Guid>("EnvironmentId");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("EnvironmentId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Inter.Core.Domain.Entities.College", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<Guid>("EnvironmentId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("EnvironmentId");

                    b.ToTable("College");
                });

            modelBuilder.Entity("Inter.Core.Domain.Entities.CollegeTime", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AccomodationPrice");

                    b.Property<decimal>("BookPrice")
                        .HasColumnType("decimal(6,4)");

                    b.Property<Guid>("CollegeId");

                    b.Property<int>("DaysOfWeek");

                    b.Property<decimal>("ExamPrice");

                    b.Property<TimeSpan>("FinishTime");

                    b.Property<decimal>("GrossPrice");

                    b.Property<decimal>("InsurancePrice");

                    b.Property<decimal>("NetPrice");

                    b.Property<string>("Note");

                    b.Property<int>("PercentagePrice");

                    b.Property<string>("Period");

                    b.Property<decimal>("Price");

                    b.Property<decimal>("RenewPrice");

                    b.Property<TimeSpan>("StartTime");

                    b.Property<int>("TimeForWeek");

                    b.HasKey("Id");

                    b.HasIndex("CollegeId");

                    b.ToTable("CollegeTime");
                });

            modelBuilder.Entity("Inter.Core.Domain.Entities.CulturalExchange", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AccomodationId");

                    b.Property<DateTime?>("ArrivalDateTime");

                    b.Property<bool>("Available");

                    b.Property<Guid>("CollegeId");

                    b.Property<bool>("CollegePayment");

                    b.Property<Guid>("CollegeTimeId");

                    b.Property<string>("Company")
                        .HasMaxLength(20);

                    b.Property<int>("DaysOfAccomodation");

                    b.Property<Guid>("EnvironmentId");

                    b.Property<DateTime>("FinishAccomodation");

                    b.Property<string>("FlightNumber")
                        .HasMaxLength(10);

                    b.Property<bool>("INSUR");

                    b.Property<bool>("Kit");

                    b.Property<bool>("OurAccomodation");

                    b.Property<bool>("Renew");

                    b.Property<string>("SalesMen")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<bool>("SimCard");

                    b.Property<DateTime>("StartAccomodation");

                    b.Property<DateTime>("StartDate");

                    b.Property<Guid>("StudentId");

                    b.Property<bool>("Support");

                    b.Property<float>("TotalValue");

                    b.Property<bool>("Transfer");

                    b.Property<int>("WeekNumber");

                    b.HasKey("Id");

                    b.HasIndex("AccomodationId");

                    b.HasIndex("CollegeId");

                    b.HasIndex("CollegeTimeId");

                    b.HasIndex("EnvironmentId");

                    b.HasIndex("StudentId");

                    b.ToTable("CulturalExchange");
                });

            modelBuilder.Entity("Inter.Core.Domain.Entities.CulturalExchangeFileUpload", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CulturalExchangeId");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("UploadDate");

                    b.HasKey("Id");

                    b.HasIndex("CulturalExchangeId");

                    b.ToTable("CulturalExchangeFileUpload");
                });

            modelBuilder.Entity("Inter.Core.Domain.Entities.PaymentCulturalExchange", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CulturalExchangeId");

                    b.Property<DateTime>("DateOfPayment");

                    b.Property<Guid>("EnvironmentId");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<DateTime>("UploadDate");

                    b.Property<float>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CulturalExchangeId");

                    b.HasIndex("EnvironmentId");

                    b.ToTable("PaymentCulturalExchange");
                });

            modelBuilder.Entity("Inter.Core.Domain.Entities.ReceivePaymentCulturalExchange", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CulturalExchangeId");

                    b.Property<DateTime>("DateOfPayment");

                    b.Property<Guid>("EnvironmentId");

                    b.Property<string>("FileName");

                    b.Property<string>("From");

                    b.Property<string>("Note");

                    b.Property<string>("To");

                    b.Property<string>("Type");

                    b.Property<DateTime>("UploadDate");

                    b.Property<float>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CulturalExchangeId");

                    b.HasIndex("EnvironmentId");

                    b.ToTable("ReceivePaymentCulturalExchange");
                });

            modelBuilder.Entity("Inter.Core.Domain.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<DateTime>("DateOfBirthday");

                    b.Property<DateTime>("DateOfInsert");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<Guid>("EnvironmentId");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<DateTime>("PassportDateOfExpiry");

                    b.Property<DateTime>("PassportDateOfIssue");

                    b.Property<string>("PassportNumber")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("EnvironmentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Inter.Core.Domain.Entities.SystemEnvironment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Available");

                    b.Property<string>("CompanyCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("FinishDate");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Environment");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Inter.Core.Domain.Entities.Accomodation", b =>
                {
                    b.HasOne("Inter.Core.Domain.Entities.SystemEnvironment", "Environment")
                        .WithMany("Accomodations")
                        .HasForeignKey("EnvironmentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Inter.Core.Domain.Entities.ApplicationUser", b =>
                {
                    b.HasOne("Inter.Core.Domain.Entities.SystemEnvironment", "Environment")
                        .WithMany("Users")
                        .HasForeignKey("EnvironmentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Inter.Core.Domain.Entities.College", b =>
                {
                    b.HasOne("Inter.Core.Domain.Entities.SystemEnvironment", "Environment")
                        .WithMany("Colleges")
                        .HasForeignKey("EnvironmentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Inter.Core.Domain.Entities.CollegeTime", b =>
                {
                    b.HasOne("Inter.Core.Domain.Entities.College", "College")
                        .WithMany("CollegeTime")
                        .HasForeignKey("CollegeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Inter.Core.Domain.Entities.CulturalExchange", b =>
                {
                    b.HasOne("Inter.Core.Domain.Entities.Accomodation", "Accomodation")
                        .WithMany("CulturalExchanges")
                        .HasForeignKey("AccomodationId");

                    b.HasOne("Inter.Core.Domain.Entities.College", "College")
                        .WithMany()
                        .HasForeignKey("CollegeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Inter.Core.Domain.Entities.CollegeTime", "CollegeTime")
                        .WithMany()
                        .HasForeignKey("CollegeTimeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Inter.Core.Domain.Entities.SystemEnvironment", "Environment")
                        .WithMany("CulturalExchange")
                        .HasForeignKey("EnvironmentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Inter.Core.Domain.Entities.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Inter.Core.Domain.Entities.CulturalExchangeFileUpload", b =>
                {
                    b.HasOne("Inter.Core.Domain.Entities.CulturalExchange", "CulturalExchange")
                        .WithMany("CulturalExchangeFileUpload")
                        .HasForeignKey("CulturalExchangeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Inter.Core.Domain.Entities.PaymentCulturalExchange", b =>
                {
                    b.HasOne("Inter.Core.Domain.Entities.CulturalExchange", "CulturalExchange")
                        .WithMany()
                        .HasForeignKey("CulturalExchangeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Inter.Core.Domain.Entities.SystemEnvironment", "Environment")
                        .WithMany()
                        .HasForeignKey("EnvironmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Inter.Core.Domain.Entities.ReceivePaymentCulturalExchange", b =>
                {
                    b.HasOne("Inter.Core.Domain.Entities.CulturalExchange", "CulturalExchange")
                        .WithMany("ReceivePaymentCulturalExchanges")
                        .HasForeignKey("CulturalExchangeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Inter.Core.Domain.Entities.SystemEnvironment", "Environment")
                        .WithMany("ReceivePaymentsCulturalExchanges")
                        .HasForeignKey("EnvironmentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Inter.Core.Domain.Entities.Student", b =>
                {
                    b.HasOne("Inter.Core.Domain.Entities.SystemEnvironment", "Environment")
                        .WithMany("Students")
                        .HasForeignKey("EnvironmentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Inter.Core.Domain.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Inter.Core.Domain.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Inter.Core.Domain.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Inter.Core.Domain.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
