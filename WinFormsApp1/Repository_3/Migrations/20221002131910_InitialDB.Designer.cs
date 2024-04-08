﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository_3.Models;

namespace Repository_3.Migrations
{
    [DbContext(typeof(BankAccountTypeContext))]
    [Migration("20221002131910_InitialDB")]
    partial class InitialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Repository_3.Models.AccountType", b =>
                {
                    b.Property<string>("TypeId")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("TypeID");

                    b.Property<string>("TypeDesc")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("TypeId")
                        .HasName("PK__AccountT__516F03952CCFFCE5");

                    b.ToTable("AccountTypes");
                });

            modelBuilder.Entity("Repository_3.Models.BankAccount", b =>
                {
                    b.Property<string>("AccountId")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("AccountID");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("BranchName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("OpenDate")
                        .HasColumnType("date");

                    b.Property<string>("TypeId")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("TypeID");

                    b.HasKey("AccountId")
                        .HasName("PK__BankAcco__349DA5860A563DDA");

                    b.HasIndex("TypeId");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("Repository_3.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("UserID");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("UserRole")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Repository_3.Models.BankAccount", b =>
                {
                    b.HasOne("Repository_3.Models.AccountType", "Type")
                        .WithMany("BankAccounts")
                        .HasForeignKey("TypeId")
                        .HasConstraintName("FK__BankAccou__TypeI__286302EC")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Repository_3.Models.AccountType", b =>
                {
                    b.Navigation("BankAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}