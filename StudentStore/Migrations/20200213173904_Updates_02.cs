using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentStore.Migrations
{
    public partial class Updates_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dbo.CourseProjectLines_dbo.SubjectCPs_SubjectCP_ID",
                table: "CourseProjectLines");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.CPLineMaxPoints_dbo.SubjectCPs_SubjectCP_SubjectCP_ID",
                table: "CPLineMaxPoints");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.SubjectCPGroups_dbo.SubjectCPs_SubjectCP_SubjectCP_ID",
                table: "SubjectCPGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.SubjectCPs_dbo.Teachers_TeacherID",
                table: "SubjectCPs");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.SubjectCPStudents_dbo.Students_Student_RecordBookNumberID",
                table: "SubjectCPStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.SubjectCPStudents_dbo.SubjectCPs_SubjectCP_SubjectCP_ID",
                table: "SubjectCPStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dbo.SubjectCPStudents",
                table: "SubjectCPStudents");

            migrationBuilder.DropIndex(
                name: "IX_Student_RecordBookNumberID",
                table: "SubjectCPStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dbo.SubjectCPs",
                table: "SubjectCPs");

            migrationBuilder.DropColumn(
                name: "Student_RecordBookNumberID",
                table: "SubjectCPStudents");

            migrationBuilder.DropColumn(
                name: "SubjectCP_ID",
                table: "SubjectCPs");

            migrationBuilder.RenameColumn(
                name: "TeacherID",
                table: "SubjectCPs",
                newName: "TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherID",
                table: "SubjectCPs",
                newName: "IX_TeacherId");

            migrationBuilder.AddColumn<string>(
                name: "Student_StudentId",
                table: "SubjectCPStudents",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SubjectCPs",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dbo.SubjectCPStudents",
                table: "SubjectCPStudents",
                columns: new[] { "SubjectCP_SubjectCP_ID", "Student_StudentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_dbo.SubjectCPs",
                table: "SubjectCPs",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_StudentId",
                table: "SubjectCPStudents",
                column: "Student_StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.CourseProjectLines_dbo.SubjectCPs_SubjectCP_ID",
                table: "CourseProjectLines",
                column: "SubjectCP_ID",
                principalTable: "SubjectCPs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.CPLineMaxPoints_dbo.SubjectCPs_SubjectCP_SubjectCP_ID",
                table: "CPLineMaxPoints",
                column: "SubjectCP_SubjectCP_ID",
                principalTable: "SubjectCPs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.SubjectCPGroups_dbo.SubjectCPs_SubjectCP_SubjectCP_ID",
                table: "SubjectCPGroups",
                column: "SubjectCP_SubjectCP_ID",
                principalTable: "SubjectCPs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.SubjectCPs_dbo.Teachers_TeacherId",
                table: "SubjectCPs",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.SubjectCPStudents_dbo.SubjectCPs_SubjectCP_SubjectCP_ID",
                table: "SubjectCPStudents",
                column: "SubjectCP_SubjectCP_ID",
                principalTable: "SubjectCPs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.SubjectCPStudents_dbo.Students_Student_StudentId",
                table: "SubjectCPStudents",
                column: "Student_StudentId",
                principalTable: "Students",
                principalColumn: "RecordBookNumberID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dbo.CourseProjectLines_dbo.SubjectCPs_SubjectCP_ID",
                table: "CourseProjectLines");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.CPLineMaxPoints_dbo.SubjectCPs_SubjectCP_SubjectCP_ID",
                table: "CPLineMaxPoints");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.SubjectCPGroups_dbo.SubjectCPs_SubjectCP_SubjectCP_ID",
                table: "SubjectCPGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.SubjectCPs_dbo.Teachers_TeacherId",
                table: "SubjectCPs");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.SubjectCPStudents_dbo.SubjectCPs_SubjectCP_SubjectCP_ID",
                table: "SubjectCPStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo.SubjectCPStudents_dbo.Students_Student_StudentId",
                table: "SubjectCPStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dbo.SubjectCPStudents",
                table: "SubjectCPStudents");

            migrationBuilder.DropIndex(
                name: "IX_Student_StudentId",
                table: "SubjectCPStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dbo.SubjectCPs",
                table: "SubjectCPs");

            migrationBuilder.DropColumn(
                name: "Student_StudentId",
                table: "SubjectCPStudents");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SubjectCPs");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "SubjectCPs",
                newName: "TeacherID");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherId",
                table: "SubjectCPs",
                newName: "IX_TeacherID");

            migrationBuilder.AddColumn<string>(
                name: "Student_RecordBookNumberID",
                table: "SubjectCPStudents",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SubjectCP_ID",
                table: "SubjectCPs",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dbo.SubjectCPStudents",
                table: "SubjectCPStudents",
                columns: new[] { "SubjectCP_SubjectCP_ID", "Student_RecordBookNumberID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_dbo.SubjectCPs",
                table: "SubjectCPs",
                column: "SubjectCP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_RecordBookNumberID",
                table: "SubjectCPStudents",
                column: "Student_RecordBookNumberID");

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.CourseProjectLines_dbo.SubjectCPs_SubjectCP_ID",
                table: "CourseProjectLines",
                column: "SubjectCP_ID",
                principalTable: "SubjectCPs",
                principalColumn: "SubjectCP_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.CPLineMaxPoints_dbo.SubjectCPs_SubjectCP_SubjectCP_ID",
                table: "CPLineMaxPoints",
                column: "SubjectCP_SubjectCP_ID",
                principalTable: "SubjectCPs",
                principalColumn: "SubjectCP_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.SubjectCPGroups_dbo.SubjectCPs_SubjectCP_SubjectCP_ID",
                table: "SubjectCPGroups",
                column: "SubjectCP_SubjectCP_ID",
                principalTable: "SubjectCPs",
                principalColumn: "SubjectCP_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.SubjectCPs_dbo.Teachers_TeacherID",
                table: "SubjectCPs",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.SubjectCPStudents_dbo.Students_Student_RecordBookNumberID",
                table: "SubjectCPStudents",
                column: "Student_RecordBookNumberID",
                principalTable: "Students",
                principalColumn: "RecordBookNumberID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.SubjectCPStudents_dbo.SubjectCPs_SubjectCP_SubjectCP_ID",
                table: "SubjectCPStudents",
                column: "SubjectCP_SubjectCP_ID",
                principalTable: "SubjectCPs",
                principalColumn: "SubjectCP_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
