using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreFirstExample.Migrations
{
    public partial class AddUserOrderProductQuantityDiscountNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "UserOrderProducts",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreationDate",
                table: "UserOrderProducts",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "UserOrderProducts",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "UserOrderProducts",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModifiedDate",
                table: "UserOrderProducts",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "UserOrderProducts",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "UserOrderProducts",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "UserOrderProducts",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "UserOrderProducts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserOrderProductId",
                table: "UserOrderProducts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserOrderProductName",
                table: "UserOrderProducts",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "UserOrderProducts");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "UserOrderProducts");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "UserOrderProducts");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "UserOrderProducts");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "UserOrderProducts");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "UserOrderProducts");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "UserOrderProducts");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "UserOrderProducts");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "UserOrderProducts");

            migrationBuilder.DropColumn(
                name: "UserOrderProductId",
                table: "UserOrderProducts");

            migrationBuilder.DropColumn(
                name: "UserOrderProductName",
                table: "UserOrderProducts");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
