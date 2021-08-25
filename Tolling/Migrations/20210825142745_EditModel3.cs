using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tolling.Migrations
{
    public partial class EditModel3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocationDetails");

            migrationBuilder.DropTable(
                name: "PartTool");

            migrationBuilder.DropTable(
                name: "Tooling_Movement_Log");

            migrationBuilder.DropTable(
                name: "ToolPart");

            migrationBuilder.DropTable(
                name: "Part");

            migrationBuilder.DropTable(
                name: "Tool");

            migrationBuilder.AddColumn<string>(
                name: "RoleName",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoleName1",
                table: "Users",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleName);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleName1",
                table: "Users",
                column: "RoleName1");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Role_RoleName1",
                table: "Users",
                column: "RoleName1",
                principalTable: "Role",
                principalColumn: "RoleName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Role_RoleName1",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleName1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RoleName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RoleName1",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "Part",
                columns: table => new
                {
                    PartNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Part", x => x.PartNumber);
                });

            migrationBuilder.CreateTable(
                name: "Tool",
                columns: table => new
                {
                    SerialNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Height = table.Column<double>(type: "float", nullable: false),
                    NoOfCavities = table.Column<int>(type: "int", nullable: false),
                    ReciviedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToolOwner = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tool", x => x.SerialNumber);
                });

            migrationBuilder.CreateTable(
                name: "LocationDetails",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    SerialNumber = table.Column<int>(type: "int", nullable: false),
                    LockerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationDetails", x => new { x.LocationId, x.SerialNumber });
                    table.ForeignKey(
                        name: "FK_LocationDetails_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationDetails_Locker_LockerId",
                        column: x => x.LockerId,
                        principalTable: "Locker",
                        principalColumn: "LockerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationDetails_Tool_SerialNumber",
                        column: x => x.SerialNumber,
                        principalTable: "Tool",
                        principalColumn: "SerialNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartTool",
                columns: table => new
                {
                    ToolPartPartNumber = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    ToolPartSerialNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartTool", x => new { x.ToolPartPartNumber, x.ToolPartSerialNumber });
                    table.ForeignKey(
                        name: "FK_PartTool_Part_ToolPartPartNumber",
                        column: x => x.ToolPartPartNumber,
                        principalTable: "Part",
                        principalColumn: "PartNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartTool_Tool_ToolPartSerialNumber",
                        column: x => x.ToolPartSerialNumber,
                        principalTable: "Tool",
                        principalColumn: "SerialNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tooling_Movement_Log",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionTakenAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionTypeActionName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    SerialNumber = table.Column<int>(type: "int", nullable: false),
                    ToolSerialNumber = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tooling_Movement_Log", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tooling_Movement_Log_ActionType_ActionTypeActionName",
                        column: x => x.ActionTypeActionName,
                        principalTable: "ActionType",
                        principalColumn: "ActionName",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tooling_Movement_Log_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tooling_Movement_Log_Tool_ToolSerialNumber",
                        column: x => x.ToolSerialNumber,
                        principalTable: "Tool",
                        principalColumn: "SerialNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tooling_Movement_Log_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ToolPart",
                columns: table => new
                {
                    SerialNumber = table.Column<int>(type: "int", nullable: false),
                    PartNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToolPart", x => new { x.SerialNumber, x.PartNumber });
                    table.ForeignKey(
                        name: "FK_ToolPart_Part_PartNumber",
                        column: x => x.PartNumber,
                        principalTable: "Part",
                        principalColumn: "PartNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ToolPart_Tool_SerialNumber",
                        column: x => x.SerialNumber,
                        principalTable: "Tool",
                        principalColumn: "SerialNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LocationDetails_LockerId",
                table: "LocationDetails",
                column: "LockerId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationDetails_SerialNumber",
                table: "LocationDetails",
                column: "SerialNumber");

            migrationBuilder.CreateIndex(
                name: "IX_PartTool_ToolPartSerialNumber",
                table: "PartTool",
                column: "ToolPartSerialNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Tooling_Movement_Log_ActionTypeActionName",
                table: "Tooling_Movement_Log",
                column: "ActionTypeActionName");

            migrationBuilder.CreateIndex(
                name: "IX_Tooling_Movement_Log_LocationId",
                table: "Tooling_Movement_Log",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tooling_Movement_Log_ToolSerialNumber",
                table: "Tooling_Movement_Log",
                column: "ToolSerialNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Tooling_Movement_Log_UserId",
                table: "Tooling_Movement_Log",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ToolPart_PartNumber",
                table: "ToolPart",
                column: "PartNumber");
        }
    }
}
