﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StreetwearStore.Data;

namespace StreetwearStore.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200929191541_addedSizesData")]
    partial class addedSizesData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StreetwearStore.Data.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 650, DateTimeKind.Utc).AddTicks(6814),
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nike"
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 650, DateTimeKind.Utc).AddTicks(6859),
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Adidas"
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 650, DateTimeKind.Utc).AddTicks(6862),
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Air Jordan"
                        },
                        new
                        {
                            Id = 4,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 650, DateTimeKind.Utc).AddTicks(6864),
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Alexander McQueen"
                        },
                        new
                        {
                            Id = 5,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 650, DateTimeKind.Utc).AddTicks(6865),
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Supreme"
                        },
                        new
                        {
                            Id = 6,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 650, DateTimeKind.Utc).AddTicks(6867),
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dior"
                        },
                        new
                        {
                            Id = 7,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 650, DateTimeKind.Utc).AddTicks(6869),
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Off-White"
                        },
                        new
                        {
                            Id = 8,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 650, DateTimeKind.Utc).AddTicks(6871),
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Yeezy"
                        },
                        new
                        {
                            Id = 9,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 650, DateTimeKind.Utc).AddTicks(6873),
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Puma"
                        },
                        new
                        {
                            Id = 10,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 650, DateTimeKind.Utc).AddTicks(6874),
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Palm Angels"
                        });
                });

            modelBuilder.Entity("StreetwearStore.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("StreetwearStore.Data.Entities.Collection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayCols")
                        .HasColumnType("int");

                    b.Property<int>("DisplayPositionIndex")
                        .HasColumnType("int");

                    b.Property<int>("DisplayRows")
                        .HasColumnType("int");

                    b.Property<bool>("HomeDisplay")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("StreetwearStore.Data.Entities.Listing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Condition")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SizeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SizeId");

                    b.ToTable("Listings");
                });

            modelBuilder.Entity("StreetwearStore.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Colorway")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("StreetwearStore.Data.Entities.ProductCollection", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CollectionId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CollectionId");

                    b.HasIndex("CollectionId");

                    b.ToTable("ProductCollections");
                });

            modelBuilder.Entity("StreetwearStore.Data.Entities.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("StreetwearStore.Data.Entities.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CM")
                        .HasColumnType("float");

                    b.Property<int>("ClothSize")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<double>("EU")
                        .HasColumnType("float");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<double>("Inches")
                        .HasColumnType("float");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<double>("UK")
                        .HasColumnType("float");

                    b.Property<double>("US")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CM = 0.0,
                            ClothSize = 0,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 648, DateTimeKind.Utc).AddTicks(9477),
                            EU = 38.5,
                            Gender = 0,
                            Inches = 0.0,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UK = 5.5,
                            US = 6.0
                        },
                        new
                        {
                            Id = 2,
                            CM = 0.0,
                            ClothSize = 0,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(204),
                            EU = 39.0,
                            Gender = 0,
                            Inches = 0.0,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UK = 6.0,
                            US = 6.5
                        },
                        new
                        {
                            Id = 3,
                            CM = 0.0,
                            ClothSize = 0,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(227),
                            EU = 40.5,
                            Gender = 0,
                            Inches = 0.0,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UK = 6.5,
                            US = 7.5
                        },
                        new
                        {
                            Id = 4,
                            CM = 0.0,
                            ClothSize = 0,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(229),
                            EU = 41.0,
                            Gender = 0,
                            Inches = 0.0,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UK = 7.0,
                            US = 8.0
                        },
                        new
                        {
                            Id = 5,
                            CM = 0.0,
                            ClothSize = 0,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(230),
                            EU = 42.0,
                            Gender = 0,
                            Inches = 0.0,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UK = 7.5,
                            US = 8.5
                        },
                        new
                        {
                            Id = 6,
                            CM = 0.0,
                            ClothSize = 0,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(232),
                            EU = 42.5,
                            Gender = 0,
                            Inches = 0.0,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UK = 8.0,
                            US = 9.0
                        },
                        new
                        {
                            Id = 7,
                            CM = 0.0,
                            ClothSize = 0,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(234),
                            EU = 43.0,
                            Gender = 0,
                            Inches = 0.0,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UK = 8.5,
                            US = 9.5
                        },
                        new
                        {
                            Id = 8,
                            CM = 0.0,
                            ClothSize = 0,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(236),
                            EU = 44.0,
                            Gender = 0,
                            Inches = 0.0,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UK = 9.0,
                            US = 10.0
                        },
                        new
                        {
                            Id = 9,
                            CM = 0.0,
                            ClothSize = 0,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(238),
                            EU = 44.5,
                            Gender = 0,
                            Inches = 0.0,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UK = 9.5,
                            US = 10.5
                        },
                        new
                        {
                            Id = 10,
                            CM = 0.0,
                            ClothSize = 0,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(239),
                            EU = 45.0,
                            Gender = 0,
                            Inches = 0.0,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UK = 10.0,
                            US = 11.0
                        },
                        new
                        {
                            Id = 11,
                            CM = 0.0,
                            ClothSize = 0,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(241),
                            EU = 45.5,
                            Gender = 0,
                            Inches = 0.0,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UK = 10.5,
                            US = 11.5
                        },
                        new
                        {
                            Id = 12,
                            CM = 0.0,
                            ClothSize = 0,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(243),
                            EU = 46.0,
                            Gender = 0,
                            Inches = 0.0,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UK = 11.0,
                            US = 12.0
                        },
                        new
                        {
                            Id = 13,
                            CM = 0.0,
                            ClothSize = 0,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(245),
                            EU = 47.0,
                            Gender = 0,
                            Inches = 0.0,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UK = 11.5,
                            US = 12.5
                        },
                        new
                        {
                            Id = 14,
                            CM = 0.0,
                            ClothSize = 0,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(247),
                            EU = 47.5,
                            Gender = 0,
                            Inches = 0.0,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UK = 12.0,
                            US = 13.0
                        },
                        new
                        {
                            Id = 15,
                            CM = 0.0,
                            ClothSize = 0,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(249),
                            EU = 48.0,
                            Gender = 0,
                            Inches = 0.0,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UK = 12.5,
                            US = 13.5
                        },
                        new
                        {
                            Id = 16,
                            CM = 0.0,
                            ClothSize = 0,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(250),
                            EU = 48.5,
                            Gender = 0,
                            Inches = 0.0,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UK = 13.0,
                            US = 14.0
                        },
                        new
                        {
                            Id = 17,
                            CM = 0.0,
                            ClothSize = 0,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(252),
                            EU = 49.0,
                            Gender = 0,
                            Inches = 0.0,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UK = 13.5,
                            US = 14.5
                        },
                        new
                        {
                            Id = 18,
                            CM = 0.0,
                            ClothSize = 0,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(254),
                            EU = 49.5,
                            Gender = 0,
                            Inches = 0.0,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UK = 14.0,
                            US = 15.0
                        },
                        new
                        {
                            Id = 19,
                            CM = 0.0,
                            ClothSize = 0,
                            CreatedOn = new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(256),
                            EU = 50.5,
                            Gender = 0,
                            Inches = 0.0,
                            IsDeleted = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UK = 15.0,
                            US = 16.0
                        });
                });

            modelBuilder.Entity("StreetwearStore.Data.Entities.Listing", b =>
                {
                    b.HasOne("StreetwearStore.Data.Entities.Product", "Product")
                        .WithMany("Listings")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StreetwearStore.Data.Entities.Size", "Size")
                        .WithMany("Listings")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StreetwearStore.Data.Entities.Product", b =>
                {
                    b.HasOne("StreetwearStore.Data.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StreetwearStore.Data.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("StreetwearStore.Data.Entities.ProductCollection", b =>
                {
                    b.HasOne("StreetwearStore.Data.Entities.Collection", "Collection")
                        .WithMany("CollectionProducts")
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StreetwearStore.Data.Entities.Product", "Product")
                        .WithMany("ProductCollections")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StreetwearStore.Data.Entities.ProductImage", b =>
                {
                    b.HasOne("StreetwearStore.Data.Entities.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
