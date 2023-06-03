using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreTask3.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checks");

            migrationBuilder.AddColumn<DateTime>(
                name: "ChakeTime",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChakeTime",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Checks",
                columns: table => new
                {
                    ChecksId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeChecks = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalChecks = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checks", x => x.ChecksId);
                });
        }
    }
}
