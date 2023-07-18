using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentityProjectDataAccessLayer.Migrations
{
    public partial class addmigrationcustomeraccountprocessremovemyproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "CustomerAccountProcesses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "CustomerAccountProcesses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
