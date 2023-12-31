﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaxCalculator.Data;

#nullable disable

namespace TaxCalculator.API.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20231128220125_DatabaseCreation")]
    partial class DatabaseCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaxCalculator.Domain.Models.TaxBand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BandName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("LowerLimit")
                        .HasColumnType("int");

                    b.Property<int>("TaxRate")
                        .HasColumnType("int");

                    b.Property<int?>("UpperLimit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TaxBands");
                });
#pragma warning restore 612, 618
        }
    }
}
