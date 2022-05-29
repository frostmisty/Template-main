using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MsEnumItems",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemCategory = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    ItemValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ItemDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CrtUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TsCrt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TsMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActiveFlag = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MsEnumItems", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "MsMenus",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PageId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Seq = table.Column<int>(type: "int", nullable: true),
                    MenuText = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CrtUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TsCrt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TsMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActiveFlag = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MsMenus", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "MsModules",
                columns: table => new
                {
                    ModuleId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ModuleDesc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Info1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrtUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TsCrt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TsMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActiveFlag = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MsModules", x => x.ModuleId);
                });

            migrationBuilder.CreateTable(
                name: "MsUserRoleAccesss",
                columns: table => new
                {
                    AccessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRoleId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PageId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CrtUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TsCrt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TsMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActiveFlag = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MsUserRoleAccesss", x => x.AccessId);
                });

            migrationBuilder.CreateTable(
                name: "MsUsers",
                columns: table => new
                {
                    ModuleId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UserRoleId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Area = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Info1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrtUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TsCrt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TsMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActiveFlag = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MsUsers", x => new { x.UserId, x.ModuleId });
                });

            migrationBuilder.CreateTable(
                name: "MsPages",
                columns: table => new
                {
                    PageId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ModuleId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PageName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PageDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PageIcon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CrtUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TsCrt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TsMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActiveFlag = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MsPages", x => x.PageId);
                    table.ForeignKey(
                        name: "FK_MsPages_MsModules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "MsModules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MsUserRoles",
                columns: table => new
                {
                    UserRoleId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModuleId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UserRoleDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CrtUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TsCrt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TsMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActiveFlag = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MsUserRoles", x => x.UserRoleId);
                    table.ForeignKey(
                        name: "FK_MsUserRoles_MsModules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "MsModules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MsPages_ModuleId",
                table: "MsPages",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_MsUserRoles_ModuleId",
                table: "MsUserRoles",
                column: "ModuleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MsEnumItems");

            migrationBuilder.DropTable(
                name: "MsMenus");

            migrationBuilder.DropTable(
                name: "MsPages");

            migrationBuilder.DropTable(
                name: "MsUserRoleAccesss");

            migrationBuilder.DropTable(
                name: "MsUserRoles");

            migrationBuilder.DropTable(
                name: "MsUsers");

            migrationBuilder.DropTable(
                name: "MsModules");
        }
    }
}
