using Microsoft.EntityFrameworkCore.Migrations;

namespace Tolling.Migrations
{
    public partial class editmodels13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tooling_Movement_Log_ActionType_ActionTypeActionName",
                table: "Tooling_Movement_Log");

            migrationBuilder.RenameColumn(
                name: "ActionTypeActionName",
                table: "Tooling_Movement_Log",
                newName: "Action_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Tooling_Movement_Log_ActionTypeActionName",
                table: "Tooling_Movement_Log",
                newName: "IX_Tooling_Movement_Log_Action_Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Tooling_Movement_Log_ActionType_Action_Name",
                table: "Tooling_Movement_Log",
                column: "Action_Name",
                principalTable: "ActionType",
                principalColumn: "ActionName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tooling_Movement_Log_ActionType_Action_Name",
                table: "Tooling_Movement_Log");

            migrationBuilder.RenameColumn(
                name: "Action_Name",
                table: "Tooling_Movement_Log",
                newName: "ActionTypeActionName");

            migrationBuilder.RenameIndex(
                name: "IX_Tooling_Movement_Log_Action_Name",
                table: "Tooling_Movement_Log",
                newName: "IX_Tooling_Movement_Log_ActionTypeActionName");

            migrationBuilder.AddForeignKey(
                name: "FK_Tooling_Movement_Log_ActionType_ActionTypeActionName",
                table: "Tooling_Movement_Log",
                column: "ActionTypeActionName",
                principalTable: "ActionType",
                principalColumn: "ActionName",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
