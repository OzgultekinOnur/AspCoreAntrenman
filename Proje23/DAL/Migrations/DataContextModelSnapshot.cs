﻿// <auto-generated />
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Entities.Concrete.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Q1Correct1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Q2Correct2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Q3Correct3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Q4Correct4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question1Answers1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question1Answers2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question1Answers3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question1Answers4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question2Answers1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question2Answers2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question2Answers3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question2Answers4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question3Answers1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question3Answers2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question3Answers3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question3Answers4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question4Answers1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question4Answers2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question4Answers3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question4Answers4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text2")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserModelId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserModelId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("Entities.Concrete.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserModels");
                });

            modelBuilder.Entity("Entities.Concrete.Exam", b =>
                {
                    b.HasOne("Entities.Concrete.UserModel", "UserModel")
                        .WithMany("Exams")
                        .HasForeignKey("UserModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("Entities.Concrete.UserModel", b =>
                {
                    b.Navigation("Exams");
                });
#pragma warning restore 612, 618
        }
    }
}
