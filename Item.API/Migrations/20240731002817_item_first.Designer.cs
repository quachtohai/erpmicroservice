﻿// <auto-generated />
using Item.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Item.API.Migrations
{
    [DbContext(typeof(ItemContext))]
    [Migration("20240731002817_item_first")]
    partial class item_first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Item.API.Models.MaterialInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MaterialCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MaterialInfos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Aluminum Frame",
                            IsActive = true,
                            MaterialCode = "AluminumFrame",
                            MaterialName = "Aluminum Frame"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Glass Pane",
                            IsActive = true,
                            MaterialCode = "GlassPane",
                            MaterialName = "Glass Pane"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Latch",
                            IsActive = true,
                            MaterialCode = "Latch",
                            MaterialName = "Latch"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
