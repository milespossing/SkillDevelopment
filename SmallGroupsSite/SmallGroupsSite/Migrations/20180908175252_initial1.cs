using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallGroupsSite.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonAddress_Person_PersonID",
                table: "PersonAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonAddress",
                table: "PersonAddress");

            migrationBuilder.DropIndex(
                name: "IX_PersonAddress_PersonID",
                table: "PersonAddress");

            migrationBuilder.RenameTable(
                name: "PersonAddress",
                newName: "Addresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PersonID",
                table: "Addresses",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Person_PersonID",
                table: "Addresses",
                column: "PersonID",
                principalTable: "Person",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Person_PersonID",
                table: "Addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_PersonID",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "PersonAddress");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonAddress",
                table: "PersonAddress",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonAddress_PersonID",
                table: "PersonAddress",
                column: "PersonID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonAddress_Person_PersonID",
                table: "PersonAddress",
                column: "PersonID",
                principalTable: "Person",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
