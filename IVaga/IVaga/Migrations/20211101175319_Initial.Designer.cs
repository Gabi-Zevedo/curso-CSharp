﻿// <auto-generated />
using IVaga.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IVaga.Migrations
{
    [DbContext(typeof(IVagaContext))]
    [Migration("20211101175319_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("IVaga.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Cor")
                        .HasColumnType("text");

                    b.Property<string>("Marca")
                        .HasColumnType("text");

                    b.Property<string>("Modelo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Car");
                });
#pragma warning restore 612, 618
        }
    }
}
