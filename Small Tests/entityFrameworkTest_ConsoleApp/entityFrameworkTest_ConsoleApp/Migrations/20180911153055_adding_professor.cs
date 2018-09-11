using Microsoft.EntityFrameworkCore.Migrations;

namespace entityFrameworkTest_ConsoleApp.Migrations
{
    public partial class adding_professor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfessorID",
                table: "Courses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ProfessorID",
                table: "Courses",
                column: "ProfessorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_People_ProfessorID",
                table: "Courses",
                column: "ProfessorID",
                principalTable: "People",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_People_ProfessorID",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_ProfessorID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ProfessorID",
                table: "Courses");
        }
    }
}
