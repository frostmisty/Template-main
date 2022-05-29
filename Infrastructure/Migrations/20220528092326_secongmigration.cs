using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class secongmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MsUserRoles",
                table: "MsUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MsPages",
                table: "MsPages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MsModules",
                table: "MsModules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MsMenus",
                table: "MsMenus");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "MsUsers");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "MsUserRoles");

            migrationBuilder.DropColumn(
                name: "ModuleId",
                table: "MsUserRoles");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "MsPages");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "MsModules");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "MsMenus");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "MsUserRoleAccesss",
                newName: "AccessID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "MsEnumItems",
                newName: "ItemID");

            migrationBuilder.AlterColumn<string>(
                name: "ModuleId",
                table: "MsUsers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10)
                .Annotation("Relational:ColumnOrder", 0);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "MsUsers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<string>(
                name: "ModuleId",
                table: "MsUserRoleAccesss",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ModuleId",
                table: "MsModules",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MenuId",
                table: "MsMenus",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TsCrt",
                table: "MsEnumItems",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "ActiveFlag",
                table: "MsEnumItems",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "Y",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MsUserRoles",
                table: "MsUserRoles",
                column: "UserRoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MsPages",
                table: "MsPages",
                column: "PageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MsModules",
                table: "MsModules",
                column: "ModuleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MsMenus",
                table: "MsMenus",
                column: "MenuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MsUserRoles",
                table: "MsUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MsPages",
                table: "MsPages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MsModules",
                table: "MsModules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MsMenus",
                table: "MsMenus");

            migrationBuilder.DropColumn(
                name: "ModuleId",
                table: "MsUserRoleAccesss");

            migrationBuilder.RenameColumn(
                name: "AccessID",
                table: "MsUserRoleAccesss",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ItemID",
                table: "MsEnumItems",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "ModuleId",
                table: "MsUsers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10)
                .OldAnnotation("Relational:ColumnOrder", 0);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "MsUsers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "MsUsers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "MsUserRoles",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "ModuleId",
                table: "MsUserRoles",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "MsPages",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "ModuleId",
                table: "MsModules",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "MsModules",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "MenuId",
                table: "MsMenus",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "MsMenus",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TsCrt",
                table: "MsEnumItems",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<string>(
                name: "ActiveFlag",
                table: "MsEnumItems",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldDefaultValueSql: "Y");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MsUserRoles",
                table: "MsUserRoles",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MsPages",
                table: "MsPages",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MsModules",
                table: "MsModules",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MsMenus",
                table: "MsMenus",
                column: "ID");
        }
    }
}
