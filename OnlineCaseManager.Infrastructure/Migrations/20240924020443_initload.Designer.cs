﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineCaseManager.Infrastructure.Database;

#nullable disable

namespace OnlineCaseManager.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240924020443_initload")]
    partial class initload
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("OnlineCaseManager.Models.Models.Case", b =>
                {
                    b.Property<int>("CaseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CaseID"));

                    b.Property<string>("CaseTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOpened")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("LawyerID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("CaseID");

                    b.HasIndex("ClientID");

                    b.HasIndex("LawyerID");

                    b.HasIndex("UserID");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("OnlineCaseManager.Models.Models.Document", b =>
                {
                    b.Property<int>("DocumentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("DocumentID"));

                    b.Property<int>("CaseID")
                        .HasColumnType("int");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UploadedBy")
                        .HasColumnType("int");

                    b.Property<int>("UploaderUserID")
                        .HasColumnType("int");

                    b.HasKey("DocumentID");

                    b.HasIndex("CaseID");

                    b.HasIndex("UploaderUserID");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("OnlineCaseManager.Models.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("InvoiceID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("InvoiceID");

                    b.HasIndex("ClientID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("OnlineCaseManager.Models.Models.Message", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MessageID"));

                    b.Property<int>("CaseID")
                        .HasColumnType("int");

                    b.Property<string>("MessageText")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ReceiverID")
                        .HasColumnType("int");

                    b.Property<int>("SenderID")
                        .HasColumnType("int");

                    b.Property<DateTime>("SentAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("MessageID");

                    b.HasIndex("CaseID");

                    b.HasIndex("ReceiverID");

                    b.HasIndex("SenderID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("OnlineCaseManager.Models.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("UserID"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OnlineCaseManager.Models.Models.Case", b =>
                {
                    b.HasOne("OnlineCaseManager.Models.Models.User", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OnlineCaseManager.Models.Models.User", "Lawyer")
                        .WithMany()
                        .HasForeignKey("LawyerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OnlineCaseManager.Models.Models.User", null)
                        .WithMany("Cases")
                        .HasForeignKey("UserID");

                    b.Navigation("Client");

                    b.Navigation("Lawyer");
                });

            modelBuilder.Entity("OnlineCaseManager.Models.Models.Document", b =>
                {
                    b.HasOne("OnlineCaseManager.Models.Models.Case", "Case")
                        .WithMany("Documents")
                        .HasForeignKey("CaseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineCaseManager.Models.Models.User", "Uploader")
                        .WithMany()
                        .HasForeignKey("UploaderUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Case");

                    b.Navigation("Uploader");
                });

            modelBuilder.Entity("OnlineCaseManager.Models.Models.Invoice", b =>
                {
                    b.HasOne("OnlineCaseManager.Models.Models.User", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("OnlineCaseManager.Models.Models.Message", b =>
                {
                    b.HasOne("OnlineCaseManager.Models.Models.Case", "Case")
                        .WithMany("Messages")
                        .HasForeignKey("CaseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineCaseManager.Models.Models.User", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineCaseManager.Models.Models.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Case");

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("OnlineCaseManager.Models.Models.Case", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("Messages");
                });

            modelBuilder.Entity("OnlineCaseManager.Models.Models.User", b =>
                {
                    b.Navigation("Cases");
                });
#pragma warning restore 612, 618
        }
    }
}