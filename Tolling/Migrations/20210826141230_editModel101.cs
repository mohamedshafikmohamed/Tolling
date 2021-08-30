using Microsoft.EntityFrameworkCore.Migrations;

namespace Tolling.Migrations
{
    public partial class editModel101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocationDetails_Tool_ToolSerialNumber",
                table: "LocationDetails");

            migrationBuilder.DropIndex(
                name: "IX_LocationDetails_ToolSerialNumber",
                table: "LocationDetails");

            migrationBuilder.DropColumn(
                name: "ToolSerialNumber",
                table: "LocationDetails");

            migrationBuilder.RenameColumn(
                name: "SerialNumber1",
                table: "LocationDetails",
                newName: "SerialNumber");

            migrationBuilder.CreateIndex(
                name: "IX_LocationDetails_SerialNumber",
                table: "LocationDetails",
                column: "SerialNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_LocationDetails_Tool_SerialNumber",
                table: "LocationDetails",
                column: "SerialNumber",
                principalTable: "Tool",
                principalColumn: "SerialNumber",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocationDetails_Tool_SerialNumber",
                table: "LocationDetails");

            migrationBuilder.DropIndex(
                name: "IX_LocationDetails_SerialNumber",
                table: "LocationDetails");

            migrationBuilder.RenameColumn(
                name: "SerialNumber",
                table: "LocationDetails",
                newName: "SerialNumber1");

            migrationBuilder.AddColumn<string>(
                name: "ToolSerialNumber",
                table: "LocationDetails",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationDetails_ToolSerialNumber",
                table: "LocationDetails",
                column: "ToolSerialNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_LocationDetails_Tool_ToolSerialNumber",
                table: "LocationDetails",
                column: "ToolSerialNumber",
                principalTable: "Tool",
                principalColumn: "SerialNumber",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
