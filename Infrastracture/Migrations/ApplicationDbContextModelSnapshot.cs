﻿// <auto-generated />
using System;
using Infrastructure.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastracture.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Contract", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("CreatedBy")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<string>("LastModifiedBy")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("LastModifiedDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.ToTable("Contracts");
            });

            modelBuilder.Entity("Domain.Entities.Document", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("CreatedBy")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<string>("DocumentType")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("FilePath")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<Guid>("IdModelDocuments")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("LastModifiedBy")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("LastModifiedDate")
                    .HasColumnType("datetime2");

                b.Property<string>("document_type")
                    .IsRequired()
                    .HasMaxLength(21)
                    .HasColumnType("nvarchar(21)");

                b.HasKey("Id");

                b.ToTable("Documents");

                b.HasDiscriminator<string>("document_type").HasValue("Document");

                b.UseTphMappingStrategy();
            });

            modelBuilder.Entity("Domain.Entities.ModelDocument", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("CreatedBy")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("FilePath")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

<<<<<<< HEAD
                    b.HasData(
                        new
                        {
                            Id = new Guid("962feaf9-c9d3-4f62-b300-ab3a7b22d4e7"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentStatus = 0,
                            DocumentType = "document_trainee",
                            IdTrainee = new Guid("67e583c0-c2c7-4aee-a3c3-cfa3b15f370b"),
                            ModeleId = new Guid("fe93b47c-fcf9-49ce-a922-91eeef91aa7d"),
                            role = "Admin"
                        },
                        new
                        {
                            Id = new Guid("a01df0a1-db68-4f90-b9d6-f5ec488286d8"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentStatus = 1,
                            DocumentType = "document_traineeList",
                            IdTrainee = new Guid("a9f793a0-8f2c-4b14-9d55-d1a22d3e8e58"),
                            ModeleId = new Guid("e419892e-3aea-462c-8da0-26d598d5e7aa"),
                            role = "User"
                        });
                });
=======
                b.Property<string>("LastModifiedBy")
                    .HasColumnType("nvarchar(max)");
>>>>>>> c60f6a7f8c6f0c9e23e5e05271c9f0070525fac5

                b.Property<DateTime?>("LastModifiedDate")
                    .HasColumnType("datetime2");

                b.Property<Guid>("ModeleId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("NomModele")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("ModelDocuments");
            });

            modelBuilder.Entity("Domain.Entities.Report", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("CheminFichier")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("CreatedBy")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("DateCreation")
                    .HasColumnType("datetime2");

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("LastModifiedBy")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("LastModifiedDate")
                    .HasColumnType("datetime2");

                b.Property<string>("NomRapport")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("RapportId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("Reports");
            });

            modelBuilder.Entity("Domain.Entities.Request", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("CreatedBy")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<int>("DocumentStatus")
                    .HasColumnType("int");

                b.Property<string>("DocumentType")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.Property<Guid>("IdTrainee")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("LastModifiedBy")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("LastModifiedDate")
                    .HasColumnType("datetime2");

                b.Property<Guid>("ModeleId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("role")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.HasKey("Id");

                b.ToTable("Requests");

                b.HasData(
                    new
                    {
                        Id = new Guid("0db17e3f-9a64-4fbf-b07d-af2b24b7d91e"),
                        CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        DocumentStatus = 0,
                        DocumentType = "document_trainee",
                        IdTrainee = new Guid("2bf680c1-f6d7-422f-80cd-513f7bc2ddad"),
                        ModeleId = new Guid("fa239f69-46f8-40d3-98d6-44197bb039c9"),
                        role = "Admin"
                    },
                    new
                    {
                        Id = new Guid("7dd7ce09-9d7e-406e-81cc-4c41d51d7000"),
                        CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        DocumentStatus = 0,
                        DocumentType = "document_trainee",
                        IdTrainee = new Guid("6fbd1315-5a60-4053-a595-4f07f876d215"),
                        ModeleId = new Guid("de1375c0-4bb0-45fc-ae63-355af858d0c2"),
                        role = "User"
                    },
                    new
                    {
                        Id = new Guid("43441e81-62e4-44cf-acd1-6c7c042181ab"),
                        CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        DocumentStatus = 1,
                        DocumentType = "document_traineeList",
                        IdTrainee = new Guid("4d025293-7793-4fac-b5a3-17a466e18315"),
                        ModeleId = new Guid("ae9e3455-18b0-40f3-8138-3bb635d9eea1")
                    },
                    new
                    {
                        Id = new Guid("f545b58c-8ae6-4f26-8823-9856685dec2b"),
                        CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        DocumentStatus = 1,
                        DocumentType = "document_traineeList",
                        IdTrainee = new Guid("2f83b87d-7322-46e0-b3f5-18896ff5c852"),
                        ModeleId = new Guid("aa43b347-4cc1-4f0f-a7ff-8153a5caaea1")
                    });
            });

            modelBuilder.Entity("Domain.Entities.RequestInternship", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("CreatedBy")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<string>("LastModifiedBy")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("LastModifiedDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.ToTable("RequestInternships");
            });

            modelBuilder.Entity("Domain.Entities.DocumentTrainee", b =>
            {
                b.HasBaseType("Domain.Entities.Document");

                b.Property<Guid>("IdTrainee")
                    .HasColumnType("uniqueidentifier");

                b.HasDiscriminator().HasValue("document_trainee");
            });

            modelBuilder.Entity("Domain.Entities.DocumentTraineeList", b =>
            {
                b.HasBaseType("Domain.Entities.Document");

                b.Property<string>("IdTraineesList")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasDiscriminator().HasValue("document_traineeList");
            });
#pragma warning restore 612, 618
        }
    }
}
