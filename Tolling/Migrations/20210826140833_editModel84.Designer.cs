﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tolling.Data;

namespace Tolling.Migrations
{
    [DbContext(typeof(Dbcontext))]
    [Migration("20210826140833_editModel84")]
    partial class editModel84
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("PartTool", b =>
                {
                    b.Property<string>("ToolPartPartNumber")
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("ToolPartSerialNumber")
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ToolPartPartNumber", "ToolPartSerialNumber");

                    b.HasIndex("ToolPartSerialNumber");

                    b.ToTable("PartTool");
                });

            modelBuilder.Entity("Tolling.Models.ActionType", b =>
                {
                    b.Property<string>("ActionName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ActionName");

                    b.ToTable("ActionType");
                });

            modelBuilder.Entity("Tolling.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Tolling.Models.LocationDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("LockerId")
                        .HasColumnType("int");

                    b.Property<string>("SerialNumber")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ToolSerialNumber")
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("z")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("LockerId");

                    b.HasIndex("ToolSerialNumber");

                    b.ToTable("LocationDetails");
                });

            modelBuilder.Entity("Tolling.Models.Locker", b =>
                {
                    b.Property<int>("LockerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("LockerName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("LockerId");

                    b.ToTable("Locker");
                });

            modelBuilder.Entity("Tolling.Models.Part", b =>
                {
                    b.Property<string>("PartNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Description")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("PartNumber");

                    b.ToTable("Part");
                });

            modelBuilder.Entity("Tolling.Models.Role", b =>
                {
                    b.Property<string>("RoleName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("RoleName");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Tolling.Models.Tool", b =>
                {
                    b.Property<string>("SerialNumber")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<int>("NoOfCavities")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReciviedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ToolOwner")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("SerialNumber");

                    b.ToTable("Tool");
                });

            modelBuilder.Entity("Tolling.Models.ToolPart", b =>
                {
                    b.Property<string>("SerialNumber")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PartNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("SerialNumber", "PartNumber");

                    b.HasIndex("PartNumber");

                    b.ToTable("ToolPart");
                });

            modelBuilder.Entity("Tolling.Models.Tooling_Movement_Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ActionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ActionTakenAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ActionTypeActionName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActionTypeActionName");

                    b.HasIndex("LocationId");

                    b.HasIndex("SerialNumber");

                    b.HasIndex("UserId");

                    b.ToTable("Tooling_Movement_Log");
                });

            modelBuilder.Entity("Tolling.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Admin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("RoleName");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PartTool", b =>
                {
                    b.HasOne("Tolling.Models.Part", null)
                        .WithMany()
                        .HasForeignKey("ToolPartPartNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tolling.Models.Tool", null)
                        .WithMany()
                        .HasForeignKey("ToolPartSerialNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Tolling.Models.LocationDetails", b =>
                {
                    b.HasOne("Tolling.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tolling.Models.Locker", "Locker")
                        .WithMany()
                        .HasForeignKey("LockerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tolling.Models.Tool", "Tool")
                        .WithMany()
                        .HasForeignKey("ToolSerialNumber");

                    b.Navigation("Location");

                    b.Navigation("Locker");

                    b.Navigation("Tool");
                });

            modelBuilder.Entity("Tolling.Models.ToolPart", b =>
                {
                    b.HasOne("Tolling.Models.Part", "Part")
                        .WithMany()
                        .HasForeignKey("PartNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tolling.Models.Tool", "Tool")
                        .WithMany()
                        .HasForeignKey("SerialNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Part");

                    b.Navigation("Tool");
                });

            modelBuilder.Entity("Tolling.Models.Tooling_Movement_Log", b =>
                {
                    b.HasOne("Tolling.Models.ActionType", "ActionType")
                        .WithMany()
                        .HasForeignKey("ActionTypeActionName");

                    b.HasOne("Tolling.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tolling.Models.Tool", "Tool")
                        .WithMany()
                        .HasForeignKey("SerialNumber");

                    b.HasOne("Tolling.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActionType");

                    b.Navigation("Location");

                    b.Navigation("Tool");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Tolling.Models.User", b =>
                {
                    b.HasOne("Tolling.Models.Role", "Role")
                        .WithMany("User")
                        .HasForeignKey("RoleName");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Tolling.Models.Role", b =>
                {
                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
