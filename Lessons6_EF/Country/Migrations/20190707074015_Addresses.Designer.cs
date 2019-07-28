﻿// <auto-generated />
using System;
using CountryWeb.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CountryWeb.Migrations
{
    [DbContext(typeof(CountryDb))]
    [Migration("20190707074015_Addresses")]
    partial class Addresses
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CountryWeb.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Building");

                    b.Property<int?>("CityId");

                    b.Property<int?>("CountryId");

                    b.Property<int?>("RegionId");

                    b.Property<int?>("StreetId");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("RegionId");

                    b.HasIndex("StreetId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("CountryWeb.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CountryId");

                    b.Property<string>("Name");

                    b.Property<int?>("RegionId");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("RegionId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("CountryWeb.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("CountryWeb.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CountryId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("CountryWeb.Models.Street", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Buildings");

                    b.Property<int?>("CityId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Streets");
                });

            modelBuilder.Entity("CountryWeb.Models.Address", b =>
                {
                    b.HasOne("CountryWeb.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("CountryWeb.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("CountryWeb.Models.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId");

                    b.HasOne("CountryWeb.Models.Street", "Street")
                        .WithMany()
                        .HasForeignKey("StreetId");
                });

            modelBuilder.Entity("CountryWeb.Models.City", b =>
                {
                    b.HasOne("CountryWeb.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("CountryWeb.Models.Region", "Region")
                        .WithMany("Cities")
                        .HasForeignKey("RegionId");
                });

            modelBuilder.Entity("CountryWeb.Models.Region", b =>
                {
                    b.HasOne("CountryWeb.Models.Country", "Country")
                        .WithMany("Regions")
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("CountryWeb.Models.Street", b =>
                {
                    b.HasOne("CountryWeb.Models.City", "City")
                        .WithMany("Streets")
                        .HasForeignKey("CityId");
                });
#pragma warning restore 612, 618
        }
    }
}