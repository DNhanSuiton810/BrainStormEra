using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrainStormEra.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certificate",
                columns: table => new
                {
                    certificate_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    certificate_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificate", x => x.certificate_id);
                });

            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    chapter_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    chapter_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    chapter_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    course_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    chapter_status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.chapter_id);
                });

            migrationBuilder.CreateTable(
                name: "courseCategories",
                columns: table => new
                {
                    course_category_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    course_category_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseCategories", x => x.course_category_id);
                });

            migrationBuilder.CreateTable(
                name: "courseCategoriesMapping",
                columns: table => new
                {
                    course_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    course_category_id = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    course_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    course_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    course_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    course_price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    course_status = table.Column<int>(type: "int", nullable: false),
                    course_picture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.course_id);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    enrollment_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    course_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    enrollment_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    enrollment_status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.enrollment_id);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    lesson_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    lesson_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lesson_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    chapter_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lesson_status = table.Column<int>(type: "int", nullable: false),
                    lesson_type = table.Column<int>(type: "int", nullable: false),
                    lesson_content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.lesson_id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    payment_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    enrollment_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    payment_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    payment_price = table.Column<double>(type: "float", nullable: true),
                    payment_status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    payment_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.payment_id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    user_role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    full_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date_of_birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_picture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.user_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificate");

            migrationBuilder.DropTable(
                name: "Chapters");

            migrationBuilder.DropTable(
                name: "courseCategories");

            migrationBuilder.DropTable(
                name: "courseCategoriesMapping");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
