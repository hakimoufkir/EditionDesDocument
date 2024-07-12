﻿// <auto-generated />
using System;
using Infrastructure.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastracture.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
<<<<<<<< HEAD:Infrastracture/Migrations/20240711103548_initDb.Designer.cs
    [Migration("20240711103548_initDb")]
    partial class initDb
========
    [Migration("20240712091721_hhhhhhh")]
    partial class hhhhhhh
>>>>>>>> d64bcffe3a4f7bc5d4da801582f2349d656424a2:Infrastracture/Migrations/20240712091721_hhhhhhh.Designer.cs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("NameTrainee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Requests");

                    b.HasData(
                        new
                        {
<<<<<<<< HEAD:Infrastracture/Migrations/20240711103548_initDb.Designer.cs
                            Id = new Guid("fe9fbc11-fe1e-4ad7-8059-1b0c569e65bb"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentStatus = 0,
                            DocumentType = "document_trainee",
                            IdTrainee = new Guid("acbb8ff3-76ac-4b9b-b6ef-a15b19b43c16"),
                            ModeleId = new Guid("93c3630c-6e0c-431d-82b1-77ed25746180"),
========
                            Id = new Guid("78e69cf9-db54-48a8-b9ff-6a8443602d61"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentStatus = 0,
                            DocumentType = "document_trainee",
                            IdTrainee = new Guid("f8a82dd9-7100-4891-a786-fa995858f1f6"),
                            ModeleId = new Guid("19202e5b-4a5d-4116-8801-5682f592e4d9"),
>>>>>>>> d64bcffe3a4f7bc5d4da801582f2349d656424a2:Infrastracture/Migrations/20240712091721_hhhhhhh.Designer.cs
                            role = "Admin"
                        },
                        new
                        {
<<<<<<<< HEAD:Infrastracture/Migrations/20240711103548_initDb.Designer.cs
                            Id = new Guid("17637d6e-16dc-4257-a47b-f477f03d256b"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentStatus = 1,
                            DocumentType = "document_traineeList",
                            IdTrainee = new Guid("2211bf70-e766-47b2-a00b-6e23ef3f6284"),
                            ModeleId = new Guid("afb91c8f-0c29-482b-88a8-b96c06932284"),
========
                            Id = new Guid("d4b16499-d2a2-444c-a7e1-a1e93119aad1"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentStatus = 1,
                            DocumentType = "document_traineeList",
                            IdTrainee = new Guid("fb9b44d5-12ab-4bd4-b654-a751622fa92f"),
                            ModeleId = new Guid("06e718f8-57c6-4ffa-b111-aa583d4d9699"),
>>>>>>>> d64bcffe3a4f7bc5d4da801582f2349d656424a2:Infrastracture/Migrations/20240712091721_hhhhhhh.Designer.cs
                            role = "User"
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
