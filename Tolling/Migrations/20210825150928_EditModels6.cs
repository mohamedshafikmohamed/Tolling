using Microsoft.EntityFrameworkCore.Migrations;

namespace Tolling.Migrations
{
    public partial class EditModels6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tooling_Movement_Log_Tool_ToolSerialNumber",
                table: "Tooling_Movement_Log");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Role_RoleName1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleName1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Tooling_Movement_Log_ToolSerialNumber",
                table: "Tooling_Movement_Log");

            migrationBuilder.DropColumn(
                name: "RoleName1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ToolSerialNumber",
                table: "Tooling_Movement_Log");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleName",
                table: "Users",
                column: "RoleName");

            migrationBuilder.CreateIndex(
                name: "IX_Tooling_Movement_Log_SerialNumber",
                table: "Tooling_Movement_Log",
                column: "SerialNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Tooling_Movement_Log_Tool_SerialNumber",
                table: "Tooling_Movement_Log",
                column: "SerialNumber",
                principalTable: "Tool",
                principalColumn: "SerialNumber",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Role_RoleName",
                table: "Users",
                column: "RoleName",
                principalTable: "Role",
                principalColumn: "RoleName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tooling_Movement_Log_Tool_SerialNumber",
                table: "Tooling_Movement_Log");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Role_RoleName",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleName",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Tooling_Movement_Log_SerialNumber",
                table: "Tooling_Movement_Log");

            migrationBuilder.AddColumn<string>(
                name: "RoleName1",
                table: "Users",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ToolSerialNumber",
                table: "Tooling_Movement_Log",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleName1",
                table: "Users",
                column: "RoleName1");

            migrationBuilder.CreateIndex(
                name: "IX_Tooling_Movement_Log_ToolSerialNumber",
                table: "Tooling_Movement_Log",
                column: "ToolSerialNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Tooling_Movement_Log_Tool_ToolSerialNumber",
                table: "Tooling_Movement_Log",
                column: "ToolSerialNumber",
                principalTable: "Tool",
                principalColumn: "SerialNumber",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Role_RoleName1",
                table: "Users",
                column: "RoleName1",
                principalTable: "Role",
                principalColumn: "RoleName",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
