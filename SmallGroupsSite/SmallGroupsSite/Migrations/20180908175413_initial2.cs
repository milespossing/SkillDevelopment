using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallGroupsSite.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Person_PersonID",
                table: "Addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "PersonAddress");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_PersonID",
                table: "PersonAddress",
                newName: "IX_PersonAddress_PersonID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonAddress",
                table: "PersonAddress",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonAddress_Person_PersonID",
                table: "PersonAddress",
                column: "PersonID",
                principalTable: "Person",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonAddress_Person_PersonID",
                table: "PersonAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonAddress",
                table: "PersonAddress");

            migrationBuilder.RenameTable(
                name: "PersonAddress",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_PersonAddress_PersonID",
                table: "Addresses",
                newName: "IX_Addresses_PersonID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Person_PersonID",
                table: "Addresses",
                column: "PersonID",
                principalTable: "Person",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
