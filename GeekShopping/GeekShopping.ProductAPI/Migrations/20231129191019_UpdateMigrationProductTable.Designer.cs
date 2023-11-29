﻿// <auto-generated />
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    [DbContext(typeof(MySqlContext))]
    [Migration("20231129191019_UpdateMigrationProductTable")]
    partial class UpdateMigrationProductTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GeekShopping.ProductAPI.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<decimal>("CategoryName")
                        .HasMaxLength(300)
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("category");

                    b.Property<int>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("int")
                        .HasColumnName("description");

                    b.Property<decimal>("Image_Url")
                        .HasMaxLength(500)
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("image_url");

                    b.Property<int>("Name")
                        .HasMaxLength(150)
                        .HasColumnType("int")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("product");
                });
#pragma warning restore 612, 618
        }
    }
}
