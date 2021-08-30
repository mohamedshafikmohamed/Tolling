using Microsoft.EntityFrameworkCore.Migrations;

namespace Tolling.Migrations
{
    public partial class editmodels12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tooling_Movement_Log_Tool_SerialNumber",
                table: "Tooling_Movement_Log");

            migrationBuilder.RenameColumn(
                name: "SerialNumber",
                table: "Tooling_Movement_Log",
                newName: "serialNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Tooling_Movement_Log_SerialNumber",
                table: "Tooling_Movement_Log",
                newName: "IX_Tooling_Movement_Log_serialNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Tooling_Movement_Log_Tool_serialNumber",
                table: "Tooling_Movement_Log",
                column: "serialNumber",
                principalTable: "Tool",
                principalColumn: "SerialNumber",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tooling_Movement_Log_Tool_serialNumber",
                table: "Tooling_Movement_Log");

            migrationBuilder.RenameColumn(
                name: "serialNumber",
                table: "Tooling_Movement_Log",
                newName: "SerialNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Tooling_Movement_Log_serialNumber",
                table: "Tooling_Movement_Log",
                newName: "IX_Tooling_Movement_Log_SerialNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Tooling_Movement_Log_Tool_SerialNumber",
                table: "Tooling_Movement_Log",
                column: "SerialNumber",
                principalTable: "Tool",
                principalColumn: "SerialNumber",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
