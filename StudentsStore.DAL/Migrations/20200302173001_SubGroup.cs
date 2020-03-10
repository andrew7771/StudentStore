using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentStore.DAL.Migrations
{
    public partial class SubGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            
            migrationBuilder.AddColumn<string>(
                name: "SubjectName",
                table: "Subjects",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SubjectGroup",
                columns: table => new
                {
                    GroupId = table.Column<string>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectGroup", x => new { x.SubjectId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_SubjectGroup_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectGroup_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubjectGroup_GroupId",
                table: "SubjectGroup",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubjectGroup");

            migrationBuilder.DropColumn(
                name: "SubjectName",
                table: "Subjects");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Subjects",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
