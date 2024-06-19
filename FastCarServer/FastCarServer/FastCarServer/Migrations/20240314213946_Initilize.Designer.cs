﻿// <auto-generated />
using System;
using FastCarServer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FastCarServer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240314213946_Initilize")]
    partial class Initilize
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FastCarServer.Data.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Cars");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Car");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("FastCarServer.Data.CarAbstract.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("character varying(21)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Category");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("FastCarServer.Data.CarAbstract.Field", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FieldName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("FieldType")
                        .HasColumnType("integer");

                    b.Property<int?>("OptionType")
                        .HasColumnType("integer");

                    b.Property<string>("UnitOfMeasure")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("FastCarServer.Data.CarAbstract.FieldOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("FieldId")
                        .HasColumnType("uuid");

                    b.Property<string>("Option")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FieldId");

                    b.ToTable("FieldOptions");
                });

            modelBuilder.Entity("FastCarServer.Data.CarAbstract.Properties", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CarFieldId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CarId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("FieldId")
                        .HasColumnType("uuid");

                    b.Property<float?>("FloatValue")
                        .HasColumnType("real");

                    b.Property<int?>("IntValue")
                        .HasColumnType("integer");

                    b.Property<string>("StringValue")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("FieldId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("FastCarServer.Data.Passenger.PassengerBodyType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("GenerationId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GenerationId");

                    b.ToTable("PassengerBodyTypes");
                });

            modelBuilder.Entity("FastCarServer.Data.Passenger.PassengerBrand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BrandModelId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BrandModelId");

                    b.ToTable("PassengerBrands");
                });

            modelBuilder.Entity("FastCarServer.Data.Passenger.PassengerBrandModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BrandYearId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BrandYearId");

                    b.ToTable("PassengerBrandModels");
                });

            modelBuilder.Entity("FastCarServer.Data.Passenger.PassengerBrandYear", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BodyTypeId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BodyTypeId");

                    b.ToTable("PassengerBrandYears");
                });

            modelBuilder.Entity("FastCarServer.Data.Passenger.PassengerGeneration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PassengerGenerations");
                });

            modelBuilder.Entity("FastCarServer.Data.User.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<int>("Verification")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("IdentityUser");
                });

            modelBuilder.Entity("FastCarServer.Data.Passenger.PassengerCar", b =>
                {
                    b.HasBaseType("FastCarServer.Data.Car");

                    b.Property<Guid>("BodyTypeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("BrandId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("GenerationId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ModelId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("YearId")
                        .HasColumnType("uuid");

                    b.HasIndex("BodyTypeId");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("GenerationId");

                    b.HasIndex("ModelId");

                    b.HasIndex("YearId");

                    b.HasDiscriminator().HasValue("PassengerCar");
                });

            modelBuilder.Entity("FastCarServer.Data.Passenger.PassengerCategory", b =>
                {
                    b.HasBaseType("FastCarServer.Data.CarAbstract.Category");

                    b.Property<Guid>("BrandId")
                        .HasColumnType("uuid");

                    b.HasIndex("BrandId");

                    b.HasDiscriminator().HasValue("PassengerCategory");
                });

            modelBuilder.Entity("FastCarServer.Data.Car", b =>
                {
                    b.HasOne("FastCarServer.Data.User.User", null)
                        .WithMany("Cars")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FastCarServer.Data.CarAbstract.FieldOption", b =>
                {
                    b.HasOne("FastCarServer.Data.CarAbstract.Field", "Field")
                        .WithMany("FieldOptions")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");
                });

            modelBuilder.Entity("FastCarServer.Data.CarAbstract.Properties", b =>
                {
                    b.HasOne("FastCarServer.Data.Car", null)
                        .WithMany("Properties")
                        .HasForeignKey("CarId");

                    b.HasOne("FastCarServer.Data.CarAbstract.Field", "Field")
                        .WithMany()
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");
                });

            modelBuilder.Entity("FastCarServer.Data.Passenger.PassengerBodyType", b =>
                {
                    b.HasOne("FastCarServer.Data.Passenger.PassengerGeneration", "Generation")
                        .WithMany()
                        .HasForeignKey("GenerationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Generation");
                });

            modelBuilder.Entity("FastCarServer.Data.Passenger.PassengerBrand", b =>
                {
                    b.HasOne("FastCarServer.Data.Passenger.PassengerBrandModel", "BrandModel")
                        .WithMany()
                        .HasForeignKey("BrandModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BrandModel");
                });

            modelBuilder.Entity("FastCarServer.Data.Passenger.PassengerBrandModel", b =>
                {
                    b.HasOne("FastCarServer.Data.Passenger.PassengerBrandYear", "BrandYear")
                        .WithMany()
                        .HasForeignKey("BrandYearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BrandYear");
                });

            modelBuilder.Entity("FastCarServer.Data.Passenger.PassengerBrandYear", b =>
                {
                    b.HasOne("FastCarServer.Data.Passenger.PassengerBodyType", "BodyType")
                        .WithMany()
                        .HasForeignKey("BodyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BodyType");
                });

            modelBuilder.Entity("FastCarServer.Data.User.User", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");

                    b.Navigation("IdentityUser");
                });

            modelBuilder.Entity("FastCarServer.Data.Passenger.PassengerCar", b =>
                {
                    b.HasOne("FastCarServer.Data.Passenger.PassengerBodyType", "BodyType")
                        .WithMany()
                        .HasForeignKey("BodyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastCarServer.Data.Passenger.PassengerBrand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastCarServer.Data.Passenger.PassengerCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastCarServer.Data.Passenger.PassengerGeneration", "Generation")
                        .WithMany()
                        .HasForeignKey("GenerationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastCarServer.Data.Passenger.PassengerBrandModel", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastCarServer.Data.Passenger.PassengerBrandYear", "Year")
                        .WithMany()
                        .HasForeignKey("YearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BodyType");

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Generation");

                    b.Navigation("Model");

                    b.Navigation("Year");
                });

            modelBuilder.Entity("FastCarServer.Data.Passenger.PassengerCategory", b =>
                {
                    b.HasOne("FastCarServer.Data.Passenger.PassengerBrand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("FastCarServer.Data.Car", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("FastCarServer.Data.CarAbstract.Field", b =>
                {
                    b.Navigation("FieldOptions");
                });

            modelBuilder.Entity("FastCarServer.Data.User.User", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
