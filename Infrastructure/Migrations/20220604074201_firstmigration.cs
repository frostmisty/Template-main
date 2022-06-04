using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MsEnumItem",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemCategory = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    ItemValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ItemDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CrtUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TsCrt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TsMod = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ActiveFlag = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false, defaultValue: "Y")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MsEnumItem", x => x.ItemID);
                });

            migrationBuilder.CreateTable(
                name: "MsMenu",
                columns: table => new
                {
                    MenuId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ModuleId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PageId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ParentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seq = table.Column<int>(type: "int", nullable: true),
                    MenuText = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CrtUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TsCrt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TsMod = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ActiveFlag = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false, defaultValue: "Y")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MsMenu", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "MsModule",
                columns: table => new
                {
                    ModuleId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ModuleDesc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Info1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrtUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TsCrt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TsMod = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ActiveFlag = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false, defaultValue: "Y")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MsModule", x => x.ModuleId);
                });

            migrationBuilder.CreateTable(
                name: "MsPage",
                columns: table => new
                {
                    PageId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ModuleId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PageName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PageDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PageIcon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CrtUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TsCrt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TsMod = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ActiveFlag = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false, defaultValue: "Y")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MsPage", x => x.PageId);
                });

            migrationBuilder.CreateTable(
                name: "MsPermission",
                columns: table => new
                {
                    PermissionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CrtUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TsCrt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TsMod = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ActiveFlag = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false, defaultValue: "Y")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MsPermission", x => x.PermissionID);
                });

            migrationBuilder.CreateTable(
                name: "MsUser",
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
                    TsCrt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TsMod = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ActiveFlag = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false, defaultValue: "Y")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MsUser", x => new { x.UserId, x.ModuleId });
                });

            migrationBuilder.CreateTable(
                name: "MsUserRole",
                columns: table => new
                {
                    UserRoleId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModuleId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UserRoleDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CrtUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TsCrt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TsMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActiveFlag = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false, defaultValue: "Y")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MsUserRole", x => x.UserRoleId);
                });

            migrationBuilder.CreateTable(
                name: "MsUserRoleAccess",
                columns: table => new
                {
                    AccessID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRoleId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PageId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Permission = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CrtUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TsCrt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModUsrId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TsMod = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    ActiveFlag = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false, defaultValue: "Y")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MsUserRoleAccess", x => x.AccessID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MsEnumItem");

            migrationBuilder.DropTable(
                name: "MsMenu");

            migrationBuilder.DropTable(
                name: "MsModule");

            migrationBuilder.DropTable(
                name: "MsPage");

            migrationBuilder.DropTable(
                name: "MsPermission");

            migrationBuilder.DropTable(
                name: "MsUser");

            migrationBuilder.DropTable(
                name: "MsUserRole");

            migrationBuilder.DropTable(
                name: "MsUserRoleAccess");
        }
    }
}
