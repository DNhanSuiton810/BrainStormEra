﻿// <auto-generated />
using System;
using BrainStormEra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BrainStormEra.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BrainStormEra.Models.Certificate", b =>
                {
                    b.Property<string>("certificate_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("certificate_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("user_id")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("certificate_id");

                    b.ToTable("Certificate");
                });

            modelBuilder.Entity("BrainStormEra.Models.Chapter", b =>
                {
                    b.Property<string>("chapter_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("chapter_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("chapter_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("chapter_status")
                        .HasColumnType("int");

                    b.Property<string>("course_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("chapter_id");

                    b.ToTable("Chapters");
                });

            modelBuilder.Entity("BrainStormEra.Models.Course", b =>
                {
                    b.Property<string>("course_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("course_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("course_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("course_picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("course_price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("course_status")
                        .HasColumnType("int");

                    b.HasKey("course_id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("BrainStormEra.Models.CourseCategory", b =>
                {
                    b.Property<string>("course_category_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("course_category_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("course_category_id");

                    b.ToTable("courseCategories");
                });

            modelBuilder.Entity("BrainStormEra.Models.CourseCategoryMapping", b =>
                {
                    b.Property<string>("course_category_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("course_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("courseCategoriesMapping");
                });

            modelBuilder.Entity("BrainStormEra.Models.Enrollment", b =>
                {
                    b.Property<string>("enrollment_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("course_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("enrollment_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("enrollment_status")
                        .HasColumnType("int");

                    b.Property<string>("user_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("enrollment_id");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("BrainStormEra.Models.Lesson", b =>
                {
                    b.Property<string>("lesson_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("chapter_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lesson_content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lesson_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lesson_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("lesson_status")
                        .HasColumnType("int");

                    b.Property<int>("lesson_type")
                        .HasColumnType("int");

                    b.HasKey("lesson_id");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("BrainStormEra.Models.Payment", b =>
                {
                    b.Property<string>("payment_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("enrollment_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("payment_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("payment_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("payment_price")
                        .HasColumnType("float");

                    b.Property<string>("payment_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("payment_id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("BrainStormEra.Models.UserAccount", b =>
                {
                    b.Property<string>("user_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("date_of_birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("full_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("user_id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
