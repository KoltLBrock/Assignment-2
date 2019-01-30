﻿// <auto-generated />
using Assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment_2.Migrations
{
    [DbContext(typeof(ModelContext))]
    partial class ModelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity("Assignment_2.Models.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("projectDescription");

                    b.Property<string>("projectName");

                    b.HasKey("ID");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("Assignment_2.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("userName");

                    b.HasKey("ID");

                    b.ToTable("User");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("Assignment_2.Models.Member", b =>
                {
                    b.HasBaseType("Assignment_2.Models.User");

                    b.Property<string>("skillLevel");

                    b.Property<int>("studentID");

                    b.HasDiscriminator().HasValue("Member");
                });
#pragma warning restore 612, 618
        }
    }
}
