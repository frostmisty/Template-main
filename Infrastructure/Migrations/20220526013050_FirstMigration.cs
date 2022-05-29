using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MsPages_MsModules_ModuleId",
                table: "MsPages");

            migrationBuilder.DropForeignKey(
                name: "FK_MsUserRoles_MsModules_ModuleId",
                table: "MsUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MsUserRoles",
                table: "MsUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_MsUserRoles_ModuleId",
                table: "MsUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MsPages",
                table: "MsPages");

            migrationBuilder.DropIndex(
                name: "IX_MsPages_ModuleId",
                table: "MsPages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MsModules",
                table: "MsModules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MsMenus",
                table: "MsMenus");

            migrationBuilder.RenameColumn(
                name: "AccessId",
                table: "MsUserRoleAccesss",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ItemId",
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
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "MsMenus",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

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
                name: "ID",
                table: "MsUsers");

            migrationBuilder.DropColumn(
                name: "ID",
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
                newName: "AccessId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "MsEnumItems",
                newName: "ItemId");

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

            migrationBuilder.AlterColumn<string>(
                name: "ModuleId",
                table: "MsModules",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MenuId",
                table: "MsMenus",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

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

            migrationBuilder.CreateIndex(
                name: "IX_MsUserRoles_ModuleId",
                table: "MsUserRoles",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_MsPages_ModuleId",
                table: "MsPages",
                column: "ModuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_MsPages_MsModules_ModuleId",
                table: "MsPages",
                column: "ModuleId",
                principalTable: "MsModules",
                principalColumn: "ModuleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MsUserRoles_MsModules_ModuleId",
                table: "MsUserRoles",
                column: "ModuleId",
                principalTable: "MsModules",
                principalColumn: "ModuleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
