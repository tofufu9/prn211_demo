﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using prn211_demo.DB;

namespace prn211_demo.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20211012012906_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("prn211_demo.Models.Customer", b =>
                {
                    b.Property<string>("cus_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("cus_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("cus_birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("cus_gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cus_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cus_id");

                    b.ToTable("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
