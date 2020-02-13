using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentStore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendanceDates");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "CourseProjectLines");

            migrationBuilder.DropTable(
                name: "CPLineMaxPoints");

            migrationBuilder.DropTable(
                name: "FreeMarkFieldMaxPoints");

            migrationBuilder.DropTable(
                name: "FreeMarkFields");

            migrationBuilder.DropTable(
                name: "GroupSubjects");

            migrationBuilder.DropTable(
                name: "HomeWorks");

            migrationBuilder.DropTable(
                name: "HWMaxPoints");

            migrationBuilder.DropTable(
                name: "LabMaxPoints");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "ModuleMaxPoints");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "OneItemPoints");

            migrationBuilder.DropTable(
                name: "SubjectCPGroups");

            migrationBuilder.DropTable(
                name: "SubjectCPStudents");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "SubjectCPs");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
