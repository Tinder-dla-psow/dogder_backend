﻿// <auto-generated />
using System;
using Adoptooj_backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Adoptooj_backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240220123058_all")]
    partial class all
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Adoptooj_backend.Data.Tables.disease", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("character varying(1500)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.HasKey("id");

                    b.ToTable("Disease");
                });

            modelBuilder.Entity("Adoptooj_backend.Data.Tables.dog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("age")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)");

                    b.Property<int[]>("disease_id")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<int>("dog_shelter_id")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("race")
                        .IsRequired()
                        .HasMaxLength(38)
                        .HasColumnType("character varying(38)");

                    b.HasKey("id");

                    b.ToTable("Dog");
                });

            modelBuilder.Entity("Adoptooj_backend.Data.Tables.dog_shelter", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("apartment_number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<float>("lat")
                        .HasColumnType("real");

                    b.Property<float>("lon")
                        .HasColumnType("real");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("post_code")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("character varying(6)");

                    b.Property<string>("street")
                        .IsRequired()
                        .HasMaxLength(56)
                        .HasColumnType("character varying(56)");

                    b.Property<string>("street_number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.HasKey("id");

                    b.ToTable("Dog_Shelter");
                });

            modelBuilder.Entity("Adoptooj_backend.Data.Tables.pair", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("dog_id")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<string>("user_id")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.HasKey("id");

                    b.ToTable("Pair");
                });

            modelBuilder.Entity("Adoptooj_backend.Data.Tables.refresh_token", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("token")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("userid")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.HasKey("id");

                    b.ToTable("Refresh_Token");
                });

            modelBuilder.Entity("Adoptooj_backend.Data.Tables.role", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<int[]>("right")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.HasKey("id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Adoptooj_backend.Data.Tables.user", b =>
                {
                    b.Property<string>("id")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<DateTime?>("archive_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<bool>("is_active")
                        .HasColumnType("boolean");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<int>("role_id")
                        .HasColumnType("integer");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.HasKey("id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Adoptooj_backend.Data.Tables.user_dog_shelter", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("dog_shelter_id")
                        .HasColumnType("integer");

                    b.Property<string>("user_id")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.HasKey("id");

                    b.ToTable("User_Dog_Shelter");
                });
#pragma warning restore 612, 618
        }
    }
}
