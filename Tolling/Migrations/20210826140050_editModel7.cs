using Microsoft.EntityFrameworkCore.Migrations;

namespace Tolling.Migrations
{
    public partial class editModel7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocationDetails_Tool_SerialNumber",
                table: "LocationDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LocationDetails",
                table: "LocationDetails");

            migrationBuilder.DropIndex(
                name: "IX_LocationDetails_SerialNumber",
                table: "LocationDetails");

            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "LocationDetails",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "LocationDetails",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "ToolSerialNumber",
                table: "LocationDetails",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocationDetails",
                table: "LocationDetails",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_LocationDetails_LocationId",
                table: "LocationDetails",
                column: "LocationId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocationDetails_Tool_ToolSerialNumber",
                table: "LocationDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LocationDetails",
                table: "LocationDetails");

            migrationBuilder.DropIndex(
                name: "IX_LocationDetails_LocationId",
                table: "LocationDetails");

            migrationBuilder.DropIndex(
                name: "IX_LocationDetails_ToolSerialNumber",
                table: "LocationDetails");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "LocationDetails");

            migrationBuilder.DropColumn(
                name: "ToolSerialNumber",
                table: "LocationDetails");

            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "LocationDetails",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocationDetails",
                table: "LocationDetails",
                columns: new[] { "LocationId", "SerialNumber" });

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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
