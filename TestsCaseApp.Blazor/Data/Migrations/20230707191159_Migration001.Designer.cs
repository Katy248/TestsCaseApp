﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestsCaseApp.Blazor.Data;

#nullable disable

namespace TestsCaseApp.Blazor.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230707191159_Migration001")]
    partial class Migration001
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("TestsCaseApp.Blazor.Models.TestCase", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Precondition")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RequiredResult")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TestCases");
                });

            modelBuilder.Entity("TestsCaseApp.Blazor.Models.TestCaseResult", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Success")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TestCaseId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TestCaseId")
                        .IsUnique();

                    b.ToTable("TestCaseResults");
                });

            modelBuilder.Entity("TestsCaseApp.Blazor.Models.TestCaseStep", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TestCaseId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TestCaseId");

                    b.ToTable("TestCaseSteps");
                });

            modelBuilder.Entity("TestsCaseApp.Blazor.Models.TestCaseResult", b =>
                {
                    b.HasOne("TestsCaseApp.Blazor.Models.TestCase", "TestCase")
                        .WithOne("Result")
                        .HasForeignKey("TestsCaseApp.Blazor.Models.TestCaseResult", "TestCaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TestCase");
                });

            modelBuilder.Entity("TestsCaseApp.Blazor.Models.TestCaseStep", b =>
                {
                    b.HasOne("TestsCaseApp.Blazor.Models.TestCase", "TestCase")
                        .WithMany("Steps")
                        .HasForeignKey("TestCaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TestCase");
                });

            modelBuilder.Entity("TestsCaseApp.Blazor.Models.TestCase", b =>
                {
                    b.Navigation("Result");

                    b.Navigation("Steps");
                });
#pragma warning restore 612, 618
        }
    }
}
