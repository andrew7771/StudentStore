using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentStore.Migrations
{
    public partial class Updates_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dbo.AttendanceDates_dbo.Subjects_SubjectId",
                table: "AttendanceDates");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.Attendances_dbo.Subjects_SubjectID",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.FreeMarkFieldMaxPoints_dbo.Subjects_SubjectID",
                table: "FreeMarkFieldMaxPoints");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.FreeMarkFields_dbo.Subjects_SubjectID",
                table: "FreeMarkFields");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.GroupSubjects_dbo.Subjects_Subject_SubjectID",
                table: "GroupSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.HomeWorks_dbo.Subjects_SubjectID",
                table: "HomeWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.HWMaxPoints_dbo.Subjects_SubjectID",
                table: "HWMaxPoints");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.LabMaxPoints_dbo.Subjects_SubjectID",
                table: "LabMaxPoints");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.Marks_dbo.Subjects_SubjectID",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.ModuleMaxPoints_dbo.Subjects_SubjectID",
                table: "ModuleMaxPoints");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.Modules_dbo.Subjects_SubjectID",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.OneItemPoints_dbo.Subjects_SubjectId",
                table: "OneItemPoints");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.Subjects_dbo.Students_Student_RecordBookNumberID",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.Subjects_dbo.Teachers_TeacherID",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dbo.Subjects",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Student_RecordBookNumberID",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "SubjectID",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "Student_RecordBookNumberID",
                table: "Subjects");

            migrationBuilder.RenameColumn(
                name: "TeacherID",
                table: "Teachers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TeacherID",
                table: "Subjects",
                newName: "TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherID",
                table: "Subjects",
                newName: "IX_TeacherId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Subjects",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Student_StudentId",
                table: "Subjects",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_dbo.Subjects",
                table: "Subjects",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_StudentId",
                table: "Subjects",
                column: "Student_StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.AttendanceDates_dbo.Subjects_SubjectId",
                table: "AttendanceDates",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.Attendances_dbo.Subjects_SubjectID",
                table: "Attendances",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.FreeMarkFieldMaxPoints_dbo.Subjects_SubjectID",
                table: "FreeMarkFieldMaxPoints",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.FreeMarkFields_dbo.Subjects_SubjectID",
                table: "FreeMarkFields",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.GroupSubjects_dbo.Subjects_Subject_SubjectID",
                table: "GroupSubjects",
                column: "Subject_SubjectID",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.HomeWorks_dbo.Subjects_SubjectID",
                table: "HomeWorks",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.HWMaxPoints_dbo.Subjects_SubjectID",
                table: "HWMaxPoints",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.LabMaxPoints_dbo.Subjects_SubjectID",
                table: "LabMaxPoints",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.Marks_dbo.Subjects_SubjectID",
                table: "Marks",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.ModuleMaxPoints_dbo.Subjects_SubjectID",
                table: "ModuleMaxPoints",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.Modules_dbo.Subjects_SubjectID",
                table: "Modules",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.OneItemPoints_dbo.Subjects_SubjectId",
                table: "OneItemPoints",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Students_Student_StudentId",
                table: "Subjects",
                column: "Student_StudentId",
                principalTable: "Students",
                principalColumn: "RecordBookNumberID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Teachers_TeacherId",
                table: "Subjects",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dbo.AttendanceDates_dbo.Subjects_SubjectId",
                table: "AttendanceDates");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.Attendances_dbo.Subjects_SubjectID",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.FreeMarkFieldMaxPoints_dbo.Subjects_SubjectID",
                table: "FreeMarkFieldMaxPoints");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.FreeMarkFields_dbo.Subjects_SubjectID",
                table: "FreeMarkFields");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.GroupSubjects_dbo.Subjects_Subject_SubjectID",
                table: "GroupSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.HomeWorks_dbo.Subjects_SubjectID",
                table: "HomeWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.HWMaxPoints_dbo.Subjects_SubjectID",
                table: "HWMaxPoints");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.LabMaxPoints_dbo.Subjects_SubjectID",
                table: "LabMaxPoints");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.Marks_dbo.Subjects_SubjectID",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.ModuleMaxPoints_dbo.Subjects_SubjectID",
                table: "ModuleMaxPoints");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.Modules_dbo.Subjects_SubjectID",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.OneItemPoints_dbo.Subjects_SubjectId",
                table: "OneItemPoints");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Students_Student_StudentId",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Teachers_TeacherId",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dbo.Subjects",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Student_StudentId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "Student_StudentId",
                table: "Subjects");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Teachers",
                newName: "TeacherID");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Subjects",
                newName: "TeacherID");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherId",
                table: "Subjects",
                newName: "IX_TeacherID");

            migrationBuilder.AddColumn<int>(
                name: "SubjectID",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Student_RecordBookNumberID",
                table: "Subjects",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_dbo.Subjects",
                table: "Subjects",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_RecordBookNumberID",
                table: "Subjects",
                column: "Student_RecordBookNumberID");

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.AttendanceDates_dbo.Subjects_SubjectId",
                table: "AttendanceDates",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.Attendances_dbo.Subjects_SubjectID",
                table: "Attendances",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.FreeMarkFieldMaxPoints_dbo.Subjects_SubjectID",
                table: "FreeMarkFieldMaxPoints",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.FreeMarkFields_dbo.Subjects_SubjectID",
                table: "FreeMarkFields",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.GroupSubjects_dbo.Subjects_Subject_SubjectID",
                table: "GroupSubjects",
                column: "Subject_SubjectID",
                principalTable: "Subjects",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.HomeWorks_dbo.Subjects_SubjectID",
                table: "HomeWorks",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.HWMaxPoints_dbo.Subjects_SubjectID",
                table: "HWMaxPoints",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.LabMaxPoints_dbo.Subjects_SubjectID",
                table: "LabMaxPoints",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.Marks_dbo.Subjects_SubjectID",
                table: "Marks",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.ModuleMaxPoints_dbo.Subjects_SubjectID",
                table: "ModuleMaxPoints",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.Modules_dbo.Subjects_SubjectID",
                table: "Modules",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.OneItemPoints_dbo.Subjects_SubjectId",
                table: "OneItemPoints",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.Subjects_dbo.Students_Student_RecordBookNumberID",
                table: "Subjects",
                column: "Student_RecordBookNumberID",
                principalTable: "Students",
                principalColumn: "RecordBookNumberID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.Subjects_dbo.Teachers_TeacherID",
                table: "Subjects",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
