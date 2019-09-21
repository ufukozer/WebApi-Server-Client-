﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication14;

namespace WebApplication14.Migrations
{
    [DbContext(typeof(XContext))]
    partial class XContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication14.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookName");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("WebApplication14.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookId");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApplication14.Models.User", b =>
                {
                    b.HasOne("WebApplication14.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId");
                });
#pragma warning restore 612, 618
        }
    }
}
