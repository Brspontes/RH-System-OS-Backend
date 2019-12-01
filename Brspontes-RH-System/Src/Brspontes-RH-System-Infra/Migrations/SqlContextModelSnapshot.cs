﻿// <auto-generated />
using System;
using Brspontes_RH_System_Infra.SqlDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Brspontes_RH_System_Infra.Migrations
{
    [DbContext(typeof(SqlContext))]
    partial class SqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Brspontes_RH_System_Domain.CandidateContext.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.Property<Guid>("CandidateId");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("PublicArea")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CandidateId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Brspontes_RH_System_Domain.CandidateContext.Candidate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Curriculum")
                        .IsRequired();

                    b.Property<string>("Document");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("Brspontes_RH_System_Domain.CandidateContext.Address", b =>
                {
                    b.HasOne("Brspontes_RH_System_Domain.CandidateContext.Candidate", "Candidate")
                        .WithOne("Address")
                        .HasForeignKey("Brspontes_RH_System_Domain.CandidateContext.Address", "CandidateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
