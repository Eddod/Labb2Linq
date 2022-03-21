using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb2Linq.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblCourse",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCourse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblSubject",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblSubject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblTeacher",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Role = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblTeacher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblStudent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblStudent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblStudent_TblCourse_CourseId",
                        column: x => x.CourseId,
                        principalTable: "TblCourse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblCourseSubject",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCourseSubject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblCourseSubject_TblCourse_CourseId",
                        column: x => x.CourseId,
                        principalTable: "TblCourse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblCourseSubject_TblSubject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "TblSubject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblSubjectTeacher",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblSubjectTeacher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblSubjectTeacher_TblSubject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "TblSubject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblSubjectTeacher_TblTeacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "TblTeacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblCourseSubject_CourseId",
                table: "TblCourseSubject",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCourseSubject_SubjectId",
                table: "TblCourseSubject",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TblStudent_CourseId",
                table: "TblStudent",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_TblSubjectTeacher_SubjectId",
                table: "TblSubjectTeacher",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TblSubjectTeacher_TeacherId",
                table: "TblSubjectTeacher",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblCourseSubject");

            migrationBuilder.DropTable(
                name: "TblStudent");

            migrationBuilder.DropTable(
                name: "TblSubjectTeacher");

            migrationBuilder.DropTable(
                name: "TblCourse");

            migrationBuilder.DropTable(
                name: "TblSubject");

            migrationBuilder.DropTable(
                name: "TblTeacher");
        }
    }
}
