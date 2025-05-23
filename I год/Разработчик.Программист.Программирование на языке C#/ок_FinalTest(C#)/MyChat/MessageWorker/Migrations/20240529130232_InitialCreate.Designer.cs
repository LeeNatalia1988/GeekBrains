﻿// <auto-generated />
using System;
using MessageWorker.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MessageWorker.Migrations
{
    [DbContext(typeof(MessageContext))]
    [Migration("20240529130232_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MessageWorker.DbModels.Message", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("FromUser")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("from_user");

                    b.Property<int>("MessageStatusID")
                        .HasColumnType("integer");

                    b.Property<int>("StatusID")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("text");

                    b.Property<string>("ToUser")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("to_user");

                    b.HasKey("Id")
                        .HasName("messages_pkey");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("MessageStatusID");

                    b.ToTable("messages", (string)null);
                });

            modelBuilder.Entity("MessageWorker.DbModels.MessageStatus", b =>
                {
                    b.Property<int>("MessageStatusID")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("MessageStatusID");

                    b.ToTable("MessageStatus");

                    b.HasData(
                        new
                        {
                            MessageStatusID = 0,
                            Text = "Create"
                        },
                        new
                        {
                            MessageStatusID = 1,
                            Text = "Receive"
                        });
                });

            modelBuilder.Entity("MessageWorker.DbModels.Message", b =>
                {
                    b.HasOne("MessageWorker.DbModels.MessageStatus", "MessageStatus")
                        .WithMany()
                        .HasForeignKey("MessageStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MessageStatus");
                });
#pragma warning restore 612, 618
        }
    }
}
