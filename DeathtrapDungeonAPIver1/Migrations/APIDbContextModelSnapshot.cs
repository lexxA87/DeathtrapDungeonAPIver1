﻿// <auto-generated />
using DeathtrapDungeonAPIver1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DeathtrapDungeonAPIver1.Migrations
{
    [DbContext(typeof(APIDbContext))]
    partial class APIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DeathtrapDungeonAPIver1.Models.Card", b =>
                {
                    b.Property<short>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("SMALLINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("Number"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR");

                    b.Property<string>("GoToNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("Number");

                    b.ToTable("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}