﻿// <auto-generated />
using System;
using BasicStoreDemo.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BasicStoreDemo.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230210174055_SeedProducts")]
    partial class SeedProducts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BasicStoreDemo.Models.Product", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<float?>("discountPrice")
                        .HasColumnType("real")
                        .HasColumnName("discount_price");

                    b.Property<string>("imageUrl")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<float>("ratting")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            id = new Guid("7d412c54-3c37-4ef6-a147-ab67dffe006f"),
                            discountPrice = 98f,
                            imageUrl = "First Image URL",
                            name = "First Test Product",
                            price = 120f,
                            ratting = 2f
                        },
                        new
                        {
                            id = new Guid("fea0e837-b292-43a0-a9b5-9332af97db7c"),
                            discountPrice = 599f,
                            imageUrl = "Second Image url",
                            name = "Second Test Product",
                            price = 650f,
                            ratting = 4.3f
                        });
                });

            modelBuilder.Entity("BasicStoreDemo.Models.ProductDescreption", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("productid")
                        .HasColumnType("uuid");

                    b.Property<string>("text")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("productid");

                    b.ToTable("product_descreption");
                });

            modelBuilder.Entity("BasicStoreDemo.Models.ProductDescreption", b =>
                {
                    b.HasOne("BasicStoreDemo.Models.Product", "product")
                        .WithMany("description")
                        .HasForeignKey("productid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("BasicStoreDemo.Models.Product", b =>
                {
                    b.Navigation("description");
                });
#pragma warning restore 612, 618
        }
    }
}
