﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecruitWebApplicationkudumusr.Data;

#nullable disable

namespace RecruitWebApplicationkudumusr.Migrations
{
    [DbContext(typeof(RecruitWebApplicationkudumusrContext))]
    [Migration("20240922163154_JobTitles")]
    partial class JobTitles
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RecruitWebApplicationkudumusr.Models.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("IndustryID")
                        .HasColumnType("int");

                    b.Property<int>("JobTitleID")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TargetSalary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyID");

                    b.HasIndex("IndustryID");

                    b.HasIndex("JobTitleID");

                    b.ToTable("Candidate");
                });

            modelBuilder.Entity("RecruitWebApplicationkudumusr.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IndustryID")
                        .HasColumnType("int");

                    b.Property<int>("JobTitleID")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("MaximumSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinimumSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IndustryID");

                    b.HasIndex("JobTitleID");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("RecruitWebApplicationkudumusr.Models.Industry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Industry");
                });

            modelBuilder.Entity("RecruitWebApplicationkudumusr.Models.JobTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("MaximumSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinimumSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("JobTitle");
                });

            modelBuilder.Entity("RecruitWebApplicationkudumusr.Models.Candidate", b =>
                {
                    b.HasOne("RecruitWebApplicationkudumusr.Models.Company", "Company")
                        .WithMany("Candidates")
                        .HasForeignKey("CompanyID");

                    b.HasOne("RecruitWebApplicationkudumusr.Models.Industry", "Industry")
                        .WithMany("Candidates")
                        .HasForeignKey("IndustryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecruitWebApplicationkudumusr.Models.JobTitle", "JobTitle")
                        .WithMany("Candidates")
                        .HasForeignKey("JobTitleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Industry");

                    b.Navigation("JobTitle");
                });

            modelBuilder.Entity("RecruitWebApplicationkudumusr.Models.Company", b =>
                {
                    b.HasOne("RecruitWebApplicationkudumusr.Models.Industry", "Industry")
                        .WithMany("Companies")
                        .HasForeignKey("IndustryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecruitWebApplicationkudumusr.Models.JobTitle", "JobTitle")
                        .WithMany()
                        .HasForeignKey("JobTitleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Industry");

                    b.Navigation("JobTitle");
                });

            modelBuilder.Entity("RecruitWebApplicationkudumusr.Models.Company", b =>
                {
                    b.Navigation("Candidates");
                });

            modelBuilder.Entity("RecruitWebApplicationkudumusr.Models.Industry", b =>
                {
                    b.Navigation("Candidates");

                    b.Navigation("Companies");
                });

            modelBuilder.Entity("RecruitWebApplicationkudumusr.Models.JobTitle", b =>
                {
                    b.Navigation("Candidates");
                });
#pragma warning restore 612, 618
        }
    }
}
