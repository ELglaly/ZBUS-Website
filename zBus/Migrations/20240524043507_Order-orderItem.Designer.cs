﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using zBus.Data;

#nullable disable

namespace zBus.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240524043507_Order-orderItem")]
    partial class OrderorderItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeatId"), 1L, 1);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.HasKey("SeatId");

                    b.HasIndex("TripId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("Trip", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TripId"), 1L, 1);

                    b.Property<int>("ArrivalStationID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("BusId")
                        .HasColumnType("int");

                    b.Property<int>("DepartureStationID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("TripPrice")
                        .HasColumnType("float");

                    b.HasKey("TripId");

                    b.HasIndex("ArrivalStationID");

                    b.HasIndex("BusId");

                    b.HasIndex("DepartureStationID");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("TripUser", b =>
                {
                    b.Property<int>("TripsTripId")
                        .HasColumnType("int");

                    b.Property<int>("UsersUser_Id")
                        .HasColumnType("int");

                    b.HasKey("TripsTripId", "UsersUser_Id");

                    b.HasIndex("UsersUser_Id");

                    b.ToTable("TripUser");
                });

            modelBuilder.Entity("zBus.Models.Bus", b =>
                {
                    b.Property<int>("BusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BusId"), 1L, 1);

                    b.Property<bool?>("AirConditioningAvailable")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<string>("BusModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusPicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfSeats")
                        .HasColumnType("int");

                    b.Property<bool?>("RestroomAvailable")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<bool?>("WifiAvailable")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.HasKey("BusId");

                    b.HasIndex("DriverId");

                    b.ToTable("Buses");
                });

            modelBuilder.Entity("zBus.Models.Driver", b =>
                {
                    b.Property<int>("DriverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DriverId"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fisrt_name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ProfilePicturePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearsOfExperience")
                        .HasColumnType("int");

                    b.HasKey("DriverId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("zBus.Models.Station", b =>
                {
                    b.Property<int>("StationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StationId"), 1L, 1);

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StationAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StationCity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StationName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("StationId");

                    b.ToTable("Stations");
                });

            modelBuilder.Entity("zBus.Models.User", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("Admin")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fisrt_name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone_number")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.Property<string>("PhotoPhath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Seat", b =>
                {
                    b.HasOne("Trip", "Trip")
                        .WithMany()
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("Trip", b =>
                {
                    b.HasOne("zBus.Models.Station", "ArrivalStation")
                        .WithMany()
                        .HasForeignKey("ArrivalStationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("zBus.Models.Bus", "Bus")
                        .WithMany()
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("zBus.Models.Station", "DepartureStation")
                        .WithMany()
                        .HasForeignKey("DepartureStationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArrivalStation");

                    b.Navigation("Bus");

                    b.Navigation("DepartureStation");
                });

            modelBuilder.Entity("TripUser", b =>
                {
                    b.HasOne("Trip", null)
                        .WithMany()
                        .HasForeignKey("TripsTripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("zBus.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersUser_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("zBus.Models.Bus", b =>
                {
                    b.HasOne("zBus.Models.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");
                });
#pragma warning restore 612, 618
        }
    }
}
