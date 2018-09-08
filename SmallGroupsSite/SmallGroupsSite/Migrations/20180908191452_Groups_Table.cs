using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallGroupsSite.Migrations
{
    public partial class Groups_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PersonAddress_PersonID",
                table: "PersonAddress");

            migrationBuilder.CreateIndex(
                name: "IX_PersonAddress_PersonID",
                table: "PersonAddress",
                column: "PersonID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PersonAddress_PersonID",
                table: "PersonAddress");

            migrationBuilder.CreateIndex(
                name: "IX_PersonAddress_PersonID",
                table: "PersonAddress",
                column: "PersonID");
        }
    }
}
