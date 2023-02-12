﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebShop.Data;

#nullable disable

namespace WebShop.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230212183747_ChangingProductDescription")]
    partial class ChangingProductDescription
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "25a6dc8b-a212-4cd8-9b62-efcdea0c7ab1",
                            RoleId = "b054a395-079b-452e-a440-68231c633323"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebShop.Infrastructure.Data.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("37aadfc2-179a-4e6e-a8aa-0f09ce0dc36c"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(617),
                            IsDeleted = false,
                            Name = "Laptops"
                        },
                        new
                        {
                            Id = new Guid("796209de-79b4-4ca5-9b08-f2c4306ff387"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(660),
                            IsDeleted = false,
                            Name = "Computers"
                        },
                        new
                        {
                            Id = new Guid("7858db3b-3299-493a-9d87-3830b4f603bc"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(663),
                            IsDeleted = false,
                            Name = "Accessories"
                        },
                        new
                        {
                            Id = new Guid("0ddb8ef0-0a46-4569-a7a1-9c76fcaee655"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(666),
                            IsDeleted = false,
                            Name = "Smartphone"
                        },
                        new
                        {
                            Id = new Guid("a211c484-8fb5-4f18-a87e-b2e30101fc67"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(668),
                            IsDeleted = false,
                            Name = "Tablets"
                        },
                        new
                        {
                            Id = new Guid("00b8b863-7f19-4eb5-8460-c68417db3496"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(673),
                            IsDeleted = false,
                            Name = "Components"
                        },
                        new
                        {
                            Id = new Guid("56c40de8-294a-453e-82d1-5d055bed3e6b"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(675),
                            IsDeleted = false,
                            Name = "Peripherals"
                        },
                        new
                        {
                            Id = new Guid("109ccb1d-0a98-4f0f-bbd3-23f2d38251e6"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(677),
                            IsDeleted = false,
                            Name = "Game zone"
                        });
                });

            modelBuilder.Entity("WebShop.Infrastructure.Data.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("WebShop.Infrastructure.Data.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MainImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("SubCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WebShop.Infrastructure.Data.Entities.ProductDescription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductDescriptions");
                });

            modelBuilder.Entity("WebShop.Infrastructure.Data.Entities.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "b054a395-079b-452e-a440-68231c633323",
                            ConcurrencyStamp = "5ba53336-0d84-4e75-a25c-19bdf2d87784",
                            CreatedOn = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(839),
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "32644b40-8958-4f7d-a0c1-5eaa91ae497e",
                            ConcurrencyStamp = "61e4b708-ac3d-4b95-a372-63f8de1f603a",
                            CreatedOn = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(847),
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("WebShop.Infrastructure.Data.Entities.SubCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ce674d7b-013b-4efc-a5d1-0951b488ddeb"),
                            CategoryId = new Guid("37aadfc2-179a-4e6e-a8aa-0f09ce0dc36c"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(911),
                            IsDeleted = false,
                            Name = "Laptops"
                        },
                        new
                        {
                            Id = new Guid("dfa0476d-9531-4865-914b-f1551f473129"),
                            CategoryId = new Guid("37aadfc2-179a-4e6e-a8aa-0f09ce0dc36c"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(918),
                            IsDeleted = false,
                            Name = "Gaming Laptops"
                        },
                        new
                        {
                            Id = new Guid("1d38b388-5eb0-4bb3-8279-c18018b36428"),
                            CategoryId = new Guid("796209de-79b4-4ca5-9b08-f2c4306ff387"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(921),
                            IsDeleted = false,
                            Name = "Computers"
                        },
                        new
                        {
                            Id = new Guid("be9e90b4-c00d-451b-94ea-ad1b55d2c9f9"),
                            CategoryId = new Guid("796209de-79b4-4ca5-9b08-f2c4306ff387"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(923),
                            IsDeleted = false,
                            Name = "Gaming Computers"
                        },
                        new
                        {
                            Id = new Guid("c46cd764-c7bb-4f2f-ba25-ac4c110958bb"),
                            CategoryId = new Guid("7858db3b-3299-493a-9d87-3830b4f603bc"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(928),
                            IsDeleted = false,
                            Name = "Laptop Batteries"
                        },
                        new
                        {
                            Id = new Guid("cce85b6f-b9a7-4be4-a0af-73ed8ec18cc7"),
                            CategoryId = new Guid("7858db3b-3299-493a-9d87-3830b4f603bc"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(932),
                            IsDeleted = false,
                            Name = "Laptop Bags"
                        },
                        new
                        {
                            Id = new Guid("1a6b32fb-55f5-4231-a1d7-b5cf564cc715"),
                            CategoryId = new Guid("0ddb8ef0-0a46-4569-a7a1-9c76fcaee655"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(935),
                            IsDeleted = false,
                            Name = "Smartphones"
                        },
                        new
                        {
                            Id = new Guid("9c5285d2-615b-4666-9319-e3817a572ca5"),
                            CategoryId = new Guid("0ddb8ef0-0a46-4569-a7a1-9c76fcaee655"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(938),
                            IsDeleted = false,
                            Name = "Smartphones Apple"
                        },
                        new
                        {
                            Id = new Guid("f0adbb23-4d6a-45b8-8056-1695948c63a4"),
                            CategoryId = new Guid("a211c484-8fb5-4f18-a87e-b2e30101fc67"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(940),
                            IsDeleted = false,
                            Name = "Tablets"
                        },
                        new
                        {
                            Id = new Guid("0e0599a4-2854-451e-bc19-69c5e5a7eca0"),
                            CategoryId = new Guid("a211c484-8fb5-4f18-a87e-b2e30101fc67"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(944),
                            IsDeleted = false,
                            Name = "Graphics Tablets"
                        },
                        new
                        {
                            Id = new Guid("506449d5-e28b-43be-9882-4739211dced9"),
                            CategoryId = new Guid("00b8b863-7f19-4eb5-8460-c68417db3496"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(946),
                            IsDeleted = false,
                            Name = "SSD"
                        },
                        new
                        {
                            Id = new Guid("a7276329-f79a-42e1-a2c3-8aa64fc943bd"),
                            CategoryId = new Guid("00b8b863-7f19-4eb5-8460-c68417db3496"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(949),
                            IsDeleted = false,
                            Name = "HDD"
                        },
                        new
                        {
                            Id = new Guid("42041daf-22b3-40b7-9d8b-a9723518abaf"),
                            CategoryId = new Guid("00b8b863-7f19-4eb5-8460-c68417db3496"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(979),
                            IsDeleted = false,
                            Name = "Computer Processor"
                        },
                        new
                        {
                            Id = new Guid("ed8afc98-25ff-4b22-a934-e5e19c2b405b"),
                            CategoryId = new Guid("00b8b863-7f19-4eb5-8460-c68417db3496"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(982),
                            IsDeleted = false,
                            Name = "Video Card"
                        },
                        new
                        {
                            Id = new Guid("840bee94-6ed7-40ee-a7bc-2fa09c0726c9"),
                            CategoryId = new Guid("00b8b863-7f19-4eb5-8460-c68417db3496"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(985),
                            IsDeleted = false,
                            Name = "Memory"
                        },
                        new
                        {
                            Id = new Guid("b118ffb5-e5ea-4de4-94ed-d399b916087b"),
                            CategoryId = new Guid("56c40de8-294a-453e-82d1-5d055bed3e6b"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(988),
                            IsDeleted = false,
                            Name = "Keyboard"
                        },
                        new
                        {
                            Id = new Guid("e498e56f-d873-405e-b983-dc48e2309b06"),
                            CategoryId = new Guid("56c40de8-294a-453e-82d1-5d055bed3e6b"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(990),
                            IsDeleted = false,
                            Name = "Mause"
                        },
                        new
                        {
                            Id = new Guid("9dfcb19f-3030-43b0-b82e-6f116826f274"),
                            CategoryId = new Guid("56c40de8-294a-453e-82d1-5d055bed3e6b"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(993),
                            IsDeleted = false,
                            Name = "Headphones"
                        },
                        new
                        {
                            Id = new Guid("3c1d177f-f171-4a09-a86d-5ea6f0f818c6"),
                            CategoryId = new Guid("56c40de8-294a-453e-82d1-5d055bed3e6b"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(996),
                            IsDeleted = false,
                            Name = "Web Camera"
                        },
                        new
                        {
                            Id = new Guid("269085b4-e4cc-4dd4-bad0-7eac9fea98ac"),
                            CategoryId = new Guid("56c40de8-294a-453e-82d1-5d055bed3e6b"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(998),
                            IsDeleted = false,
                            Name = "Monitor"
                        },
                        new
                        {
                            Id = new Guid("b262e059-66bc-40ec-8cae-5693a8ae2d90"),
                            CategoryId = new Guid("109ccb1d-0a98-4f0f-bbd3-23f2d38251e6"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(1002),
                            IsDeleted = false,
                            Name = "Gaming Keyboard"
                        },
                        new
                        {
                            Id = new Guid("c28b04e4-255b-4ca7-9110-55eb575fef55"),
                            CategoryId = new Guid("109ccb1d-0a98-4f0f-bbd3-23f2d38251e6"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(1005),
                            IsDeleted = false,
                            Name = "Gaming Mause"
                        },
                        new
                        {
                            Id = new Guid("437b2ac1-88f4-461c-a929-c2194a544950"),
                            CategoryId = new Guid("109ccb1d-0a98-4f0f-bbd3-23f2d38251e6"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(1008),
                            IsDeleted = false,
                            Name = "Gaming Headphones"
                        },
                        new
                        {
                            Id = new Guid("180538ac-f70f-498f-9a83-454ef8a85a73"),
                            CategoryId = new Guid("109ccb1d-0a98-4f0f-bbd3-23f2d38251e6"),
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(1010),
                            IsDeleted = false,
                            Name = "Gaming Monitor"
                        });
                });

            modelBuilder.Entity("WebShop.Infrastructure.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "25a6dc8b-a212-4cd8-9b62-efcdea0c7ab1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d5df93a9-350c-414c-89ab-825be76bc720",
                            CreatedDate = new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(1073),
                            Email = "admin@gmail.bg",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEM+o1oQX8MZQXjoRnC3n/k2fuqr6nWlmyBIwzcRrc8xXkS+BC13kLfsHBAA3nDsFRQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e1ac7b75-6306-459e-bd28-7719eaf8328e",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("WebShop.Infrastructure.Data.Entities.UserProducts", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("UserProducts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("WebShop.Infrastructure.Data.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WebShop.Infrastructure.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebShop.Infrastructure.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("WebShop.Infrastructure.Data.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebShop.Infrastructure.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WebShop.Infrastructure.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebShop.Infrastructure.Data.Entities.Image", b =>
                {
                    b.HasOne("WebShop.Infrastructure.Data.Entities.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebShop.Infrastructure.Data.Entities.Product", b =>
                {
                    b.HasOne("WebShop.Infrastructure.Data.Entities.SubCategory", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("WebShop.Infrastructure.Data.Entities.ProductDescription", b =>
                {
                    b.HasOne("WebShop.Infrastructure.Data.Entities.Product", "Product")
                        .WithMany("ProductDescriptions")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebShop.Infrastructure.Data.Entities.SubCategory", b =>
                {
                    b.HasOne("WebShop.Infrastructure.Data.Entities.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebShop.Infrastructure.Data.Entities.UserProducts", b =>
                {
                    b.HasOne("WebShop.Infrastructure.Data.Entities.Product", "Product")
                        .WithMany("UserProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebShop.Infrastructure.Data.Entities.User", "User")
                        .WithMany("FavoriteProducts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebShop.Infrastructure.Data.Entities.Category", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("WebShop.Infrastructure.Data.Entities.Product", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("ProductDescriptions");

                    b.Navigation("UserProducts");
                });

            modelBuilder.Entity("WebShop.Infrastructure.Data.Entities.SubCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("WebShop.Infrastructure.Data.Entities.User", b =>
                {
                    b.Navigation("FavoriteProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
