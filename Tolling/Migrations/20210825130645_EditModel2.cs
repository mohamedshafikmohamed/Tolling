using Microsoft.EntityFrameworkCore.Migrations;

namespace Tolling.Migrations
{
    public partial class EditModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tool_Location_LocationId",
                table: "Tool");

            migrationBuilder.DropIndex(
                name: "IX_Tool_LocationId",
                table: "Tool");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Tool");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Tool",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tool_LocationId",
                table: "Tool",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tool_Location_LocationId",
                table: "Tool",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
