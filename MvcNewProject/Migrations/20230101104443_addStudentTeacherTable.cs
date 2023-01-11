using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcNewProject.Migrations
{
    public partial class addStudentTeacherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentModelId",
                table: "CourseModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherModelId",
                table: "CourseModels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StudentModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BatchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Semester = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Result = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeacherModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherModels", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseModels_StudentModelId",
                table: "CourseModels",
                column: "StudentModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseModels_TeacherModelId",
                table: "CourseModels",
                column: "TeacherModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseModels_StudentModels_StudentModelId",
                table: "CourseModels",
                column: "StudentModelId",
                principalTable: "StudentModels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseModels_TeacherModels_TeacherModelId",
                table: "CourseModels",
                column: "TeacherModelId",
                principalTable: "TeacherModels",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseModels_StudentModels_StudentModelId",
                table: "CourseModels");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseModels_TeacherModels_TeacherModelId",
                table: "CourseModels");

            migrationBuilder.DropTable(
                name: "StudentModels");

            migrationBuilder.DropTable(
                name: "TeacherModels");

            migrationBuilder.DropIndex(
                name: "IX_CourseModels_StudentModelId",
                table: "CourseModels");

            migrationBuilder.DropIndex(
                name: "IX_CourseModels_TeacherModelId",
                table: "CourseModels");

            migrationBuilder.DropColumn(
                name: "StudentModelId",
                table: "CourseModels");

            migrationBuilder.DropColumn(
                name: "TeacherModelId",
                table: "CourseModels");
        }
    }
}
