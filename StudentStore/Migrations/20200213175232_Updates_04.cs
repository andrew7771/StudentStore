using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentStore.Migrations
{
    public partial class Updates_04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dbo.Attendances_dbo.Students_RecordBookNumberID",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.CourseProjectLines_dbo.Students_RecordBookNumberID",
                table: "CourseProjectLines");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.FreeMarkFields_dbo.Students_RecordBookNumberID",
                table: "FreeMarkFields");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.HomeWorks_dbo.Students_RecordBookNumberID",
                table: "HomeWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.Marks_dbo.Students_RecordBookNumberID",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.Modules_dbo.Students_RecordBookNumberID",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.SubjectCPStudents_dbo.Students_Student_StudentId",
                table: "SubjectCPStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Students_Student_StudentId",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dbo.Students",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "RecordBookNumberID",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Students",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dbo.Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.Attendances_dbo.Students_RecordBookNumberID",
                table: "Attendances",
                column: "RecordBookNumberID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.CourseProjectLines_dbo.Students_RecordBookNumberID",
                table: "CourseProjectLines",
                column: "RecordBookNumberID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.FreeMarkFields_dbo.Students_RecordBookNumberID",
                table: "FreeMarkFields",
                column: "RecordBookNumberID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.HomeWorks_dbo.Students_RecordBookNumberID",
                table: "HomeWorks",
                column: "RecordBookNumberID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.Marks_dbo.Students_RecordBookNumberID",
                table: "Marks",
                column: "RecordBookNumberID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.Modules_dbo.Students_RecordBookNumberID",
                table: "Modules",
                column: "RecordBookNumberID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.SubjectCPStudents_dbo.Students_Student_StudentId",
                table: "SubjectCPStudents",
                column: "Student_StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Students_Student_StudentId",
                table: "Subjects",
                column: "Student_StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dbo.Attendances_dbo.Students_RecordBookNumberID",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.CourseProjectLines_dbo.Students_RecordBookNumberID",
                table: "CourseProjectLines");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.FreeMarkFields_dbo.Students_RecordBookNumberID",
                table: "FreeMarkFields");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.HomeWorks_dbo.Students_RecordBookNumberID",
                table: "HomeWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.Marks_dbo.Students_RecordBookNumberID",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.Modules_dbo.Students_RecordBookNumberID",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.SubjectCPStudents_dbo.Students_Student_StudentId",
                table: "SubjectCPStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Students_Student_StudentId",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dbo.Students",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "RecordBookNumberID",
                table: "Students",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dbo.Students",
                table: "Students",
                column: "RecordBookNumberID");

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.Attendances_dbo.Students_RecordBookNumberID",
                table: "Attendances",
                column: "RecordBookNumberID",
                principalTable: "Students",
                principalColumn: "RecordBookNumberID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.CourseProjectLines_dbo.Students_RecordBookNumberID",
                table: "CourseProjectLines",
                column: "RecordBookNumberID",
                principalTable: "Students",
                principalColumn: "RecordBookNumberID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.FreeMarkFields_dbo.Students_RecordBookNumberID",
                table: "FreeMarkFields",
                column: "RecordBookNumberID",
                principalTable: "Students",
                principalColumn: "RecordBookNumberID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.HomeWorks_dbo.Students_RecordBookNumberID",
                table: "HomeWorks",
                column: "RecordBookNumberID",
                principalTable: "Students",
                principalColumn: "RecordBookNumberID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.Marks_dbo.Students_RecordBookNumberID",
                table: "Marks",
                column: "RecordBookNumberID",
                principalTable: "Students",
                principalColumn: "RecordBookNumberID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.Modules_dbo.Students_RecordBookNumberID",
                table: "Modules",
                column: "RecordBookNumberID",
                principalTable: "Students",
                principalColumn: "RecordBookNumberID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.SubjectCPStudents_dbo.Students_Student_StudentId",
                table: "SubjectCPStudents",
                column: "Student_StudentId",
                principalTable: "Students",
                principalColumn: "RecordBookNumberID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Students_Student_StudentId",
                table: "Subjects",
                column: "Student_StudentId",
                principalTable: "Students",
                principalColumn: "RecordBookNumberID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
