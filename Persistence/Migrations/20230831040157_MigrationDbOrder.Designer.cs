﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Contexts;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230831040157_MigrationDbOrder")]
    partial class MigrationDbOrder
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.ContractC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasMaxLength(100)
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("ContractC", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CollegeCourse")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CollegeLevel")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CollegeName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Commission")
                        .HasColumnType("int");

                    b.Property<string>("CourseCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeliveryMedium")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DischargeDate")
                        .HasMaxLength(100)
                        .HasColumnType("datetime(6)");

                    b.Property<int>("NumberGraduates")
                        .HasColumnType("int");

                    b.Property<string>("SchoolLocation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Seller")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("State")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("Total")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Course", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.DressItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<double>("Price")
                        .HasMaxLength(100)
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("DressItem", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
