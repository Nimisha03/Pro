﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Outlet.Demo.DataServices.Data.context;

namespace Outlet.Demo.DataServices.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Outlet.Demo.DataServices.Data.Entities.Admin", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("user_id")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("PassWord")
                        .HasColumnType("text")
                        .HasColumnName("pass_word");

                    b.Property<string>("UserName")
                        .HasColumnType("text")
                        .HasColumnName("user_name");

                    b.HasKey("UserId")
                        .HasName("pk_admins");

                    b.ToTable("admins");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            PassWord = "san",
                            UserName = "Nimisha"
                        });
                });

            modelBuilder.Entity("Outlet.Demo.DataServices.Data.Entities.Outlet1", b =>
                {
                    b.Property<int>("OutletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("outlet_id")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date");

                    b.Property<string>("FoodType")
                        .HasColumnType("text")
                        .HasColumnName("food_type");

                    b.Property<string>("Landmark")
                        .HasColumnType("text")
                        .HasColumnName("landmark");

                    b.Property<int>("NoOfPackets")
                        .HasColumnType("integer")
                        .HasColumnName("no_of_packets");

                    b.Property<int>("NoOfVolunteers")
                        .HasColumnType("integer")
                        .HasColumnName("no_of_volunteers");

                    b.Property<string>("OutletName")
                        .HasColumnType("text")
                        .HasColumnName("outlet_name");

                    b.Property<string>("StreetName")
                        .HasColumnType("text")
                        .HasColumnName("street_name");

                    b.HasKey("OutletId")
                        .HasName("pk_outlets");

                    b.ToTable("outlets");
                });

            modelBuilder.Entity("Outlet.Demo.DataServices.Data.Entities.Volunteer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Location")
                        .HasColumnType("text")
                        .HasColumnName("location");

                    b.Property<string>("VolunteerName")
                        .HasColumnType("text")
                        .HasColumnName("volunteer_name");

                    b.Property<int>("VolunteerOutletId")
                        .HasColumnType("integer")
                        .HasColumnName("volunteer_outlet_id");

                    b.HasKey("Id")
                        .HasName("pk_volunteers");

                    b.HasIndex("VolunteerOutletId")
                        .HasDatabaseName("ix_volunteers_volunteer_outlet_id");

                    b.ToTable("volunteers");
                });

            modelBuilder.Entity("Outlet.Demo.DataServices.Data.Entities.Volunteer", b =>
                {
                    b.HasOne("Outlet.Demo.DataServices.Data.Entities.Outlet1", "OutletI")
                        .WithMany()
                        .HasForeignKey("VolunteerOutletId")
                        .HasConstraintName("fk_volunteers_outlets_volunteer_outlet_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OutletI");
                });
#pragma warning restore 612, 618
        }
    }
}
