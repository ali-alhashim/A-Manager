﻿// <auto-generated />
using System;
using A_Manager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace A_Manager.Migrations
{
    [DbContext(typeof(DatabaseConnectionClass))]
    partial class DatabaseConnectionClassModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("A_Manager.Models.Car", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("back_photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("body_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("door_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("front_photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fuel_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("hajri_inspection_expiration")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("hajri_registration_license_expiration")
                        .HasColumnType("datetime2");

                    b.Property<bool>("has_fuel_chip")
                        .HasColumnType("bit");

                    b.Property<bool>("has_gps")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("inspection_expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("left_photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("owner_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("owner_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("plate_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("purchase_price")
                        .HasColumnType("float");

                    b.Property<DateTime?>("registration_license_expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("right_photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("seats_number")
                        .HasColumnType("int");

                    b.Property<string>("serial_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vehicle_identification_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("year_of_make")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Car", (string)null);
                });

            modelBuilder.Entity("A_Manager.Models.Car_Insurance", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("carID")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime2");

                    b.Property<double>("excess_amount")
                        .HasColumnType("float");

                    b.Property<string>("insurance_area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("insurance_class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("insurance_cost")
                        .HasColumnType("float");

                    b.Property<DateTime>("insurance_end")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("insurance_start")
                        .HasColumnType("datetime2");

                    b.Property<bool>("insure_accessories")
                        .HasColumnType("bit");

                    b.Property<double>("insured_value")
                        .HasColumnType("float");

                    b.Property<DateTime>("last_update")
                        .HasColumnType("datetime2");

                    b.Property<string>("policy_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("repair_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("carID");

                    b.ToTable("Car_Insurance", (string)null);
                });

            modelBuilder.Entity("A_Manager.Models.Car_Service", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("carID")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("last_update")
                        .HasColumnType("datetime2");

                    b.Property<string>("odometer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("service_cost")
                        .HasColumnType("float");

                    b.Property<DateTime>("service_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("workshop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("carID");

                    b.ToTable("Car_Service", (string)null);
                });

            modelBuilder.Entity("A_Manager.Models.Car_Users", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime?>("authorize_end_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("authorize_start_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("authorize_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("carID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("created_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("handover_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("last_update")
                        .HasColumnType("datetime2");

                    b.Property<string>("note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("odometer_after")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("odometer_before")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("odometer_unit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("received_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("carID");

                    b.HasIndex("userID");

                    b.ToTable("Car_Users", (string)null);
                });

            modelBuilder.Entity("A_Manager.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("Carid")
                        .HasColumnType("int");

                    b.Property<string>("badge_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("brith_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("full_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gov_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("is_employee")
                        .HasColumnType("bit");

                    b.Property<bool>("is_superuser")
                        .HasColumnType("bit");

                    b.Property<string>("job_title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("join_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("local_full_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("profile_photo_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telphone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Carid");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("A_Manager.Models.Car_Insurance", b =>
                {
                    b.HasOne("A_Manager.Models.Car", "car")
                        .WithMany()
                        .HasForeignKey("carID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("car");
                });

            modelBuilder.Entity("A_Manager.Models.Car_Service", b =>
                {
                    b.HasOne("A_Manager.Models.Car", "car")
                        .WithMany()
                        .HasForeignKey("carID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("car");
                });

            modelBuilder.Entity("A_Manager.Models.Car_Users", b =>
                {
                    b.HasOne("A_Manager.Models.Car", "car")
                        .WithMany()
                        .HasForeignKey("carID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A_Manager.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("car");

                    b.Navigation("user");
                });

            modelBuilder.Entity("A_Manager.Models.User", b =>
                {
                    b.HasOne("A_Manager.Models.Car", null)
                        .WithMany("drivers")
                        .HasForeignKey("Carid");
                });

            modelBuilder.Entity("A_Manager.Models.Car", b =>
                {
                    b.Navigation("drivers");
                });
#pragma warning restore 612, 618
        }
    }
}
