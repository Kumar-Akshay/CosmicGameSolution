﻿// <auto-generated />
using System;
using CosmicGameAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CosmicGameAPI.Migrations
{
    [DbContext(typeof(CosmicDbContext))]
    [Migration("20220519154305_fourth-migration")]
    partial class fourthmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CosmicGameAPI.Entities.BhavaPlanet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Bhavalst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ChartHolderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Palenetlst")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("BhavaPlanets");
                });

            modelBuilder.Entity("CosmicGameAPI.Entities.ChartHolder", b =>
                {
                    b.Property<int>("ChartHolderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChartHolderId"), 1L, 1);

                    b.Property<string>("Ayanamasa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AyanamasaPolicy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthTimeRectified")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChildName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LatLocator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LngLocator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("TimeZone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ChartHolderId");

                    b.ToTable("ChartHolders");
                });

            modelBuilder.Entity("CosmicGameAPI.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ActualTimeZone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AreasCovered")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountOfTimeZone")
                        .HasColumnType("int");

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DSTFromTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DSTToTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("IsDST")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("NameOfTimeZone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeZoneValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalTimeZone")
                        .HasColumnType("int");

                    b.Property<string>("YearFrom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("CosmicGameAPI.Entities.CurrentAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Country")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("IsActive")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("LatLocator")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Latitude")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LngLocator")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Longitude")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("State")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TimeZone")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CurrentAddresses");
                });

            modelBuilder.Entity("CosmicGameAPI.Entities.ErrorLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ErrorLogs");
                });

            modelBuilder.Entity("CosmicGameAPI.Entities.U_Lev4_S4SL_Register", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("DMS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ext_Line")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("KC_INDEX")
                        .HasColumnType("float");

                    b.Property<string>("KC_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KC_Rasi_Lord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KC_Rasi_Lord_SPL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("LineNo")
                        .HasColumnType("float");

                    b.Property<string>("S1SL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("S1SLCount")
                        .HasColumnType("float");

                    b.Property<string>("S2SL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("S2SLCount")
                        .HasColumnType("float");

                    b.Property<string>("S3SL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("S3SLCount")
                        .HasColumnType("float");

                    b.Property<string>("S4SL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("S4SLCount")
                        .HasColumnType("float");

                    b.Property<double?>("S4SL_ArcDist")
                        .HasColumnType("float");

                    b.Property<double?>("StarCount")
                        .HasColumnType("float");

                    b.Property<string>("StarLord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StarName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("VimsoPeriod")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("u_Lev4_S4SL_Registers");
                });

            modelBuilder.Entity("CosmicGameAPI.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("FullName")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<decimal>("IsActive")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("IsAllowMultipelLogin")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("IsApproved")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("IsDelete")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Mobile")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Password")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("UserName")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CosmicGameAPI.Entities.UserLoginInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Browser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("IpAddress")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("IsLogin")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("LastLoginDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LoginType")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserLoginInfos");
                });

            modelBuilder.Entity("CosmicGameAPI.Entities.VimsoMasterRegister", b =>
                {
                    b.Property<int>("LineNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LineNo"), 1L, 1);

                    b.Property<int>("An_Gp")
                        .HasColumnType("int");

                    b.Property<string>("DMS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Di_Gp")
                        .HasColumnType("int");

                    b.Property<double>("Moving_Distance")
                        .HasColumnType("float");

                    b.Property<int>("Pu_Gp")
                        .HasColumnType("int");

                    b.Property<string>("Rasi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rasi_L")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rasi_id")
                        .HasColumnType("int");

                    b.Property<string>("S1SL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S2SL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S3SL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S4SL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("S4SL_ArcDist")
                        .HasColumnType("float");

                    b.Property<int>("So_Gp")
                        .HasColumnType("int");

                    b.Property<string>("StarLord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StarName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Star_id")
                        .HasColumnType("int");

                    b.Property<int>("Vimso_pd")
                        .HasColumnType("int");

                    b.HasKey("LineNo");

                    b.ToTable("VimsoMasterRegisters");
                });
#pragma warning restore 612, 618
        }
    }
}
