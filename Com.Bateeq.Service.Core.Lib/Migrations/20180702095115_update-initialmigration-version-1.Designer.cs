﻿// <auto-generated />
using System;
using Com.Bateeq.Service.Core.Lib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Com.Bateeq.Service.Core.Lib.Migrations
{
    [DbContext(typeof(CoreDbContext))]
    [Migration("20180702095115_update-initialmigration-version-1")]
    partial class updateinitialmigrationversion1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Com.Bateeq.Service.Core.Lib.Models.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("_id");

                    b.Property<string>("_stamp");

                    b.Property<string>("_type");

                    b.Property<string>("_version");

                    b.HasKey("Id");

                    b.ToTable("Bank");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Core.Lib.Models.MigrationModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("_id");

                    b.Property<string>("_stamp");

                    b.Property<string>("_type");

                    b.Property<string>("_version");

                    b.HasKey("Id");

                    b.ToTable("MigrationModel");
                });
#pragma warning restore 612, 618
        }
    }
}
