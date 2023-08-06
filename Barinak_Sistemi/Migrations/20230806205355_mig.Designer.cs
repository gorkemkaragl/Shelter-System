﻿// <auto-generated />
using Barinak_Sistemi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Barinak_Sistemi.Migrations
{
    [DbContext(typeof(dbContext))]
    [Migration("20230806205355_mig")]
    partial class mig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Barinak_Sistemi.Models.Animal", b =>
                {
                    b.Property<int>("AnimalAge")
                        .HasColumnType("integer");

                    b.Property<string>("AnimalDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AnimalGender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("AnimalId")
                        .HasColumnType("integer");

                    b.Property<string>("AnimalName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AnimalType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.ToTable("Animal");
                });

            modelBuilder.Entity("Barinak_Sistemi.Models.DropAnimal", b =>
                {
                    b.Property<int>("DropAAge")
                        .HasColumnType("integer");

                    b.Property<string>("DropADescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DropAGender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DropAName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DropAType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.ToTable("DropAnimal");
                });

            modelBuilder.Entity("Barinak_Sistemi.Models.ShelterUsers", b =>
                {
                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("reason")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("salary")
                        .HasColumnType("integer");

                    b.Property<string>("shelterGender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("shelterId")
                        .HasColumnType("integer");

                    b.Property<string>("shelterName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("shelterPhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("shelterSurName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.ToTable("ShelterUsers");
                });

            modelBuilder.Entity("Barinak_Sistemi.Models.User", b =>
                {
                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("userEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("userId")
                        .HasColumnType("integer");

                    b.Property<string>("userLastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("userPhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
