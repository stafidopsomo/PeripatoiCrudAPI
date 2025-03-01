﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using peripatoiCrud.API.Data;

#nullable disable

namespace peripatoiCrud.API.Migrations
{
    [DbContext(typeof(PeripatoiDbContext))]
    [Migration("20240606192604_Arxiko Migration (Initial Migration")]
    partial class ArxikoMigrationInitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("peripatoiCrud.API.Models.Domain.Dyskolia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Onoma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dyskolies");
                });

            modelBuilder.Entity("peripatoiCrud.API.Models.Domain.Perioxh", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EikonaUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kwdikos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Onoma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Perioxes");
                });

            modelBuilder.Entity("peripatoiCrud.API.Models.Domain.Peripatos", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DyskoliaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EikonaUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Mhkos")
                        .HasColumnType("float");

                    b.Property<string>("Onoma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Perigrafh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PerioxhId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DyskoliaId");

                    b.HasIndex("PerioxhId");

                    b.ToTable("Peripatoi");
                });

            modelBuilder.Entity("peripatoiCrud.API.Models.Domain.Peripatos", b =>
                {
                    b.HasOne("peripatoiCrud.API.Models.Domain.Dyskolia", "Dyskolia")
                        .WithMany()
                        .HasForeignKey("DyskoliaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("peripatoiCrud.API.Models.Domain.Perioxh", "Perioxh")
                        .WithMany()
                        .HasForeignKey("PerioxhId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dyskolia");

                    b.Navigation("Perioxh");
                });
#pragma warning restore 612, 618
        }
    }
}
