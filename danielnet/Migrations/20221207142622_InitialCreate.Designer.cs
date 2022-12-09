﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet;

#nullable disable

namespace danielnet.Migrations
{
    [DbContext(typeof(MySQLDBContext))]
    [Migration("20221207142622_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("dotnet.Claim", b =>
                {
                    b.Property<int>("Claim_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Vehicle_Id")
                        .HasColumnType("int");

                    b.HasKey("Claim_Id");

                    b.HasIndex("Vehicle_Id");

                    b.ToTable("Claim");
                });

            modelBuilder.Entity("dotnet.Owner", b =>
                {
                    b.Property<int>("Owner_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DriverLicense")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Owner_Id");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("dotnet.Vehicle", b =>
                {
                    b.Property<int>("Vehicle_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Owner_Id")
                        .HasColumnType("int");

                    b.Property<string>("Vin")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Vehicle_Id");

                    b.HasIndex("Owner_Id");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("dotnet.Claim", b =>
                {
                    b.HasOne("dotnet.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("Vehicle_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("dotnet.Vehicle", b =>
                {
                    b.HasOne("dotnet.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("Owner_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });
#pragma warning restore 612, 618
        }
    }
}
