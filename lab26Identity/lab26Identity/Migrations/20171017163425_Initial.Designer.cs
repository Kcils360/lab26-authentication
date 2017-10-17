﻿// <auto-generated />
using lab26Identity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace lab26Identity.Migrations
{
    [DbContext(typeof(lab26IdentityContext))]
    [Migration("20171017163425_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("lab26Identity.Models.CMS", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<string>("Dish");

                    b.Property<string>("Ingredients");

                    b.Property<bool>("IsPublished");

                    b.Property<string>("Recipe");

                    b.HasKey("ID");

                    b.ToTable("CMS");
                });
#pragma warning restore 612, 618
        }
    }
}