using Microsoft.EntityFrameworkCore.Migrations;

namespace entityFrameworkTest_ConsoleApp.Migrations
{
    public partial class update_address_relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonAddress_People_PersonID",
                table: "PersonAddress");

            migrationBuilder.DropIndex(
                name: "IX_PersonAddress_PersonID",
                table: "PersonAddress");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "PersonAddress");

            migrationBuilder.AddColumn<int>(
                name: "PersonAddressID",
                table: "People",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_PersonAddressID",
                table: "People",
                column: "PersonAddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_People_PersonAddress_PersonAddressID",
                table: "People",
                column: "PersonAddressID",
                principalTable: "PersonAddress",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_PersonAddress_PersonAddressID",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_PersonAddressID",
                table: "People");

            migrationBuilder.DropColumn(
                name: "PersonAddressID",
                table: "People");

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "PersonAddress",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PersonAddress_PersonID",
                table: "PersonAddress",
                column: "PersonID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonAddress_People_PersonID",
                table: "PersonAddress",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
