using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentityProjectDataAccessLayer.Migrations
{
    public partial class mig_CustomerAccountProcess_add_description : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerAccountId",
                table: "CustomerAccounts",
                newName: "CustomerAccountID");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CustomerAccountProcesses",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "CustomerAccountProcesses");

            migrationBuilder.RenameColumn(
                name: "CustomerAccountID",
                table: "CustomerAccounts",
                newName: "CustomerAccountId");
        }
    }
}
