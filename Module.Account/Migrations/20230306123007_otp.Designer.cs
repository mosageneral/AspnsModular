﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Module.Account.DL.appDBContext;

namespace Module.Account.Migrations
{
    [DbContext(typeof(AccountAppDbContext))]
    [Migration("20230306123007_otp")]
    partial class otp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Account")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Module.Account.DL.Entities.UserEntites.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescribtionAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescribtionEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpadtedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Module.Account.DL.Entities.UserEntites.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescribtionAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescribtionEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpadtedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Module.Account.DL.Entities.UserEntites.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescribtionAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescribtionEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpadtedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ee58a818-ad49-4819-b208-cb8454b2a518"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = false,
                            IsDeleted = false,
                            NameAr = "صلاحية استخدام الارشيف",
                            NameEn = "Archive",
                            UpadtedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("fa76e0fb-3959-455a-a6ae-0a0f10a00195"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = false,
                            IsDeleted = false,
                            NameAr = "صلاحية المدير",
                            NameEn = "Admin",
                            UpadtedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        });
                });

            modelBuilder.Entity("Module.Account.DL.Entities.UserEntites.PermissionRoles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescribtionAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescribtionEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("PermissionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpadtedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("PermissionRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2933273f-78d0-4d84-abde-3f08728dcef8"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = false,
                            IsDeleted = false,
                            PermissionId = new Guid("ee58a818-ad49-4819-b208-cb8454b2a518"),
                            RoleId = new Guid("ac6c54cc-1f5c-405a-a88b-7c2fbdc9c803"),
                            UpadtedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("a17b2943-1e2c-40d8-862d-7c0543a17130"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = false,
                            IsDeleted = false,
                            PermissionId = new Guid("ee58a818-ad49-4819-b208-cb8454b2a518"),
                            RoleId = new Guid("86e20417-65f0-4e49-9283-1b773e6d3f9e"),
                            UpadtedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("bacffe86-0106-421f-854e-ec3f76941f40"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = false,
                            IsDeleted = false,
                            PermissionId = new Guid("fa76e0fb-3959-455a-a6ae-0a0f10a00195"),
                            RoleId = new Guid("86e20417-65f0-4e49-9283-1b773e6d3f9e"),
                            UpadtedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        });
                });

            modelBuilder.Entity("Module.Account.DL.Entities.UserEntites.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescribtionAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescribtionEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpadtedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("Module.Account.DL.Entities.UserEntites.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescribtionAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescribtionEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpadtedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("86e20417-65f0-4e49-9283-1b773e6d3f9e"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = false,
                            IsDeleted = false,
                            NameAr = "صلاحية المدير",
                            NameEn = "AdminRole",
                            UpadtedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("ac6c54cc-1f5c-405a-a88b-7c2fbdc9c803"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = false,
                            IsDeleted = false,
                            NameAr = "صلاحية مستخدم",
                            NameEn = "BasicRole",
                            UpadtedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        });
                });

            modelBuilder.Entity("Module.Account.DL.Entities.UserEntites.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescribtionAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescribtionEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpadtedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("VendorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("VendorId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("84b83856-7558-48c4-ba37-26ecd65e9318"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Email = "Admin@Admon.com",
                            IsActive = false,
                            IsDeleted = false,
                            Password = "Zmz85diIPmR3ygkO9kNUwQ==",
                            Phone = "123",
                            UpadtedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserName = "Admin",
                            UserType = "Admin"
                        },
                        new
                        {
                            Id = new Guid("8e0c20bd-b8ef-4c70-af20-b05014736118"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Email = "Basic@Basic.com",
                            IsActive = false,
                            IsDeleted = false,
                            Password = "lUB3OZqa9U9DS8HKkO0x5A==",
                            Phone = "123",
                            UpadtedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserName = "Basic",
                            UserType = "Buyer"
                        });
                });

            modelBuilder.Entity("Module.Account.DL.Entities.UserEntites.UserRoles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescribtionAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescribtionEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpadtedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9d1aaca9-5a22-4da6-923b-938c59aef3af"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = false,
                            IsDeleted = false,
                            RoleId = new Guid("ac6c54cc-1f5c-405a-a88b-7c2fbdc9c803"),
                            UpadtedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = new Guid("8e0c20bd-b8ef-4c70-af20-b05014736118")
                        },
                        new
                        {
                            Id = new Guid("b55a8783-9717-4389-9ecb-6c7a22d6c92b"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = false,
                            IsDeleted = false,
                            RoleId = new Guid("ac6c54cc-1f5c-405a-a88b-7c2fbdc9c803"),
                            UpadtedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = new Guid("84b83856-7558-48c4-ba37-26ecd65e9318")
                        },
                        new
                        {
                            Id = new Guid("d7e70561-f21c-423a-a3a3-313255d6f775"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = false,
                            IsDeleted = false,
                            RoleId = new Guid("86e20417-65f0-4e49-9283-1b773e6d3f9e"),
                            UpadtedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = new Guid("84b83856-7558-48c4-ba37-26ecd65e9318")
                        });
                });

            modelBuilder.Entity("Module.Account.DL.Entities.UserEntites.Vendor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescribtionAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescribtionEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpadtedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("VendorType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("Module.Account.DL.Entities.UserEntities.VerfiyCode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescribtionAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescribtionEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpadtedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("VirfeyCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VerfiyCodes");
                });

            modelBuilder.Entity("Module.Account.DL.Entities.UserEntites.City", b =>
                {
                    b.HasOne("Module.Account.DL.Entities.UserEntites.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("Module.Account.DL.Entities.UserEntites.Region", b =>
                {
                    b.HasOne("Module.Account.DL.Entities.UserEntites.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Module.Account.DL.Entities.UserEntites.User", b =>
                {
                    b.HasOne("Module.Account.DL.Entities.UserEntites.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("Module.Account.DL.Entities.UserEntites.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId");

                    b.Navigation("City");

                    b.Navigation("Vendor");
                });
#pragma warning restore 612, 618
        }
    }
}
