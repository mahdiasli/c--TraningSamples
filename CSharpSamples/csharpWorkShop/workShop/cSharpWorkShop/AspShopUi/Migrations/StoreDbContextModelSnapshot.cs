﻿// <auto-generated />
using AspShopUi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspShopUi.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AspShopUi.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Mobile",
                            Description = "awsome",
                            Name = "apple 13",
                            Price = 1222220000
                        },
                        new
                        {
                            Id = 2,
                            Category = "Mobile",
                            Description = "good",
                            Name = "galaxy ultra",
                            Price = 22400000
                        },
                        new
                        {
                            Id = 3,
                            Category = "Mobile",
                            Description = "nice",
                            Name = "poco f12",
                            Price = 400000
                        },
                        new
                        {
                            Id = 4,
                            Category = "Mobile",
                            Description = "not bad",
                            Name = "hoawi",
                            Price = 550000
                        },
                        new
                        {
                            Id = 5,
                            Category = "LapTop",
                            Description = "gaming",
                            Name = "rog asus",
                            Price = 240000000
                        },
                        new
                        {
                            Id = 6,
                            Category = "Laptop",
                            Description = "mac book",
                            Name = "apple",
                            Price = 234440000
                        },
                        new
                        {
                            Id = 7,
                            Category = "SmartWatch",
                            Description = "4 inch",
                            Name = "apple",
                            Price = 224232
                        },
                        new
                        {
                            Id = 8,
                            Category = "SmartWatch",
                            Description = "andriod",
                            Name = "galaxyWatch",
                            Price = 233333333
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
