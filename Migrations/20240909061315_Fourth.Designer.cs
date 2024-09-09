﻿// <auto-generated />
using System;
using CargoManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CargoManagement.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240909061315_Fourth")]
    partial class Fourth
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CargoManagement.Models.Entity.CargoOrder", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ShipDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CargoOrders");
                });

            modelBuilder.Entity("CargoManagement.Models.Entity.CargoOrderDetails", b =>
                {
                    b.Property<int>("ShippmentId")
                        .HasColumnType("int");

                    b.Property<int>("CargoOrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("UnitCost")
                        .HasColumnType("float");

                    b.HasKey("ShippmentId");

                    b.HasIndex("CargoOrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("CargoOrderDetails");
                });

            modelBuilder.Entity("CargoManagement.Models.Entity.City", b =>
                {
                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("Citys");
                });

            modelBuilder.Entity("CargoManagement.Models.Entity.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.HasIndex("CityId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CargoManagement.Models.Entity.Employee", b =>
                {
                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<string>("CityId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CityId1")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("EmpId");

                    b.HasIndex("CityId1");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CargoManagement.Models.Entity.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("UnitCost")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CargoManagement.Models.Entity.CargoOrder", b =>
                {
                    b.HasOne("CargoManagement.Models.Entity.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CargoManagement.Models.Entity.CargoOrderDetails", b =>
                {
                    b.HasOne("CargoManagement.Models.Entity.CargoOrder", "CargoOrder")
                        .WithMany()
                        .HasForeignKey("CargoOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CargoManagement.Models.Entity.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CargoOrder");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CargoManagement.Models.Entity.Customer", b =>
                {
                    b.HasOne("CargoManagement.Models.Entity.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("CargoManagement.Models.Entity.Employee", b =>
                {
                    b.HasOne("CargoManagement.Models.Entity.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId1");

                    b.Navigation("City");
                });
#pragma warning restore 612, 618
        }
    }
}
