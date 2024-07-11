﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }



        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentTrainee> DocumentsTrainees { get; set; }
        public DbSet<DocumentTraineeList> DocumentsTraineeLists { get; set; }
        public DbSet<ModelDocument> ModelDocuments { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<RequestInternship> RequestInternships { get; set; }
        public DbSet<Request>Requests { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>()
                .HasDiscriminator<string>("document_type")
                .HasValue<DocumentTrainee>("document_trainee")
                .HasValue<DocumentTraineeList>("document_traineeList");

            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.IdTrainee).IsRequired();
                entity.Property(e => e.ModeleId).IsRequired();
                entity.Property(e => e.role).IsRequired().HasMaxLength(50);
                entity.Property(e => e.DocumentType).IsRequired().HasMaxLength(50);
                entity.Property(e => e.DocumentStatus).IsRequired();

                // Seed data for Requests entity
                entity.HasData(
                    new Request
                    {
                        Id = Guid.NewGuid(),
                        IdTrainee = Guid.NewGuid(),
                        ModeleId = Guid.NewGuid(),
                        role = "Admin",
                        DocumentType = "document_trainee",
                        DocumentStatus = Domain.Enums.DocumentStatus.Accepte  // Assuming DocumentStatus is an enum
                    },
                    new Request
                    {
                        Id = Guid.NewGuid(),
                        IdTrainee = Guid.NewGuid(),
                        ModeleId = Guid.NewGuid(),
                        role = "User",
                        DocumentType = "document_traineeList",
                        DocumentStatus = Domain.Enums.DocumentStatus.InProgress // Assuming DocumentStatus is an enum
                    }
                );
            });
        }


    }
}