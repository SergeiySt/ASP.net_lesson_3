﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using db_and_news.Models;

#nullable disable

namespace db_and_news.Migrations
{
    [DbContext(typeof(ADbContext))]
    partial class ADbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("db_and_news.Models.User", b =>
                {
                    b.Property<int>("id_users")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_users"));

                    b.Property<DateTime>("SDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SPhone")
                        .HasColumnType("int");

                    b.HasKey("id_users");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
