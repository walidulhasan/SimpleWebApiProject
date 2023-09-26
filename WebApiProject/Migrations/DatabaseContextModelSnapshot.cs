﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiProject.Context;

#nullable disable

namespace WebApiProject.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApiProject.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("WebApiProject.Models.Material", b =>
                {
                    b.Property<int>("MaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaterialId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaterialId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("WebApiProject.Models.Purchase", b =>
                {
                    b.Property<int>("PurchaseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchaseID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PurchaseReceiveDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShipmentWay")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.HasKey("PurchaseID");

                    b.ToTable("Purchase");
                });

            modelBuilder.Entity("WebApiProject.Models.PurchaseDetails", b =>
                {
                    b.Property<int>("PurchaseDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchaseDetailsId"));

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("PurchaseId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("PurchaseDetailsId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("PurchaseId");

                    b.HasIndex("VendorId");

                    b.ToTable("PurchaseDetails");
                });

            modelBuilder.Entity("WebApiProject.Models.PurchaseDistribution", b =>
                {
                    b.Property<int>("PurchaseDistributionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchaseDistributionId"));

                    b.Property<int>("DeliverQuantity")
                        .HasColumnType("int");

                    b.Property<string>("DistributionBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DistributionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<string>("ReceivedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequisitionId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PurchaseDistributionId");

                    b.HasIndex("RequisitionId");

                    b.ToTable("PurchaseDistribution");
                });

            modelBuilder.Entity("WebApiProject.Models.Requisition", b =>
                {
                    b.Property<int>("RequisitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequisitionId"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("RequisitionBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RequisitionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RequisitionId");

                    b.ToTable("Requisition");
                });

            modelBuilder.Entity("WebApiProject.Models.RequisitionDetails", b =>
                {
                    b.Property<int>("RequiDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequiDetailsId"));

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RequisitionId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RequiDetailsId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("RequisitionId");

                    b.ToTable("RequisitionDetails");
                });

            modelBuilder.Entity("WebApiProject.Models.Stock", b =>
                {
                    b.Property<int>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockId"));

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StockDate")
                        .HasColumnType("datetime2");

                    b.HasKey("StockId");

                    b.HasIndex("MaterialId");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("WebApiProject.Models.Vendor", b =>
                {
                    b.Property<int>("VendorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VendorId"));

                    b.Property<string>("ContactPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("VendorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VendorId");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("WebApiProject.Models.Material", b =>
                {
                    b.HasOne("WebApiProject.Models.Category", "Category")
                        .WithMany("Materials")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebApiProject.Models.PurchaseDetails", b =>
                {
                    b.HasOne("WebApiProject.Models.Material", "Material")
                        .WithMany("PurchaseDetails")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiProject.Models.Purchase", "Purchase")
                        .WithMany("PurchaseDetails")
                        .HasForeignKey("PurchaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiProject.Models.Vendor", "Vendor")
                        .WithMany("PurchaseDetails")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");

                    b.Navigation("Purchase");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("WebApiProject.Models.PurchaseDistribution", b =>
                {
                    b.HasOne("WebApiProject.Models.Requisition", "Requisition")
                        .WithMany("PurchaseDistributions")
                        .HasForeignKey("RequisitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Requisition");
                });

            modelBuilder.Entity("WebApiProject.Models.RequisitionDetails", b =>
                {
                    b.HasOne("WebApiProject.Models.Material", "Material")
                        .WithMany("RequisitionDetails")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiProject.Models.Requisition", "Requisition")
                        .WithMany("RequisitionDetails")
                        .HasForeignKey("RequisitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");

                    b.Navigation("Requisition");
                });

            modelBuilder.Entity("WebApiProject.Models.Stock", b =>
                {
                    b.HasOne("WebApiProject.Models.Material", "Material")
                        .WithMany("Stocks")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");
                });

            modelBuilder.Entity("WebApiProject.Models.Category", b =>
                {
                    b.Navigation("Materials");
                });

            modelBuilder.Entity("WebApiProject.Models.Material", b =>
                {
                    b.Navigation("PurchaseDetails");

                    b.Navigation("RequisitionDetails");

                    b.Navigation("Stocks");
                });

            modelBuilder.Entity("WebApiProject.Models.Purchase", b =>
                {
                    b.Navigation("PurchaseDetails");
                });

            modelBuilder.Entity("WebApiProject.Models.Requisition", b =>
                {
                    b.Navigation("PurchaseDistributions");

                    b.Navigation("RequisitionDetails");
                });

            modelBuilder.Entity("WebApiProject.Models.Vendor", b =>
                {
                    b.Navigation("PurchaseDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
