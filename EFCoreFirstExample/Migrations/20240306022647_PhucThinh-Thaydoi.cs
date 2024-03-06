using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreFirstExample.Migrations
{
    public partial class PhucThinhThaydoi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "UserOrderProductName",
                table: "UserOrderProducts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "UserOrderProductId",
                table: "UserOrderProducts",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserDetail",
                newName: "UserDetailId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UserOrderProducts",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserOrderProducts");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "UserOrderProducts",
                newName: "UserOrderProductId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "UserOrderProducts",
                newName: "UserOrderProductName");

            migrationBuilder.RenameColumn(
                name: "UserDetailId",
                table: "UserDetail",
                newName: "Id");
        }
    }
}
