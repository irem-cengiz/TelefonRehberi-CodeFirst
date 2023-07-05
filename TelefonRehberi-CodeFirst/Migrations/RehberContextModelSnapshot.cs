﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TelefonRehberi_CodeFirst.Context;

#nullable disable

namespace TelefonRehberi_CodeFirst.Migrations
{
    [DbContext(typeof(RehberContext))]
    partial class RehberContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TelefonRehberi_CodeFirst.Classes.Kisi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kisiler");
                });
#pragma warning restore 612, 618
        }
    }
}