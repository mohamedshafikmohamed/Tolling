using Microsoft.EntityFrameworkCore.Migrations;

namespace Tolling.Migrations
{
    public partial class editModel84 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "z",
                table: "LocationDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "z",
                table: "LocationDetails");
        }
    }
}
