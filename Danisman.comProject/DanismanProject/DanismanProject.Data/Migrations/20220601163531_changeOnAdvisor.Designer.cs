﻿// <auto-generated />
using System;
using DanismanProject.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DanismanProject.Data.Migrations
{
    [DbContext(typeof(DanismanContext))]
    [Migration("20220601163531_changeOnAdvisor")]
    partial class changeOnAdvisor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("DanismanProject.Entity.Advisor", b =>
                {
                    b.Property<int>("AdvisorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AdvisorAbout")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AdvisorDateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdvisorImg")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdvisorMail")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdvisorName")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdvisorPhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdvisorSurname")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSuitable")
                        .HasColumnType("INTEGER");

                    b.Property<int>("JobId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SuccessRate")
                        .HasColumnType("INTEGER");

                    b.HasKey("AdvisorId");

                    b.HasIndex("JobId");

                    b.ToTable("Advisors");
                });

            modelBuilder.Entity("DanismanProject.Entity.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DanismanProject.Entity.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("JobImg")
                        .HasColumnType("TEXT");

                    b.Property<string>("JobName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("JobId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("DanismanProject.Entity.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("MessageDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("MessageDetails")
                        .HasColumnType("TEXT");

                    b.Property<bool>("MessageStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Receiver")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sender")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.HasKey("MessageId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("DanismanProject.Entity.Advisor", b =>
                {
                    b.HasOne("DanismanProject.Entity.Job", "Job")
                        .WithMany("Advisors")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");
                });

            modelBuilder.Entity("DanismanProject.Entity.Job", b =>
                {
                    b.Navigation("Advisors");
                });
#pragma warning restore 612, 618
        }
    }
}
